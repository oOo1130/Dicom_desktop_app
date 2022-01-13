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
using RIS.Models;
using RIS.Services;
using RIS.UI;
using RIS.Models.VWModels;

namespace htmledit
{
    public partial class TextMacroForm : Form
    {
        OleDbDataAdapter datadapter;
        DataTable dt;
        public TextMacroForm()
        {
            InitializeComponent();
        }

        private async void TextMacroForm_Load(object sender, EventArgs e)
        {
            User _user = await new RISAPIConsumerService().GetUserById(MainForm.LoggedinUser.UserId);
            
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

            GetTextMacrosList();
        }

       
        private async void GetTextMacrosList()
        {

            VMReportConsultant _consultant = cmbConsultant.SelectedItem as VMReportConsultant;

            if (_consultant.RCId == 0)
            {
                MessageBox.Show("Plz. select consultant and try again."); return;
            }


            dgShorcutKeys.Rows.Clear();
            dgShorcutKeys.SuspendLayout();

            List<ShortCutKey> _KeysList =await new RISAPIConsumerService().GetShortCutKeys(_consultant.RCId);

            foreach (var item in _KeysList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 25;
                row.Tag = item;
                row.CreateCells(dgShorcutKeys, item.textmacro, item.expandedtext);
                dgShorcutKeys.Rows.Add(row);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string n, t;

            n = txtMacro.Text;
            if (n.Trim() == "")
            {
                MessageBox.Show("Macro cannot be empty!");
                return;
            }

            t = txtExpandedText.Text;
            if (t.Trim() == "")
            {
                MessageBox.Show("Expanded text cannot be empty!");
                return;
            }

            VMReportConsultant _consultant = cmbConsultant.SelectedItem as VMReportConsultant;

            if (_consultant.RCId == 0)
            {
                MessageBox.Show("Plz. select consultant and try again."); return;
            }

            ShortCutKey _key = new ShortCutKey();
            _key.RCId = _consultant.RCId;
            _key.textmacro = n;
            _key.expandedtext = t;

            new ReportService().SaveShortCutKey(_key);

            GetTextMacrosList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string n;
            int r;

            r = dgShorcutKeys.CurrentRow.Index;
            n = dgShorcutKeys.Rows[r].Cells[0].Value.ToString();

            //OleDbCommand cmd = new OleDbCommand("DELETE * FROM tblTextMacro WHERE textmacro = @textmacro", frmHtmlReport.dbconn);
            //cmd.Prepare();
            //cmd.Parameters.AddWithValue("textmacro", n);

            //cmd.ExecuteNonQuery();
            //GetTextMacrosList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
