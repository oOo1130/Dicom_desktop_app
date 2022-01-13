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


namespace htmledit
{
    public partial class TextSnippetForm : Form
    {

        public TextSnippetForm()
        {
            InitializeComponent();
        }

        public string HTMLText
        {
            get { return htmlEditorForTemplate.BodyInnerHTML; }
        }
        private void TextSnippetForm_Load(object sender, EventArgs e)
        {
            GetTextSnippetsList();
        }

        private void GetTextSnippetsList()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT snippetname FROM tblTextSnippet", frmHtmlReport.dbconn);
            frmHtmlReport.dbconn.Open();
            OleDbDataReader datareader = cmd.ExecuteReader();

            cmbSnippet.Items.Clear();
            while (datareader.Read())
            {
                cmbSnippet.Items.Add(datareader.GetString(0));
            }

            frmHtmlReport.dbconn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string n;

            n = cmbSnippet.Text;
            if (n.IsNullOrEmpty())
            {
                return;
            }

            OleDbCommand cmd = new OleDbCommand("DELETE * FROM tblTextSnippet WHERE snippetname = @snippetname", frmHtmlReport.dbconn);
            frmHtmlReport.dbconn.Open();

            cmd.Prepare();
            cmd.Parameters.AddWithValue("snippetname", n);

            cmd.ExecuteNonQuery();
            frmHtmlReport.dbconn.Close();
            GetTextSnippetsList();

            MessageBox.Show("Snippet deleted.");
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
            string n;

            n = cmbSnippet.Text;
            if (n.IsNullOrEmpty())
            {
                MessageBox.Show("Snippet name cannot be empty!");
                return;
            }

            OleDbCommand cmd = new OleDbCommand("INSERT INTO tblTextSnippet(snippetname, snippettext) VALUES (@snippetname, @snippettext)", frmHtmlReport.dbconn);
            frmHtmlReport.dbconn.Open();

            cmd.Prepare();
            cmd.Parameters.AddWithValue("snippetname", n);
            cmd.Parameters.AddWithValue("snippettext", htmlEditorForTemplate.BodyInnerHTML);
            cmd.ExecuteNonQuery();
            frmHtmlReport.dbconn.Close();
            GetTextSnippetsList();

            MessageBox.Show("Snippet saved.");
        }

        private void cmbSnippet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n;

            n = cmbSnippet.Text;
            if (n.IsNullOrEmpty())
            {
                return;
            }

            OleDbCommand cmd = new OleDbCommand("SELECT snippettext FROM tblTextSnippet WHERE snippetname = @snippetname", frmHtmlReport.dbconn);
            frmHtmlReport.dbconn.Open();

            cmd.Prepare();
            cmd.Parameters.AddWithValue("snippetname", n);

            OleDbDataReader datareader = cmd.ExecuteReader();

            if (datareader.Read())
            {
                htmlEditorForTemplate.BodyInnerHTML = datareader.GetString(0);
            }

            frmHtmlReport.dbconn.Close();
        }

        public void AddSnippet(string SnippetName, string SnippetHTML)
        {
            cmbSnippet.Text = SnippetName;
            htmlEditorForTemplate.BodyInnerHTML = SnippetHTML;
        }


    }
}
