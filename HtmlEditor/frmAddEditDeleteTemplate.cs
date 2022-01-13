using BrightIdeasSoftware;
using RIS.Models;
using RIS.Models.VWModels;
using RIS.Services;
using RIS.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS.HtmlEditor
{
    public partial class frmAddEditDeleteTemplate : Form
    {

        User _user;
        public frmAddEditDeleteTemplate()
        {
            InitializeComponent();
        }

        private async void frmAddEditDeleteTemplate_Load(object sender, EventArgs e)
        {
           _user = await new RISAPIConsumerService().GetUserById(MainForm.LoggedinUser.UserId);

            LoadConsultants(_user.RCId);
        }

        private async void LoadConsultants(int rcId)
        {
            List<VMReportConsultant> _consultant = await new RISAPIConsumerService().GetReportConsultants();
            _consultant.Insert(0, new VMReportConsultant() { RCId = 0, Name = "Select Consultant" });

            cmbConsultant.DataSource = _consultant;
            cmbConsultant.DisplayMember = "Name";
            cmbConsultant.ValueMember = "RCId";

            if (rcId > 0)
            {
                cmbConsultant.SelectedItem = _consultant.Find(x => x.RCId == rcId);
                cmbConsultant.Enabled = false;
            }

            GetHtmlTemplates(rcId);
        }

        private async void GetHtmlTemplates(int rcId)
        {
            List<HtmlTempleForReport> _templistList = await new RISAPIConsumerService().GetHtmlTemplateForReport(rcId);
            lvTemplates.SetObjects(_templistList);
        }

        private void txtTemplate_TextChanged(object sender, EventArgs e)
        {
            this.TimedFilter(this.lvTemplates, txtTemplate.Text);
        }

        void TimedFilter(ObjectListView olv, string txt)
        {
            this.TimedFilter(olv, txt, 0);
        }

        void TimedFilter(ObjectListView olv, string txt, int matchKind)
        {
            TextMatchFilter filter = null;
            if (!String.IsNullOrEmpty(txt))
            {
                switch (matchKind)
                {
                    case 0:
                    default:
                        filter = TextMatchFilter.Contains(olv, txt);
                        break;
                    case 1:
                        filter = TextMatchFilter.Prefix(olv, txt);
                        break;
                    case 2:
                        filter = TextMatchFilter.Regex(olv, txt);
                        break;
                }
            }
            // Setup a default renderer to draw the filter matches
            if (filter == null)
                olv.DefaultRenderer = null;
            else
            {
                olv.DefaultRenderer = new HighlightTextRenderer(filter);

                // Uncomment this line to see how the GDI+ rendering looks
                //olv.DefaultRenderer = new HighlightTextRenderer { Filter = filter, UseGdiTextRendering = false };
            }

            // Some lists have renderers already installed
            HighlightTextRenderer highlightingRenderer = olv.GetColumn(0).Renderer as HighlightTextRenderer;
            if (highlightingRenderer != null)
                highlightingRenderer.Filter = filter;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            olv.AdditionalFilter = filter;
            //olv.Invalidate();
            stopWatch.Stop();

           
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            VMReportConsultant selectedConsultant = cmbConsultant.SelectedItem as VMReportConsultant;
            if (selectedConsultant != null)
            {

                HtmlTempleForReport rptObj = null;

                using (var form = new frmNewTemplate(selectedConsultant, rptObj))
                {
                    form.Owner = this;
                    DialogResult result = form.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        //form.Dispose();
                        LoadConsultants(_user.RCId);
                    }
                }

            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            HtmlTempleForReport _template = lvTemplates.Items[lvTemplates.CheckedIndices[0]].Tag as HtmlTempleForReport;
            if (_template != null)
            {
                if(await new RISAPIConsumerService().DeleteHtmlTemplate(_template))
                {
                    MessageBox.Show("Template delete successful!", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a template and try again!","RIS",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvTemplates_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach (ListViewItem item in lvTemplates.Items)
            {
               if (item.Index != e.Index) item.Checked = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HtmlTempleForReport _template = lvTemplates.Items[lvTemplates.CheckedIndices[0]].Tag as HtmlTempleForReport;
            if (_template != null)
            {
                VMReportConsultant selectedConsultant = cmbConsultant.SelectedItem as VMReportConsultant;

                using (var form = new frmNewTemplate(selectedConsultant, _template))
                {
                    form.Owner = this;
                    DialogResult result = form.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        //form.Dispose();
                        LoadConsultants(_user.RCId);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a template and try again!", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
