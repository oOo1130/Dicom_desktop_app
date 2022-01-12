using RIS.Models;
using RIS.Models.VWModels;
using RIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS.UIs
{
    public partial class frmMapRadProcedureAndTemplate : Form
    {
        bool unlocked = true;
        bool isLoaded = false;

        public frmMapRadProcedureAndTemplate()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Docx Files";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Word Files|*.doc;*.docx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool IsDefaultTemplate = false;
            int templateId = 0;
            ReportConsultant doc = (ReportConsultant)cmbConsultant.SelectedItem;
            HISProcedure proc = txtProcedure.Tag as HISProcedure;

            if (doc.RCId == 0)
            {
                MessageBox.Show("Plz. select radiologist and try again.", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            
            if (proc == null)
            {
                MessageBox.Show("Plz. select procedure and try again.","RIS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (BinaryReader b = new BinaryReader(File.Open(txtFileName.Text, FileMode.Open)))
                {
                    int length = (int)b.BaseStream.Length;
                    byte[] File1Content = new byte[length];
                    b.Read(File1Content, 0, length);

                    string[] fileName = new string[2];
                    fileName = Path.GetFileName(txtFileName.Text).Split('.');

                    if (radYes.Checked) IsDefaultTemplate = true;


                    ProcedureRadiologistTemplate _templatemap = new ProcedureRadiologistTemplate();

                    _templatemap.PId = proc.PId;
                    _templatemap.RCId = doc.RCId;
                    _templatemap.FileName = fileName[0];
                    _templatemap.TemplateName = txtTemplateName.Text;
                    _templatemap.TemplateContent = File1Content;
                    _templatemap.IsDefaultTemplate = IsDefaultTemplate;

                    if ((txtTemplateName.Tag != null) && (Int32.TryParse(txtTemplateName.Tag.ToString(), out templateId)))
                    {
                        //if (new TemplateService().UpdateTemplate(_template, templateId))
                        //{
                        //    MessageBox.Show("Template Updated.", "HERP");
                        //}
                    }
                    else
                    {
                        if (new RISService().CreateTemplate(_templatemap))
                        {
                            MessageBox.Show("Template Saved.", "RIS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            
                        }
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HERP");
            }

            //this.LoadData();

        }

        private void frmMapRadProcedureAndTemplate_Load(object sender, EventArgs e)
        {
            isLoaded = false;

            LoadConsultants(0);

            ctrlHISProcedureSearch.Location = new Point(txtProcedure.Location.X, txtProcedure.Location.Y);
            ctrlHISProcedureSearch.ItemSelected += ctrlHISProcedureSearch_ItemSelected;

            isLoaded = true;
        }

        private void ctrlHISProcedureSearch_ItemSelected(SearchResultListControl<HISProcedure> sender, HISProcedure item)
        {
            txtProcedure.Text = item.ProcName;
            txtProcedure.Tag = item;
            txtTemplateName.Focus();
            sender.Visible = false;
        }

        private void LoadConsultants(int rcId)
        {
            List<ReportConsultant> _consultant = new RISService().GetReportConsultants();
            _consultant.Insert(0, new ReportConsultant() { RCId = 0, Name = "Select Consultant" });

            cmbConsultant.DataSource = _consultant;
            cmbConsultant.DisplayMember = "Name";
            cmbConsultant.ValueMember = "RCId";

            if (rcId > 0)
            {
                cmbConsultant.SelectedItem = _consultant.Find(x => x.RCId == rcId);
            }
        }

        private void txtProcedure_TextChanged(object sender, EventArgs e)
        {
            if (unlocked)
            {
                string _txt = txtProcedure.Text;
                HideAllDefaultHidden();
                ctrlHISProcedureSearch.Visible = true;
                ctrlHISProcedureSearch.txtSearch.Text = _txt;
                ctrlHISProcedureSearch.txtSearch.SelectionStart = ctrlHISProcedureSearch.txtSearch.Text.Length;

                ctrlHISProcedureSearch.LoadData();

            }
        }

        private void HideAllDefaultHidden()
        {
            ctrlHISProcedureSearch.Visible = false;
        }

        private void cmbConsultant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                ReportConsultant _rc = cmbConsultant.SelectedItem as ReportConsultant;


                List<VMRadProcTemplate> _templateList = new ReportService().GetTemplates(_rc.RCId);

                this.lvTemplates.SetObjects(_templateList);
            }
        }

        private void ctrlHISProcedureSearch_SearchEsacaped(bool IsEscaped)
        {
            if (IsEscaped)
            {
                txtProcedure.Focus();
            }
        }
    }
}
