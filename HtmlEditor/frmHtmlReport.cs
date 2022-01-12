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

namespace htmledit
{

    public partial class frmHtmlReport : Form
    {
        const string html_template = "template_001.html";
        

        private VMReportObj _reportObj;
        ProcessStartInfo vrProcess;

        bool unlocked = true;
        User _user;

        bool isLoaded = false;
       

        string ReportFilePath = string.Empty;
        string ReportFileNameWithPath = string.Empty;

     

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
            string dbfile;

            macroListDictionary = new Dictionary<string, string>();

            this.Text = this.Text + " (" + _reportObj.vmRISWorkList.PatientId.ToString() + ", " + _reportObj.vmRISWorkList.PatientName + ", "+ _reportObj.vmRISWorkList.ProcedureHISName + _reportObj.vmRISWorkList.HospitalName + ")";

          
            
            //dbfile = Application.StartupPath + System.IO.Path.DirectorySeparatorChar + "sampledata.mdb";
            //dbconn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbfile);
            //dataadapter = new OleDbDataAdapter("SELECT * FROM tblJob", dbconn);

            //dt = new DataTable("tblJobs");
            //dataadapter.Fill(dt);
            //dataGridView1.DataSource = dt;

            //GetDoctorsList();


            isLoaded = false;


            htmlEditor1.MacroListDictionary = _reportObj.macroDictionary;  //macroListDictionary; // If dictionary is set, then it will check each word
                                                                   // as it is typed and do text replacement 

            this.BeginInvoke((MethodInvoker)this.SetMasterTemplate);
            this.BeginInvoke((MethodInvoker)this.LoadChildTemplates);

           


            btnReportComplete.GotFocus += BtnReportComplete_GotFocus;
            btnReportComplete.LostFocus += BtnReportComplete_LostFocus;


            _OpDateTime = _reportObj.OpinionDateTime;


            isLoaded = true;


            this.htmlEditor1.FontName = new FontFamily("Calibri");
            this.htmlEditor1.FontSize = FontSize.Five;
            this.htmlEditor1.BodyInnerHTML = "<FONT size=5 face=Calibri></FONT>";


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

        private void LoadChildTemplates()
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
            string f_in = _reportObj.Html_masteremplatecontent;
            string f_out = Application.StartupPath + System.IO.Path.DirectorySeparatorChar + "output.htm";

            VMRISWorklistSubSetForLV patient = _reportObj.vmRISWorkList;
            string _age = GetAgeFromDob(patient.PatientBirthdate);
            string patient_idno = patient.PatientId;
            string receive_date = patient.ArrivalDateTime.ToString("dd/MM/yyyy hh:mm tt");
            string report_print_date = patient.ArrivalDateTime.ToString("dd/MM/yyyy hh:mm tt");
            string patient_name = patient.PatientName;
            string patient_age = _age;
            string patient_sex = patient.PatientSex;
            string refered_by = patient.ReferralPhysician;
            string report_text = ""; //dt.Rows[c]["report_text"].ToString();
            int doctor_id = patient.ConsultantId;

            string footer_text = "";

            //OleDbCommand cmd = new OleDbCommand("SELECT doctor_signature_text FROM tblDoctor WHERE rowid = " + doctor_id.ToString(), dbconn);
            //dbconn.Open();
            //OleDbDataReader datareader = cmd.ExecuteReader();
            //datareader.Read();
            //footer_text = datareader.GetString(0);
            //dbconn.Close();

            string text = f_in;
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
            string cmd_line1 = "This is a electronically signed report";
            string cmd_line2 = "This CT/X-Ray interpretation is for treatmentpurpose only &amp; should not be applicable for medico-legal purpose";
            string text1 = text.Replace(cmd_line1, "");
            text1 = text1.Replace(cmd_line2, "");
            htmlEditor1.BodyHtml = text1;
            htmlEditor1.Select();


            if (_reportObj.ConsultantOpinionOnStudy != null)
            {
                SetReportContent(_reportObj.ConsultantOpinionOnStudy.ReportContent);
            }


        }

        private string GetAgeFromDob(DateTime? patientBirthdate)
        {

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

      
       

        private void button1_Click(object sender, EventArgs e)
        {
            string f_in = _reportObj.Html_masteremplatecontent;
            string f_out = Application.StartupPath + System.IO.Path.DirectorySeparatorChar + "output.htm";

            VMRISWorklistSubSetForLV patient = _reportObj.vmRISWorkList;

            string patient_idno = patient.PatientId;
            string receive_date = patient.ArrivalDateTime.ToString();
            string report_print_date = patient.ArrivalDateTime.ToString();
            string patient_name = patient.PatientName;
            string patient_age = patient.PatientBirthdate.ToString();
            string patient_sex = patient.PatientSex;
            string refered_by = patient.ReferralPhysician;
            string report_text = ""; //dt.Rows[c]["report_text"].ToString();
            int doctor_id = patient.ConsultantId;

            string footer_text = "";

            //OleDbCommand cmd = new OleDbCommand("SELECT doctor_signature_text FROM tblDoctor WHERE rowid = " + doctor_id.ToString(), dbconn);
            //dbconn.Open();
            //OleDbDataReader datareader = cmd.ExecuteReader();
            //datareader.Read();
            //footer_text = datareader.GetString(0);
            //dbconn.Close();

            string text = f_in;
            text = text.Replace("%PATIENT_IDNO%", patient_idno);
            text = text.Replace("%RECEIVE_DATE%", receive_date);
            text = text.Replace("%REPORT_PRINT_DATE%", report_print_date);
            text = text.Replace("%PATIENT_NAME%", patient_name);
            text = text.Replace("%PATIENT_AGE%", patient_age);
            text = text.Replace("%PATIENT_SEX%", patient_sex);
            text = text.Replace("%REFERED_BY%", refered_by);
            text = text.Replace("%REPORT_TEXT%", report_text);
            text = text.Replace("%FOOTER_TEXT%", footer_text);
            //File.WriteAllText(f_out, text);

            htmlEditor1.BodyHtml = text;
            htmlEditor1.Select();
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
                //Byte[] sd = WordHelper.HTMLToPD(htmlEditor1.BodyInnerHTML);


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

            HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument(); ;
            htmldoc.LoadHtml(_fullBodyHtml);

            string prescription = htmldoc.GetElementbyId("Prescription").InnerHtml;


            HtmlTempleForReport _template = new HtmlTempleForReport();
            _template.RCId = _reportObj.ReportConsultant.RCId;
            _template.TemplateName = snippetname;
            _template.TemplateContent = prescription;

            if(new RISService().SaveHtmlReportTemplate(_template))
            {
                MessageBox.Show("Template created successfully!", "Template Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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


                htmlEditor1.InsertHTMLAtCursor(_rtemplate.TemplateContent);

                //htmlEditor1.InsertHTMLWithinTag(_rtemplate.TemplateContent,"Prescription");

            }
        }

        private async void btnReportComplete_Click(object sender, EventArgs e)
        {

            
            
            if (_reportObj.IsEditWillSave)
            {

                try
                {

                    VMRISWorklistSubSetForLV wlObj = _reportObj.vmRISWorkList;

                    bool isReportCompleted = true;


                    string _fullBodyHtml = htmlEditor1.BodyInnerHTML;

                    HtmlAgilityPack.HtmlDocument htmldoc = new HtmlAgilityPack.HtmlDocument(); ;
                    htmldoc.LoadHtml(_fullBodyHtml);

                    string prescription = htmldoc.GetElementbyId("Prescription").InnerHtml;



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

                                //this.Invoke(new MethodInvoker(delegate ()
                                //{
                                //    this.Close();
                                //}));

                                //this.Dispose();

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

       
    }
}
