using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RIS.Services;
using RIS.Models;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using RIS.Models.VWModels;

namespace HDMS.Windows.Forms.UI.Diagonstics
{
    public partial class frmAddEditRadiologist : Form
    {
        public frmAddEditRadiologist()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string t, i;
            MemoryStream ms = new MemoryStream();

            bool _isViewerWithDefaultTemplate = false;
           
            int _fSize1 = 0, _fSize2 = 0, _fSize3 = 0, _fSize4 = 0, _fSize5 = 0, _fSize6 = 0, _fSize7 = 0;

            int.TryParse(txtNameFontSize.Text, out _fSize1);
            int.TryParse(txtFontSizeforIdentity1.Text, out _fSize2);
            int.TryParse(txtFontSizeforIdentity2.Text, out _fSize3);
            int.TryParse(txtFontSizeforIdentity3.Text, out _fSize4);
            int.TryParse(txtFontSizeforIdentity4.Text, out _fSize5);
            int.TryParse(txtFontSizeforIdentity5.Text, out _fSize6);
            int.TryParse(txtFontSizeforIdentity6.Text, out _fSize7);


            if (radYes.Checked) _isViewerWithDefaultTemplate = true;


            byte[] imgbyte = null;
            if (sgnbox.Image != null)
            {
                imgbyte = GetImagebyte();
            }


            if (sgnbox.Image == null)
            {
                i = "";
            }
            else
            {
                Bitmap bitmapImage = new Bitmap(sgnbox.Image);
                bitmapImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                //sgnbox.Image.Save(ms, ImageFormat.Png);
                ms.Position = 0;
                i = Convert.ToBase64String(ms.GetBuffer());
            }



            if (txtName.Tag != null)
            {
                ReportConsultant _consultant = (ReportConsultant)txtName.Tag;


                _consultant.Name = txtName.Text;
                _consultant.Fsize1 = _fSize1;
                _consultant.IdentityLine1 = txtIdentityLine1.Text;
                _consultant.Fsize2 = _fSize2;
                _consultant.IdentityLine2 = txtIdentityLine2.Text;
                _consultant.Fsize3 = _fSize3;
                _consultant.IdentityLine3 = txtIdentityLine3.Text;
                _consultant.Fsize4 = _fSize4;
                _consultant.IdentityLine4 = txtIdentityLine4.Text;
                _consultant.Fsize5 = _fSize5;
                _consultant.IdentityLine5 = txtIdentityLine5.Text;
                _consultant.Fsize6 = _fSize6;
                _consultant.IdentityLine6 = txtIdentityLine6.Text;
                _consultant.Fsize7 = _fSize7;
                _consultant.ESignature = imgbyte;
                _consultant.SignatureBase64HtmlEmbeded = "<img src=\"data:image/png;base64," + i + "\">";
                _consultant.IsESignatureAllow = true;
                _consultant.IsViewerWithDefaultTemplate = _isViewerWithDefaultTemplate;

                _consultant.DicomImagePath = txtDicomPath.Text;
                _consultant.RadNextCloudID = txtNextCloudId.Text;

                var result = Task.Run(async () => await new RISAPIConsumerService().AddEditRadiologistAPICall(_consultant)).GetAwaiter().GetResult();

                if (result)
                {
                    MessageBox.Show("Consultant Info updated successfully.", "H-ERP");
                    Task.Run(async () => await new RISAPIConsumerService().DeleteExistingAllowedGroupsAPICall(_consultant.RCId));
                    //new RISService().DeleteExistingAllowedGroups(_consultant.RCId);
                    SaveAllowedModalities(_consultant);
                    LoadConsultants();
                }
                else
                {
                    MessageBox.Show("Sorry! Fail to update consultant.", "H-ERP");
                }

              

            }
            else
            {
                ReportConsultant _consultant = new ReportConsultant();

                _consultant.Name = txtName.Text;
                _consultant.Fsize1 = _fSize1;
                _consultant.IdentityLine1 = txtIdentityLine1.Text;
                _consultant.Fsize2 = _fSize2;
                _consultant.IdentityLine2 = txtIdentityLine2.Text;
                _consultant.Fsize3 = _fSize3;
                _consultant.IdentityLine3 = txtIdentityLine3.Text;
                _consultant.Fsize4 = _fSize4;
                _consultant.IdentityLine4 = txtIdentityLine4.Text;
                _consultant.Fsize5 = _fSize5;
                _consultant.IdentityLine5 = txtIdentityLine5.Text;
                _consultant.Fsize6 = _fSize6;
                _consultant.IdentityLine6 = txtIdentityLine6.Text;
                _consultant.Fsize7 = _fSize7;
                _consultant.ESignature = imgbyte;
                _consultant.SignatureBase64HtmlEmbeded = i;
                _consultant.IsESignatureAllow = true;
                _consultant.IsViewerWithDefaultTemplate = _isViewerWithDefaultTemplate;
                _consultant.DicomImagePath = txtDicomPath.Text;
                _consultant.RadNextCloudID = txtNextCloudId.Text;

                var result = Task.Run(async () => await new RISAPIConsumerService().AddEditRadiologistAPICall(_consultant)).GetAwaiter().GetResult();

                if (result)
                {

                    SaveAllowedModalities(_consultant);

                    MessageBox.Show("New Consultant Saved Successfully.", "RIS-EMSL");
                    LoadConsultants();
                }
                else
                {

                    MessageBox.Show("Sorry! Fail to create new consultant.", "RIS-EMSL");
                }

                
            }

        }


        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private byte[] GetImagebyte()
        {
            try
            {
                using (var ms = new MemoryStream())
                {
                    Bitmap bmp = new Bitmap(sgnbox.Image);
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        private async void LoadConsultants()
        {
            List<VMReportConsultant> _rConsultant = await new RISAPIConsumerService().GetReportConsultants();
            dgvConsultants.SuspendLayout();
            dgvConsultants.Rows.Clear();
            int Count = 1;
            foreach (var item in _rConsultant)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 25;
                row.Tag = item;
                row.CreateCells(dgvConsultants, Count, item.Name);
                dgvConsultants.Rows.Add(row);
                Count++;
            }
        }

        private void SaveAllowedModalities(ReportConsultant consultant)
        {
            List<AllowedModality> _rcMList = new List<AllowedModality>();


            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    CheckBox cb = control as CheckBox;
                    if (cb.Checked)
                    {
                        AllowedModality _modality = new AllowedModality();
                        _modality.RCId = consultant.RCId;
                        _modality.Modality = cb.Tag as string;
                        _rcMList.Add(_modality);
                    }
                }
            }

            if (_rcMList.Count > 0)
            {
                new RISService().SaveAllowedModalities(_rcMList);
            }

        }

        private void frmAddEditRadiologist_Load(object sender, EventArgs e)
        {
            LoadConsultants();
        }

        private async void dgvConsultants_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VMReportConsultant _consultantobj = dgvConsultants.SelectedRows[0].Tag as VMReportConsultant;

            ReportConsultant _consultant = await new RISAPIConsumerService().GetReportConsultant(_consultantobj.RCId);

            if (_consultant != null)
            {
                txtName.Tag = _consultant;
                txtName.Text = _consultant.Name;
                txtIdentityLine1.Text = _consultant.IdentityLine1;
                txtIdentityLine2.Text = _consultant.IdentityLine2;
                txtIdentityLine3.Text = _consultant.IdentityLine3;
                txtIdentityLine4.Text = _consultant.IdentityLine4;
                txtIdentityLine5.Text = _consultant.IdentityLine5;
                txtIdentityLine6.Text = _consultant.IdentityLine6;
                txtDicomPath.Text = _consultant.DicomImagePath;
                txtNextCloudId.Text = _consultant.RadNextCloudID;

                if (_consultant.ESignature != null)
                {
                    sgnbox.Image = byteArrayToImage(_consultant.ESignature);
                }
                else
                {
                    sgnbox.Image = null;
                }

                CheckAllowedModalities(_consultant.RCId);

            }
        }

        private void CheckAllowedModalities(int rCId)
        {
            List<AllowedModality> _modaList = new RISService().GetAllowedModalities(rCId);

            foreach (var control in this.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    CheckBox cb = control as CheckBox;
                    foreach (var item in _modaList)
                    {
                        if (item.Modality.Equals(cb.Tag.ToString()))
                        {
                            cb.Checked = true;
                        }
                    }
                }


            }
        }

        private void lnkBtnUploadSignature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.png;)|*.jpg;*.jpeg;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                sgnbox.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void btnClearSignature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sgnbox.Image = null;
        }
    }
}
