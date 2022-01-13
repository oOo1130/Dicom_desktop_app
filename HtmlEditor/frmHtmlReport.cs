using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHtmlEditor;
using System.Data.OleDb;
using System.IO;
using System.Collections;
using RIS.Utility;
using RIS.Models;
using RIS.Models.VWModels;
using System.Diagnostics;
using RIS.Services;
using HtmlAgilityPack;
using System.Threading;
using RIS.UI;
using System.Globalization;
using DocumentFormat.OpenXml.Packaging;
using System.Xml.Linq;
using Novacode;
using DocumentLib;

namespace htmledit
{

    public partial class frmHtmlReport : Form
    {

        readonly OpenFileDialog openFileDialog = new OpenFileDialog();

        string htmlText = string.Empty;
        string templateFile = string.Empty;
        string textReplacementsString = string.Empty;
        string imageReplacementsString = string.Empty;
        //bool openFile => chkOpenFile.Checked;




        const string html_template = "template_001.htm";

        static DocX g_document;

        string ReportFilePath = string.Empty;
        string ReportFileNameWithPath = string.Empty;


        private VMReportObj _reportObj;
        ProcessStartInfo vrProcess;

        bool unlocked = true;
        User _user;

        bool isLoaded = false;
       

        public delegate void _InvokeMethodForChildTemplateLoad(int rcId);


        ReportConsultant _doctor = null;

        DateTime _OpDateTime;

        public static OleDbConnection dbconn;
        OleDbDataAdapter dataadapter;
        DataTable dt;

        IDictionary<string, string> macroListDictionary;

       
        public frmHtmlReport(VMReportObj rpObj)
        {
            InitializeComponent();

            _reportObj = rpObj;

          
            _doctor = rpObj.ReportConsultant;

            _user = rpObj.user;
        }

        private  void MainForm_Load(object sender, EventArgs e)
        {
          

            macroListDictionary = new Dictionary<string, string>();

            

                this.Text = this.Text + " (" + _reportObj.vmRISWorkList.PatientId.ToString() + ", " + _reportObj.vmRISWorkList.PatientName + ", " + _reportObj.vmRISWorkList.ProcedureHISName + _reportObj.vmRISWorkList.HospitalName + ")";


                _OpDateTime = _reportObj.OpinionDateTime;

                htmlEditor1.MacroListDictionary = _reportObj.macroDictionary;  //macroListDictionary; // If dictionary is set, then it will check each word
                                                                               // as it is typed and do text replacement 
            



            isLoaded = false;


          

            this.BeginInvoke((MethodInvoker)this.SetMasterTemplate);
            this.BeginInvoke((MethodInvoker)this.LoadChildTemplates);
           


            btnReportComplete.GotFocus += BtnReportComplete_GotFocus;
            btnReportComplete.LostFocus += BtnReportComplete_LostFocus;


            btnWord.GotFocus += btnWord_GotFocus;
            btnWord.LostFocus += btnWord_LostFocus;

            btnPDF.GotFocus += btnPDF_GotFocus;
            btnPDF.LostFocus += btnPDF_LostFocus;



            isLoaded = true;


            this.htmlEditor1.FontName = new FontFamily("Calibri");
            this.htmlEditor1.FontSize = FontSize.Five;
            this.htmlEditor1.BodyInnerHTML = "<FONT size=5 face=Calibri></FONT>";
          


        }

        private void btnPDF_LostFocus(object sender, EventArgs e)
        {
            btnPDF.FlatStyle = FlatStyle.Standard;
            btnPDF.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnPDF_GotFocus(object sender, EventArgs e)
        {
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.FlatAppearance.BorderColor = Color.DarkGreen;
        }

        private void btnWord_LostFocus(object sender, EventArgs e)
        {
            btnWord.FlatStyle = FlatStyle.Standard;
            btnWord.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnWord_GotFocus(object sender, EventArgs e)
        {
            btnWord.FlatStyle = FlatStyle.Flat;
            btnWord.FlatAppearance.BorderColor = Color.DarkGreen;
        }

        private void SetReportContent(string reportContent)
        {
            htmlEditor1.InsertHTMLWithinTag(reportContent, "Prescription");
        }

        private void BtnReportComplete_LostFocus(object sender, EventArgs e)
        {
            btnReportComplete.FlatStyle = FlatStyle.Standard;
            btnReportComplete.FlatAppearance.BorderColor = Color.Gray;
        }

        private void BtnReportComplete_GotFocus(object sender, EventArgs e)
        {
            btnReportComplete.FlatStyle = FlatStyle.Flat;
            btnReportComplete.FlatAppearance.BorderColor = Color.DarkGreen;
        }

        private  void LoadChildTemplates()
        {
            if (_reportObj.htmlTemplates != null)
            {
                List<HtmlTempleForReport> _templistList = _reportObj.htmlTemplates;
                _templistList.Insert(0, new HtmlTempleForReport() { Id = 0, RCId = 0, TemplateName = "Select Template" });
                cmbSelectTemplate.DataSource = _templistList;
                cmbSelectTemplate.DisplayMember = "TemplateName";
                cmbSelectTemplate.ValueMember = "Id";
            }

           
        }

        private async void SetMasterTemplate()
        {
            string f_in = string.Empty;
            string text = string.Empty;
            
            f_in = _reportObj.Html_masteremplatecontent;
           

            //string f_out = Application.StartupPath + System.IO.Path.DirectorySeparatorChar + "output.htm";

            string report_text = ""; //dt.Rows[c]["report_text"].ToString();

            if (_reportObj != null)
            {
                VMRISWorklistSubSetForLV patient = _reportObj.vmRISWorkList;
                string _age = GetAgeFromDob(patient.PatientBirthdate);
                string patient_idno = patient.PatientId;
                string receive_date = patient.ArrivalDateTime.ToString("dd/MM/yyyy hh:mm tt");
                string report_print_date = patient.ArrivalDateTime.ToString("dd/MM/yyyy hh:mm tt");
                string patient_name = patient.PatientName;
                string patient_age = _age;
                string patient_sex = patient.PatientSex;
                string refered_by = patient.ReferralPhysician;
              
                int doctor_id = patient.ConsultantId;

                string footer_text = "";



                text = f_in;
                text = text.Replace("%PATIENT_IDNO%", patient_idno);
                text = text.Replace("%RECEIVE_DATE%", receive_date);
                text = text.Replace("%REPORT_PRINT_DATE%", report_print_date);
                text = text.Replace("%PATIENT_NAME%", patient_name);
                text = text.Replace("%PATIENT_AGE%", patient_age);
                text = text.Replace("%PATIENT_SEX%", patient_sex);
                text = text.Replace("%REFERED_BY%", refered_by);
                text = text.Replace("%REPORT_TEXT%", report_text);
                text = text.Replace("%FOOTER_TEXT%", footer_text);


                if (_reportObj.ReportConsultant != null)
                {

                    text = text.Replace("%SIGNATURE%", _reportObj.ReportConsultant.SignatureBase64HtmlEmbeded);

                    text = text.Replace("%DOCTOR_NAME%", _reportObj.ReportConsultant.Name);
                    text = text.Replace("%IDENTITY_LINE1%", _reportObj.ReportConsultant.IdentityLine1);
                    text = text.Replace("%IDENTITY_LINE2%", _reportObj.ReportConsultant.IdentityLine2);
                    text = text.Replace("%IDENTITY_LINE3%", _reportObj.ReportConsultant.IdentityLine3);
                    text = text.Replace("%IDENTITY_LINE4%", _reportObj.ReportConsultant.IdentityLine4);
                    text = text.Replace("%IDENTITY_LINE5%", _reportObj.ReportConsultant.IdentityLine5);
                }
                else
                {
                    if (_reportObj.vmRISWorkList.Status == 6)
                    {
                        ReportConsultant _consultant = await new RISAPIConsumerService().GetReportConsultant(_reportObj.vmRISWorkList.ConsultantId);

                        text = text.Replace("%SIGNATURE%", _consultant.SignatureBase64HtmlEmbeded);

                        text = text.Replace("%DOCTOR_NAME%", _consultant.Name);
                        text = text.Replace("%IDENTITY_LINE1%", _consultant.IdentityLine1);
                        text = text.Replace("%IDENTITY_LINE2%", _consultant.IdentityLine2);
                        text = text.Replace("%IDENTITY_LINE3%", _consultant.IdentityLine3);
                        text = text.Replace("%IDENTITY_LINE4%", _consultant.IdentityLine4);
                        text = text.Replace("%IDENTITY_LINE5%", _consultant.IdentityLine5);

                    }
                    else
                    {

                        text = text.Replace("%SIGNATURE%", "");
                        text = text.Replace("%DOCTOR_NAME%", "");
                        text = text.Replace("%IDENTITY_LINE1%", "");
                        text = text.Replace("%IDENTITY_LINE2%", "");
                        text = text.Replace("%IDENTITY_LINE3%", "");
                        text = text.Replace("%IDENTITY_LINE4%", "");
                        text = text.Replace("%IDENTITY_LINE5%", "");
                    }
                }


                htmlEditor1.BodyHtml = text;
                htmlEditor1.Select();



                if (_reportObj.ConsultantOpinionOnStudy != null)
                {
                    SetReportContent(_reportObj.ConsultantOpinionOnStudy.ReportContent);
                    cmbSelectTemplate.Tag = _reportObj.ConsultantOpinionOnStudy.TemplateId;
                }
                
            }
          

            
        }

        private string GetAgeFromDob(DateTime? patientBirthdate)
        {

            if (patientBirthdate == null) { return ""; }
            
                DateTime _todaydate = _reportObj.OpinionDateTime;
                int Years = new DateTime(_todaydate.Subtract(patientBirthdate.GetValueOrDefault()).Ticks).Year - 1;
                DateTime PastYearDate = patientBirthdate.GetValueOrDefault().AddYears(Years);
                int Months = 0;
                for (int i = 1; i <= 12; i++)
                {
                    if (PastYearDate.AddMonths(i) == _todaydate)
                    {
                        Months = i;
                        break;
                    }
                    else if (PastYearDate.AddMonths(i) >= _todaydate)
                    {
                        Months = i - 1;
                        break;
                    }
                }
                int Days = _todaydate.Subtract(PastYearDate.AddMonths(Months)).Days;
                //int Hours = Now.Subtract(PastYearDate).Hours;
                //int Minutes = Now.Subtract(PastYearDate).Minutes;
                //int Seconds = Now.Subtract(PastYearDate).Seconds;
                return String.Format("{0}Y {1}M {2}D",
                Years, Months, Days);
            
        }

      
       

       

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();

            fd.Filter = "word files (*.docx)|*.docx|All files (*.*)|*.*";
            fd.FilterIndex = 1;
            fd.RestoreDirectory = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                Byte[] ba = WordHelper.HtmlToWord(htmlEditor1.BodyInnerHTML);


                FileStream fs = new FileStream(fd.FileName, FileMode.CreateNew);
                fs.Write(ba, 0, ba.Length);
                fs.Close();
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextSnippetForm tsf = new TextSnippetForm();
            if (tsf.ShowDialog(this) == DialogResult.OK)
            {
                htmlEditor1.InsertHTMLAtCursor(tsf.HTMLText);
            }
            tsf.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string snippetname = "";

            Utils.ShowInputDialog(ref snippetname);

            if (snippetname.Trim() == "")
            {
                  MessageBox.Show("Template name required!","Template Create",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

           string _fullBodyHtml =    htmlEditor1.BodyInnerHTML;

            HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument(); 
            htmldoc.LoadHtml(_fullBodyHtml);

            string prescription = htmldoc.GetElementbyId("Prescription").InnerHtml;

            
            int _rcId = _reportObj.ReportConsultant.RCId;
            
           

            if (_rcId == 0)
            {
                MessageBox.Show("Radiologist not found.", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            HtmlTempleForReport _template = new HtmlTempleForReport();
   
            _template.RCId = _rcId;
            _template.TemplateName = snippetname;
            _template.TemplateContent = prescription;

            if(new RISService().SaveHtmlReportTemplate(_template))
            {
                MessageBox.Show("Template created successfully!", "Template Create", MessageBoxButtons.OK, MessageBoxIcon.Information);

               LoadChildSavedTemplatesTemplates(_rcId);
            }

        }

        private async void LoadChildSavedTemplatesTemplates(int rcId)
        {
            List<HtmlTempleForReport> _htmlTemplates = await new RISAPIConsumerService().GetHtmlTemplateForReport(rcId);
            _htmlTemplates.Insert(0, new HtmlTempleForReport() { Id = 0, RCId = 0, TemplateName = "Select Template" });
            cmbSelectTemplate.DataSource = _htmlTemplates;
            cmbSelectTemplate.DisplayMember = "TemplateName";
            cmbSelectTemplate.ValueMember = "Id";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextMacroForm tmf = new TextMacroForm();
            tmf.ShowDialog(this);

            //GetTextMacrosList(ref macroListDictionary);
            htmlEditor1.MacroListDictionary = _reportObj.macroDictionary;

            tmf.Dispose();
            htmlEditor1.Select();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DoctorListForm dlf = new DoctorListForm();
            dlf.ShowDialog(this);

            //GetTextMacrosList(ref macroListDictionary);
            //htmlEditor1.MacroListDictionary = macroListDictionary;

            dlf.Dispose();
          

            htmlEditor1.Select();
        }

       


        private string GetDoctorSignatureHTML(string doctorname)
        {
            string s = "", i = "";

            dbconn.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT doctor_signature_text, doctor_signature_image FROM tblDoctor WHERE doctor_name = @doctor_name", frmHtmlReport.dbconn);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("doctor_name", doctorname);

            OleDbDataReader datareader = cmd.ExecuteReader();

            while (datareader.Read())
            {
                if (datareader.IsDBNull(0))
                {
                    s = "";
                }
                else
                {
                   s = datareader.GetString(0);
                }

                if (!(datareader.IsDBNull(1) || datareader.GetString(1).Trim() == ""))
                {
                    i = datareader.GetString(1);
                }
            }
            dbconn.Close();

            return "<img src=\"data:image/png;base64," + i + "\">" + "<br>" + s;
        }

        private void cmbSelectTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                HtmlTempleForReport _rtemplate = cmbSelectTemplate.SelectedItem as HtmlTempleForReport;
                if (_rtemplate.Id ==0) return;

                cmbSelectTemplate.Tag = _rtemplate.Id;

                htmlEditor1.InsertHTMLAtCursor(_rtemplate.TemplateContent);

                //htmlEditor1.InsertHTMLWithinTag(_rtemplate.TemplateContent,"Prescription");

            }
        }

        private async void btnReportComplete_Click(object sender, EventArgs e)
        {



            string _fullBodyHtml = htmlEditor1.BodyInnerHTML;

            HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument(); ;
            htmldoc.LoadHtml(_fullBodyHtml);

            string prescription = htmldoc.GetElementbyId("Prescription").InnerHtml;


            if (_reportObj.IsEditWillSave)
            {

                try
                {

                    int _templateId = 0;
                  

                    if (cmbSelectTemplate.Tag != null)
                    {
                       int.TryParse(cmbSelectTemplate.Tag.ToString(), out _templateId);
                    }

                    VMRISWorklistSubSetForLV wlObj = _reportObj.vmRISWorkList;

                    bool isReportCompleted = true;


                   



                    //ConsultantOpinionOnStudy _existingOpinion = new ReportService().GetReportConsultantOpinionOnStudy(xd);

                    ConsultantOpinionOnStudy _existingOpinion = await (new RISAPIConsumerService()).GetReportConsultantOpinionOnStudy(wlObj.ProcId, wlObj.ConsultantId);


                    if (_existingOpinion != null)
                    {

                        // _existingOpinion.OpDate = _OpDateTime.Date;
                        // _existingOpinion.OpTime = _OpDateTime.ToString("hh:mm tt");
                        _existingOpinion.ReportContent = prescription;
                        _existingOpinion.isReportComplete = isReportCompleted;

                        if (await (new RISAPIConsumerService()).UpdateConsultantOpinionOnStudy(_existingOpinion))
                        {

                            try
                            {
                                string processName = "RadiAntViewer.exe".Replace(".exe", "");

                                foreach (Process process in Process.GetProcessesByName(processName))
                                {
                                    process.Kill();
                                }

                              
                            }
                            catch(Exception ex)
                            {
                                //this.Dispose();
                            }

                        }
                    }
                    else
                    {
                       
                        
                        ConsultantOpinionOnStudy newReport = new ConsultantOpinionOnStudy();
                        newReport.ProcId = wlObj.ProcId;
                        newReport.RCId = wlObj.ConsultantId;
                        newReport.OpDate = _OpDateTime.Date;
                        newReport.OpTime = _OpDateTime.ToString("hh:mm tt");
                        newReport.ReportContent = prescription;
                        newReport.isReportComplete = isReportCompleted;
                        newReport.TemplateId = _templateId;

                        var result = Task.Run(async () => await new RISAPIConsumerService().SaveConsultantOpinionOnStudy(newReport)).GetAwaiter().GetResult();

                        if (result) // This method will also update the Worklist item status as complete
                        {

                            try
                            {
                                string processName = "RadiAntViewer.exe".Replace(".exe", "");

                                foreach (Process process in Process.GetProcessesByName(processName))
                                {
                                    process.Kill();
                                }



                                //this.Invoke(new MethodInvoker(delegate ()
                                //{
                                //    this.Close();
                                //}));



                            }
                            catch (Exception ex)
                            {
                               // this.Dispose();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RIS");
                }

            }
            else
            {
                //this.Dispose();
            }


            this.DialogResult = DialogResult.OK;

            //this.Dispose();

        } // End of Method

        private async void btnUpdateTemplate_Click(object sender, EventArgs e)
        {
            if (cmbSelectTemplate.Tag != null)
            {
                int _templateId = 0;
                int.TryParse(cmbSelectTemplate.Tag.ToString(), out _templateId);

                string _fullBodyHtml = htmlEditor1.BodyInnerHTML;

                HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument();
                htmldoc.LoadHtml(_fullBodyHtml);

                string prescription = htmldoc.GetElementbyId("Prescription").InnerHtml;

                VMUpdateTemplate template = new VMUpdateTemplate();
                template.TemplateId = _templateId;
                template.TemplateContent = prescription;

                if(await new RISAPIConsumerService().UpdateTemplate(template))
                {
                    MessageBox.Show("Template updated successfully.","RIS",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnWord_Click(object sender, EventArgs e)
        {

            Convert(".docx");
        }


        private async void Convert(string extension)
        {
            VMRISWorklistSubSetForLV patient = _reportObj.vmRISWorkList;

            ReportConsultant consultant = _reportObj.ReportConsultant;

            if (consultant == null && patient.Status==6)
            {
                consultant = await new RISAPIConsumerService().GetReportConsultant(patient.ConsultantId);
            }



            MemoryStream signature = new MemoryStream(consultant.ESignature);

            Dictionary<string, string> textReplacements = DocumentHelper.PatientToTemplateDictionary(patient, consultant);
            Dictionary<string, DocumentLib.Image> imageFileReplacements = DocumentHelper.SignatureToTemplateDictionary(signature);

            string outFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DateTime.Now.ToString("yyyyMMdd-hhmmss") + extension);
            string outDocxFile = ".docx".Equals(extension, StringComparison.OrdinalIgnoreCase) ? outFile : null;
            string outPdfFile = ".pdf".Equals(extension, StringComparison.OrdinalIgnoreCase) ? outFile : null;

            templateFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HtmlEditor") + @"\RIS_Master_Template.docx";

            string _fullBodyHtml = htmlEditor1.BodyInnerHTML;

            HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument();
            htmldoc.LoadHtml(_fullBodyHtml);

            htmlText = htmldoc.GetElementbyId("Prescription").InnerHtml;


            Document.ConvertFromHtmlText(AdjustHtmlText(htmlText), templateFile, textReplacements, imageFileReplacements, outDocxFile, outPdfFile);

            //if (openFile)
            //{
                if (!string.IsNullOrEmpty(outDocxFile))
                    Process.Start(outDocxFile);
                if (!string.IsNullOrEmpty(outPdfFile))
                    Process.Start(outPdfFile);
            //}

            //MessageBox.Show("Document converted successfully...");
        }


        private static string AdjustHtmlText(string text)
        {
            const string HTML_TEMPLATE = "<!DOCTYPE html><html><head><meta charset=\"UTF-8\"></head><body>{0}</body></html>";
            bool containHtmlTag = text.IndexOf("<html>", StringComparison.OrdinalIgnoreCase) > 0 && text.IndexOf("</html>", StringComparison.OrdinalIgnoreCase) > 0;
            return containHtmlTag ? text : string.Format(HTML_TEMPLATE, text);
        }


        private void StartReportFile(VMReportObj _reportObj)
        {

            //this.KillRunningProcess();

            Process p1 = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo(_reportObj.WordfilePath);

            p1.StartInfo = startInfo;

            p1.Start();


        }


        private DocX CreateReportFromTemplate(DocX template, VMRISWorklistSubSetForLV wListItem)
        {

            DateTime _serverDateTime = Utils.GetServerDateAndTime();


            template.ReplaceText("Report_Type", "DEPARTMENT OF RADIOLOGY & IMAGING");



            template.ReplaceText("Id_No", wListItem.PatientId.ToString());

            template.ReplaceText("Received_date", wListItem.OrderDateTime.ToString());
            template.ReplaceText("Report_Date", _serverDateTime.ToString());
            //template.ReplaceText("daily_id", txtDID.Text);
            template.ReplaceText("Report_Date", DateTime.Now.ToString("dd/MM/yyyy"));
            template.ReplaceText("Patient_Name", wListItem.PatientName);
            template.ReplaceText("Patient_Age", "");
            template.ReplaceText("Patient_Sex", wListItem.PatientSex);
            template.ReplaceText("Refd_By", wListItem.ReferralPhysician);


            template.AddFooters();

            ReportConsultant _doctor = _reportObj.ReportConsultant;

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

        private void btnPDF_Click(object sender, EventArgs e)
        {
            Convert(".pdf");
        }
    }
}
