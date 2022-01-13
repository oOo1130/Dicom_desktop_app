using DocumentFormat.OpenXml.Packaging;
using Novacode;
using OpenXmlPowerTools;
using RIS.Models;
using RIS.Models.VWModels;
using RIS.Services;
using RIS.UI;
using RIS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RIS.UIs
{
    public partial class frmReportAndViewerPanel : Form
    {
        private VMReportObj _reportObj;
        ProcessStartInfo vrProcess;
      
        bool unlocked = true;
        User _user;
        static DocX g_document;

        string ReportFilePath = string.Empty;
        string ReportFileNameWithPath = string.Empty;

        byte[] _masteremplatecontent = null;

        ReportConsultant _doctor=null;

        DateTime _OpDateTime;

      

        public frmReportAndViewerPanel(VMReportObj rpObj)
        {
            InitializeComponent();

            _reportObj = rpObj;

            _masteremplatecontent = rpObj.MsWord_masteremplatecontent;
            _doctor = rpObj.ReportConsultant;

            _user = rpObj.user;

        }



        [DllImport("user32")]

        public static extern long SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int X, int y, int cx, int cy, int wFlagslong);

        const short SWP_NOSIZE = 0x0001;

        const short SWP_NOMOVE = 0x0002;

        const int SWP_NOZORDER = 0x0004;

        const int SWP_SHOWWINDOW = 0x0040;


        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]

        public static extern int GetWindowLong(

        IntPtr hwnd,

        int nIndex

        );


        const int WS_THICKFRAME = 0x00040000;

        const int GWL_STYLE = -16;


        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]

        public static extern int SetWindowLong(

        IntPtr hwnd,

        int nIndex,

        int dwNewLong

        );

        private void frmReportAndViewerPanel_Load(object sender, EventArgs e)
        {
            
            _OpDateTime = Utils.GetServerDateAndTime();

            ctrlTemplateSearch.Location = new Point(txtTemplateSearch.Location.X, txtTemplateSearch.Location.Y);
            ctrlTemplateSearch.ItemSelected += ctrlTemplateSearch_ItemSelected;
        }

        private void ctrlTemplateSearch_ItemSelected(SearchResultListControl<ProcedureRadiologistTemplate> sender, ProcedureRadiologistTemplate item)
        {
            txtTemplateSearch.Text = item.TemplateName;
            txtTemplateSearch.Tag = item.Id;
            txtTemplateSearch.Focus();
            sender.Visible = false;

        }

        private  void StartReportFile(VMReportObj rObj)
        {

            this.KillRunningProcess();

            Process p1 = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo(rObj.WordfilePath);

            p1.StartInfo = startInfo;

            p1.Start();

            p1.EnableRaisingEvents = true;
            p1.Exited +=  p1_Exited;

            

            int i = 0;

            while (i == 0)

            {

                System.Console.WriteLine("asdas");

                System.Threading.Thread.Sleep(100);

                p1.Refresh();

                i = p1.MainWindowHandle.ToInt32();

            }


            IntPtr h1 = p1.MainWindowHandle;

            Point screenlocation = Screen.AllScreens[0].Bounds.Location;

            SetWindowPos(h1, -1, screenlocation.X + Screen.AllScreens[0].Bounds.Width / 2, screenlocation.Y, Screen.AllScreens[0].Bounds.Width / 2, Screen.AllScreens[0].Bounds.Height, SWP_NOZORDER | SWP_SHOWWINDOW);

            int lNewLong = GetWindowLong(h1, GWL_STYLE);

            SetWindowLong(h1, GWL_STYLE, lNewLong & ~WS_THICKFRAME);

            p1.WaitForExit();
        }

        private async void p1_Exited(object sender, EventArgs e)
        {

          
            bool isReportCompleted = true;

            string msgresult = CustomMessageBox.showBox("RIS-REPORT", "Is the report complete ?");
            if (msgresult.Equals("2")) isReportCompleted = false;


            await Task.Run(() => {

                try
                {

                    FileInfo fileInfo = new FileInfo(_reportObj.ReportFileNameWithPath);
                    if (fileInfo.CreationTime.CompareTo(fileInfo.LastWriteTime) < 0)
                    {
                        using (BinaryReader b = new BinaryReader(File.Open(_reportObj.ReportFileNameWithPath, FileMode.Open)))
                        {
                            VMRISWorklistSubSetForLV wlObj = _reportObj.vmRISWorkList;

                       

                            string msg = string.Empty;

                            int length = (int)b.BaseStream.Length;
                            byte[] ReportContent = new byte[length];
                            b.Read(ReportContent, 0, length);



                            if (wlObj.Modality.ToUpper().Equals("DX") || wlObj.Modality.ToUpper().Equals("DR") || wlObj.Modality.ToUpper().Equals("CR") || wlObj.Modality.ToUpper().Equals("MG") || wlObj.Modality.ToUpper().Equals("ECG"))
                            {

                                RadiologistOpinionOne _existingOpinion = new ReportService().DxRxCrExistingReportForThisConsultant(wlObj.ProcId, wlObj.ConsultantId);


                                if (_existingOpinion != null)
                                {

                                    // _existingOpinion.OpDate = _OpDateTime.Date;
                                    // _existingOpinion.OpTime = _OpDateTime.ToString("hh:mm tt");
                                    _existingOpinion.ReportContent = ReportContent;
                                    _existingOpinion.ReportPath = "";
                                    _existingOpinion.isReportComplete = isReportCompleted;
                                    if (new ReportService().UpdateDxDrCrReport(_existingOpinion, isReportCompleted))
                                    {

                                        if (isReportCompleted)
                                        {
                                            string processName = "RadiAntViewer.exe".Replace(".exe", "");

                                            foreach (Process process in Process.GetProcessesByName(processName))
                                            {
                                                process.Kill();
                                            }

                                            this.Invoke(new MethodInvoker(delegate ()
                                            {
                                                this.Close();
                                            }));

                                         
                                        }

                                        //MessageBox.Show("Report modify successful", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }
                                else
                                {
                                    RadiologistOpinionOne newReport = new RadiologistOpinionOne();
                                    newReport.ProcId = wlObj.ProcId;
                                    newReport.RCId = wlObj.ConsultantId;
                                    newReport.OpDate = _OpDateTime.Date;
                                    newReport.OpTime = _OpDateTime.ToString("hh:mm tt");
                                    newReport.ReportContent = ReportContent;
                                    newReport.ReportPath = "";
                                    newReport.isReportComplete = isReportCompleted;
                                    if (new ReportService().SaveDxDrCrReport(newReport, isReportCompleted)) // This method will also update the Worklist item status as complete
                                    {

                                        if (isReportCompleted)
                                        {
                                            string processName = "RadiAntViewer.exe".Replace(".exe", "");

                                            foreach (Process process in Process.GetProcessesByName(processName))
                                            {
                                                process.Kill();
                                            }

                                            this.Invoke(new MethodInvoker(delegate ()
                                            {
                                                this.Close();
                                            }));

                                        }

                                        //MessageBox.Show("Report save successful", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }

                            }
                            else // CT, MR Report
                            {

                                RadiologistOpinionTwo _existingOpinion = new ReportService().CTMRExistingReportForThisConsultant(wlObj.ProcId, wlObj.ConsultantId);


                                if (_existingOpinion != null)
                                {

                                    // _existingOpinion.OpDate = _OpDateTime.Date;
                                    // _existingOpinion.OpTime = _OpDateTime.ToString("hh:mm tt");
                                    _existingOpinion.ReportContent = ReportContent;
                                    _existingOpinion.ReportPath = "";
                                    _existingOpinion.isReportComplete = isReportCompleted;

                                    if (new ReportService().UpdateCTMRReport(_existingOpinion, isReportCompleted))
                                    {

                                        if (isReportCompleted)
                                        {
                                            string processName = "RadiAntViewer.exe".Replace(".exe", "");

                                            foreach (Process process in Process.GetProcessesByName(processName))
                                            {
                                                process.Kill();
                                            }

                                            this.Invoke(new MethodInvoker(delegate ()
                                            {
                                                this.Close();
                                            }));

                                        }

                                        //MessageBox.Show("Report modify successful", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);



                                    }
                                }
                                else
                                {
                                    RadiologistOpinionTwo newReport = new RadiologistOpinionTwo();
                                    newReport.ProcId = wlObj.ProcId;
                                    newReport.RCId = wlObj.ConsultantId;
                                    newReport.OpDate = _OpDateTime.Date;
                                    newReport.OpTime = _OpDateTime.ToString("hh:mm tt");
                                    newReport.ReportContent = ReportContent;
                                    newReport.ReportPath = "";
                                    newReport.isReportComplete = isReportCompleted;
                                    if (new ReportService().SaveCTMRReport(newReport, isReportCompleted))
                                    {
                                        if (isReportCompleted)
                                        {
                                            string processName = "RadiAntViewer.exe".Replace(".exe", "");

                                            foreach (Process process in Process.GetProcessesByName(processName))
                                            {
                                                process.Kill();
                                            }

                                            this.Invoke(new MethodInvoker(delegate ()
                                            {
                                                this.Close();
                                            }));

                                        }

                                        //MessageBox.Show("Report save successful", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }


                            }



                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RIS");
                }


            });
            
            
        }

        private void KillRunningProcess()
        {
            Process[] procs = Process.GetProcessesByName("winword");

            foreach (Process proc in procs)
                proc.Kill();
        }

        private async void StartViewer()
        {

           await this.EndTask("RadiAntViewer.exe");

            var directories = _reportObj.Studies
         .Select(item => Path.Combine(_reportObj.NetworkRootPath, item.TenantId.ToString(), item.StudyInstanceUid))
         .ToList();
            var args = String.Format("-d {0}", String.Join(" ", directories));

            vrProcess = new ProcessStartInfo
            {
                Arguments = args,
                FileName = _reportObj.ViewerExecutablePath
            };


            Process p2 = new Process();

            p2.StartInfo = vrProcess;

            p2.Start();


            int i = 0;

            while (i == 0)

            {

               // System.Console.WriteLine("asdas");

                System.Threading.Thread.Sleep(100);

                p2.Refresh();

                i = p2.MainWindowHandle.ToInt32();

            }


            IntPtr h1 = p2.MainWindowHandle;

            Point screenlocation = Screen.AllScreens[0].Bounds.Location;

            SetWindowPos(h1, -1, screenlocation.X, screenlocation.Y, Screen.AllScreens[0].Bounds.Width / 2, Screen.AllScreens[0].Bounds.Height, SWP_NOZORDER | SWP_SHOWWINDOW);

            int lNewLong = GetWindowLong(h1, GWL_STYLE);

            SetWindowLong(h1, GWL_STYLE, lNewLong & ~WS_THICKFRAME);

        }


        public async Task<bool> EndTask(string taskname)
        {
            string processName = taskname.Replace(".exe", "");

            foreach (Process process in Process.GetProcessesByName(processName))
            {
                process.Kill();
            }

            return await Task.FromResult(true);
        }


       

        private void frmReportAndViewerPanel_Shown(object sender, EventArgs e)
        {
         
            StartViewer();
            StartReportFile(_reportObj);

        }

        private void txtTemplateSearch_TextChanged(object sender, EventArgs e)
        {
            int itemId;
            if (int.TryParse(txtTemplateSearch.Text, out itemId))
            {

            }
            else
            {
                if (unlocked)
                {
                    string _txt = txtTemplateSearch.Text;
                    HideAllDefaultHidden();
                    ctrlTemplateSearch.Visible = true;
                    ctrlTemplateSearch.txtSearch.Text = _txt;
                    ctrlTemplateSearch.txtSearch.SelectionStart = ctrlTemplateSearch.txtSearch.Text.Length;
                    if (_user.RoleId == 3)
                    {
                        ctrlTemplateSearch.LoadDataByType(_user.RCId.ToString());
                    }
                    else
                    {
                        ctrlTemplateSearch.LoadData();
                    }
                }
            }
        }

        private void HideAllDefaultHidden()
        {
            ctrlTemplateSearch.Visible = false;
        }

        private void ctrlTemplateSearch_SearchEsacaped(bool IsEscaped)
        {
            if (IsEscaped)
            {
                txtTemplateSearch.Focus();
            }
        }

        private void txtTemplateSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int _templateId = 0;
                int.TryParse(txtTemplateSearch.Tag.ToString(), out _templateId);


                ShowTemplate(_templateId);
            }
        }

        private async void ShowTemplate(int templateId)
        {

          
            ReportFilePath = MainForm.LoggedinUser.ReportCreateLocation;
            ReportFileNameWithPath = ReportFilePath + @"\" + _reportObj.vmRISWorkList.PatientId + "-" + _reportObj.vmRISWorkList.TenantId.ToString() + ".docx";

            //TempMasterReoprtNameWithPath = ReportFilePath + @"\" + txtBillNo.Text + "-" + ((ViewModelReportTests)txtCurrentTestName.Tag).Id.ToString() + ".docx";
            //TempChildReoprtNameWithPath = ReportFilePath + @"\" + txtBillNo.Text + "-" + ((ViewModelReportTests)txtCurrentTestName.Tag).Id.ToString() + ".docx";

            MasterTemplate _masterTemplate  = await new RISAPIConsumerService().GetWordMasterTemplateContent();

            ProcedureRadiologistTemplate _templateObj = new RISService().GetWordTemplateContent(templateId);
            byte[] _childtemplatecontent = _templateObj.TemplateContent;


            if (!Directory.Exists(ReportFilePath))
            {
                Directory.CreateDirectory(@ReportFilePath);
            }

            if (File.Exists(ReportFileNameWithPath))
            {
                File.Delete(ReportFileNameWithPath);
            }



            List<Source> documentBuilderSources = new List<Source>();
            List<byte[]> docs = new List<byte[]>();
            docs.Add(_masteremplatecontent);
            docs.Add(_childtemplatecontent);
            byte[] reportcontent = _masteremplatecontent;

            FileStream fsmaster = new FileStream(ReportFileNameWithPath, FileMode.OpenOrCreate);
            BinaryWriter br = new BinaryWriter(fsmaster);
            br.Write(reportcontent);
            fsmaster.Dispose();
            br.Dispose();

            VMReportObj rObj = new VMReportObj();
            rObj.WordfilePath = ReportFileNameWithPath;

            using (g_document = CreateReportFromTemplate(DocX.Load(@ReportFileNameWithPath)))
            {

                g_document.SaveAs(ReportFileNameWithPath);
            }

            StartReportFile(rObj);

            //ProcessStartInfo psi = new ProcessStartInfo(ReportFileNameWithPath);
            //Process process = Process.Start(psi);
            //process.EnableRaisingEvents = true;
            //process.Exited += process_Exited;

            //process.WaitForExit();

        }

        private DocX CreateReportFromTemplate(DocX template)
        {

           


            template.ReplaceText("Report_Type", "DEPARTMENT OF RADIOLOGY & IMAGING");



            //template.ReplaceText("Id_No", wListItem.PatientId.ToString());

            //template.ReplaceText("Received_date", wListItem.OrderDateTime.ToString());
            //template.ReplaceText("Report_Date", _serverDateTime.ToString());
            ////template.ReplaceText("daily_id", txtDID.Text);
            //template.ReplaceText("Report_Date", DateTime.Now.ToString("dd/MM/yyyy"));
            //template.ReplaceText("Patient_Name", wListItem.PatientName);
            //template.ReplaceText("Patient_Age", "");
            //template.ReplaceText("Patient_Sex", wListItem.PatientSex);
            //template.ReplaceText("Refd_By", wListItem.ReferralPhysician);


            template.AddFooters();

          

            if (_doctor != null)
            {

                MemoryStream ms = new MemoryStream(_doctor.ESignature);

                Novacode.Image image = template.AddImage(ms);

                Picture picture = image.CreatePicture();

                // Get the default Footer for this document.
                Footer footer_default = template.Footers.odd;

                // Insert a new Paragraph into the document.
                Paragraph p1 = footer_default.InsertParagraph();
                p1.Alignment = Alignment.left;
                p1.AppendPicture(picture);



                p1.AppendLine(_doctor.Name);
                p1.AppendLine(_doctor.IdentityLine1);
                p1.AppendLine(_doctor.IdentityLine2);
                p1.AppendLine(_doctor.IdentityLine3);
                p1.AppendLine(_doctor.IdentityLine4);

            }
            else
            {
                template.ReplaceText("Doctor_Name", "");
                template.ReplaceText("Identity_Line1", "");
                template.ReplaceText("Identity_Line2", "");
                template.ReplaceText("Identity_Line3", "");
                template.ReplaceText("Identity_Line4", "");
                template.ReplaceText("Identity_Line5", " ");
            }


            return template;
        }


        private byte[] OpenAndCombine(IList<byte[]> documents)
        {
            MemoryStream mainStream = new MemoryStream();

            mainStream.Write(documents[0], 0, documents[0].Length);
            mainStream.Position = 0;

            int pointer = 1;
            byte[] ret;
            try
            {
                using (WordprocessingDocument mainDocument = WordprocessingDocument.Open(mainStream, true))
                {

                    XElement newBody = XElement.Parse(mainDocument.MainDocumentPart.Document.Body.OuterXml);

                    for (pointer = 1; pointer < documents.Count; pointer++)
                    {
                        WordprocessingDocument tempDocument = WordprocessingDocument.Open(new MemoryStream(documents[pointer]), true);
                        XElement tempBody = XElement.Parse(tempDocument.MainDocumentPart.Document.Body.OuterXml);

                        newBody.Add(tempBody);
                        mainDocument.MainDocumentPart.Document.Body = new DocumentFormat.OpenXml.Wordprocessing.Body(newBody.ToString());
                        mainDocument.MainDocumentPart.Document.Save();
                        mainDocument.Package.Flush();
                    }
                }
            }
            catch (OpenXmlPackageException oxmle)
            {
                throw new Exception(string.Format(CultureInfo.CurrentCulture, "Error while merging files. Document index {0}", pointer), oxmle);

            }
            catch (Exception e)
            {
                throw new Exception(string.Format(CultureInfo.CurrentCulture, "Error while merging files. Document index {0}", pointer), e);
            }
            finally
            {
                ret = mainStream.ToArray();
                mainStream.Close();
                mainStream.Dispose();
            }
            return (ret);
        }
    }
}
