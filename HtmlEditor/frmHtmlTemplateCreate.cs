using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

namespace htmledit
{

    public partial class frmHtmlTemplateCreate : Form
    {
        const string html_template = "template_001.htm";
        
        bool unlocked = true;
        User _user;

        bool isLoaded = false;
       

        public delegate void _InvokeMethodForChildTemplateLoad(int rcId);


        ReportConsultant _doctor = null;

        DateTime _OpDateTime;

        
        IDictionary<string, string> macroListDictionary;

        public frmHtmlTemplateCreate()
        {
            InitializeComponent();

         
        }

       
        private  void MainForm_Load(object sender, EventArgs e)
        {
          

            macroListDictionary = new Dictionary<string, string>();

           

                this.Text = "";


               

            isLoaded = false;


          

            this.BeginInvoke((MethodInvoker)this.SetMasterTemplate);
            this.BeginInvoke((MethodInvoker)this.LoadChildTemplates); 

            

            isLoaded = true;


            this.htmlEditor1.FontName = new FontFamily("Calibri");
            this.htmlEditor1.FontSize = FontSize.Five;
            this.htmlEditor1.BodyInnerHTML = "<FONT size=5 face=Calibri></FONT>";
          


        }

        private void SetReportContent(string reportContent)
        {
            htmlEditor1.InsertHTMLWithinTag(reportContent, "Prescription");
        }

        

        private async void LoadChildTemplates()
        {

           
                User _loggedInUser = await new RISAPIConsumerService().GetUserById(MainForm.LoggedinUser.UserId);

                btnCreateTemplate.Tag = _loggedInUser;

                if (_loggedInUser.RCId > 0)
                {
                    List<HtmlTempleForReport> _templistList = await new RISAPIConsumerService().GetHtmlTemplateForReport(_loggedInUser.RCId);

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
            
            MasterTemplate _template  = await new RISAPIConsumerService().GetWordMasterTemplateContent();
            f_in = _template.HtmlContent;
            

            //string f_out = Application.StartupPath + System.IO.Path.DirectorySeparatorChar + "output.htm";

            string report_text = ""; //dt.Rows[c]["report_text"].ToString();

            
                text = f_in;
                text = text.Replace("%PATIENT_IDNO%","");
                text = text.Replace("%RECEIVE_DATE%", "");
                text = text.Replace("%REPORT_PRINT_DATE%", "");
                text = text.Replace("%PATIENT_NAME%", "");
                text = text.Replace("%PATIENT_AGE%", "");
                text = text.Replace("%PATIENT_SEX%", "");
                text = text.Replace("%REFERED_BY%", "");
                text = text.Replace("%REPORT_TEXT%", report_text);
                text = text.Replace("%FOOTER_TEXT%", "");


                if (btnCreateTemplate.Tag != null)
                {

                    User _user = btnCreateTemplate.Tag as User;

                    if (_user.RCId > 0)
                    {
                        ReportConsultant _consultant = await new RISAPIConsumerService().GetReportConsultant(_user.RCId);

                        text = text.Replace("%SIGNATURE%", _consultant.SignatureBase64HtmlEmbeded);

                        text = text.Replace("%DOCTOR_NAME%", _consultant.Name);
                        text = text.Replace("%IDENTITY_LINE1%", _consultant.IdentityLine1);
                        text = text.Replace("%IDENTITY_LINE2%", _consultant.IdentityLine2);
                        text = text.Replace("%IDENTITY_LINE3%", _consultant.IdentityLine3);
                        text = text.Replace("%IDENTITY_LINE4%", _consultant.IdentityLine4);
                        text = text.Replace("%IDENTITY_LINE5%", _consultant.IdentityLine5);
                    }
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

            int _rcId = 0;
           
           
                if (btnCreateTemplate.Tag != null)
                {
                    User _user = btnCreateTemplate.Tag as User;
                    _rcId = _user.RCId;
                }
            

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

                LoadChildTemplates();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextMacroForm tmf = new TextMacroForm();
            tmf.ShowDialog(this);

            //GetTextMacrosList(ref macroListDictionary);
            htmlEditor1.MacroListDictionary = null;

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
    }
}
