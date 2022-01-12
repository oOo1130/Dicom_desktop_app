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
using System.Drawing.Imaging;

namespace htmledit
{
    public partial class DoctorListForm : Form
    {
        OleDbDataAdapter datadapter;
        DataTable dt;

        public DoctorListForm()
        {
            InitializeComponent();
        }

        private void DoctorListForm_Load(object sender, EventArgs e)
        {
            htmledPreview.ReadOnly = true;

            frmHtmlReport.dbconn.Open();
            GetDoctorsList();
        }
        private void DoctorListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmHtmlReport.dbconn.Close();
        }
        private void GetDoctorsList()
        {
            datadapter = new OleDbDataAdapter("SELECT rowid, doctor_name FROM tblDoctor", frmHtmlReport.dbconn);
            dt = new DataTable("tblDoctor");
            datadapter.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Doctor Name";
            dataGridView1.Columns[1].Width = dataGridView1.Width - 50;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r, n;

            r = dataGridView1.CurrentRow.Index;
            n = Convert.ToInt32(dataGridView1.Rows[r].Cells[0].Value);

            htmledPreview.BodyHtml = "";
            GetDoctorDetails(n);
            DoSignaturePreview();
        }

        private void GetDoctorDetails(int DoctorID)
        {
            string i;

            OleDbCommand cmd = new OleDbCommand("SELECT doctor_signature_text, doctor_signature_image FROM tblDoctor WHERE rowid = @rowid", frmHtmlReport.dbconn);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("rowid", DoctorID);

            OleDbDataReader datareader = cmd.ExecuteReader();

            pbSignature.ImageLocation = "";
            htmledSignature.ResetText();
            while (datareader.Read())
            {
                if (datareader.IsDBNull(0))
                {
                    htmledSignature.BodyInnerHTML = "";
                }
                else
                {
                    htmledSignature.BodyInnerHTML = datareader.GetString(0);
                }

                if (datareader.IsDBNull(1) || datareader.GetString(1).Trim() == "")
                {
                    pbSignature.Image = null;
                }
                else
                {
                    i = datareader.GetString(1);
                    pbSignature.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(i)));
                }
            }
        }

        private void DoSignaturePreview()
        {
            MemoryStream ms = new MemoryStream();
            string i;
            string sigtext = "", imgtag = "";

            if (pbSignature.Image != null)
            {
                pbSignature.Image.Save(ms, ImageFormat.Png);
                i = Convert.ToBase64String(ms.GetBuffer());
                imgtag = "<img src=\"data:image/png;base64," + i + "\">";
            }

            if (htmledSignature.BodyInnerHTML != null)
            {
                sigtext = htmledSignature.BodyInnerHTML;
            }

            htmledPreview.BodyHtml = imgtag + "<br>" + sigtext;
        }

        private void htmledSignature_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string n;

            n = txtDoctorName.Text;
            if (n.Trim() == "")
            {
                MessageBox.Show("Doctor name cannot be empty!");
                return;
            }

            OleDbCommand cmd = new OleDbCommand("INSERT INTO tblDoctor(doctor_name) VALUES (@doctor_name)", frmHtmlReport.dbconn);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("doctor_name", n);
            cmd.ExecuteNonQuery();
            GetDoctorsList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string n;
            int r;

            r = dataGridView1.CurrentRow.Index;
            n = dataGridView1.Rows[r].Cells[0].Value.ToString();

            OleDbCommand cmd = new OleDbCommand("DELETE * FROM tblDoctor WHERE rowid = @rowid", frmHtmlReport.dbconn);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("rowid", n);

            cmd.ExecuteNonQuery();
            GetDoctorsList();
        }

        private void lblUploadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSignature.ImageLocation = openFileDialog1.FileName;
                DoSignaturePreview();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }
        private void Save()
        {
            int r, n;
            string t, i;
            MemoryStream ms = new MemoryStream();

            r = dataGridView1.CurrentRow.Index;
            n = Convert.ToInt32(dataGridView1.Rows[r].Cells[0].Value);

            t = htmledSignature.BodyInnerHTML;

            if(t == null || t.Trim() == "")
            {
                MessageBox.Show("Signature text cannot be empty.");
                return;
            }

            if (pbSignature.Image == null)
            {
                i = "";
            }
            else
            {
                pbSignature.Image.Save(ms, ImageFormat.Png);
                ms.Position = 0;
                i = Convert.ToBase64String(ms.GetBuffer());
            }

            OleDbCommand cmd = new OleDbCommand("UPDATE tblDoctor SET doctor_signature_text = @doctor_signature_text, doctor_signature_image = @doctor_signature_image WHERE rowid = @rowid", frmHtmlReport.dbconn);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("doctor_signature_text", t);
            cmd.Parameters.AddWithValue("doctor_signature_image", i);
            cmd.Parameters.AddWithValue("rowid", n);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Doctor details saved.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblPreview_Click(object sender, EventArgs e)
        {
            DoSignaturePreview();
        }
    }
}
