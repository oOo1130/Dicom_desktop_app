using RIS.Models;
using RIS.Models.VWModels;
using RIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS.HtmlEditor
{
    public partial class frmNewTemplate : Form
    {

        VMReportConsultant _consultant;
        HtmlTempleForReport _template;
        public frmNewTemplate(VMReportConsultant consultant, HtmlTempleForReport template)
        {
            InitializeComponent();

            _consultant = consultant;
            _template = template;

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTemplateName.Text))
            {
                if (_template != null)
                {

                    _template.TemplateName = txtTemplateName.Text;
                    _template.RCId = _consultant.RCId;
                    _template.TemplateContent = HtmlEditor1.Content.GetBodyHtml(false);

                    if (await new RISAPIConsumerService().UpdateHtmlTempalate(_template))
                    {
                        MessageBox.Show("Template update successful!", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update failed!", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    HtmlTempleForReport _templateObj = new HtmlTempleForReport();
                    _templateObj.TemplateName = txtTemplateName.Text;
                    _templateObj.RCId = _consultant.RCId;
                    _templateObj.TemplateContent = HtmlEditor1.Content.GetBodyHtml(false);

                    if (await new RISAPIConsumerService().SaveNewHtmlTempalate(_templateObj))
                    {
                        MessageBox.Show("New template added successfully!", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Save failed!", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnClearContent_Click(object sender, EventArgs e)
        {
            HtmlEditor1.Content.ClearContent();
            txtTemplateName.Text = "";
        }

        private void frmNewTemplate_Load(object sender, EventArgs e)
        {
            if (_template != null)
            {
                txtTemplateName.Text = _template.TemplateName;
                HtmlEditor1.Content.SetBodyHtml(_template.TemplateContent);
            }
        }
    }
}
