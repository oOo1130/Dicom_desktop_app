using RIS.Models;
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

namespace HDMS.Windows.Forms.UI
{
    public partial class frmAddMasterTemplate : Form
    {
        public frmAddMasterTemplate()
        {
            InitializeComponent();
        }

        private void btnBrowseMasterTemplate_Click(object sender, EventArgs e)
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
                txtTemplate.Text = openFileDialog1.FileName;

            }
        }

        private void btnSaveMasterTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                using (BinaryReader b = new BinaryReader(File.Open(txtTemplate.Text, FileMode.Open)))
                {
                    int length = (int)b.BaseStream.Length;
                    byte[] File1Content = new byte[length];
                    b.Read(File1Content, 0, length);

                    MasterTemplate _template = new MasterTemplate();
                    _template.Description = txtDescription.Text;
                    _template.TemplateContent = File1Content;

                    if (new ReportService().IsMatchedSecurityCode(txtSecurityCode.Text))
                    {
                        if (new ReportService().SaveMasterTemplate(_template))
                        {
                            MessageBox.Show("Master template updated.", "RIS");
                        }
                    }
                    else
                    {
                            MessageBox.Show("Security code did not match.", "RIS");
                    }
                   

                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message, "RIS");
            }
        }

        private void FrmAddMasterTemplate_Load(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (BinaryReader b = new BinaryReader(File.Open(txtTemplate.Text, FileMode.Open)))
                {
                    int length = (int)b.BaseStream.Length;
                    byte[] File1Content = new byte[length];
                    b.Read(File1Content, 0, length);

                    MasterTemplate _template = new ReportService().GetWordMasterTemplate();
                  
                    _template.Description = txtDescription.Text;
                    _template.TemplateContent = File1Content;

                    if (new ReportService().IsMatchedSecurityCode(txtSecurityCode.Text))
                    {
                        if (new ReportService().UpdateMasterTemplate(_template))
                        {
                            MessageBox.Show("Master template updated.", "RIS");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Security code did not match.", "RIS");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RIS");
            }
        }
    }
}
