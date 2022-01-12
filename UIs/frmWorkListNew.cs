using DicomServer;
using RIS.Models;
using RIS.Models.VWModels;
using RIS.Services;
using RIS.UI;
using RIS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS.UIs
{
    public partial class frmWorkListNew : Form
    {
        bool IsInVisibleArea = false;

        public frmWorkListNew()
        {
            InitializeComponent();
        }

        private void frmWorkListNew_Load(object sender, EventArgs e)
        {
            if (MainForm.IsInternetConnected)
            {
                LoadAllStudies();

                SetRadiologistPanel(IsInVisibleArea);

                LoadRadiologists();

            }
            else
            {
                MessageBox.Show(Constants.offlineMsg, "Work List Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


        }

        private void LoadRadiologists()
        {
            List<ReportConsultant> _consultants = new RISService().GetReportConsultants();
            foreach (var item in _consultants)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Tag = item;
                
                lvi.SubItems.Add(item.Name);
             
                lvRadiologist.Items.Add(lvi);

            }
        }

        private async void LoadAllStudies()
        {

            DateTime _datefrm = Convert.ToDateTime("2021/10/01");
            DateTime _dateto = DateTime.Now;
            int _roleId = 1;
            int _tenantId = 1;
            int _consultantId = 0;
            string _status = "All";

            List<VMRISWorklist> _worklist = await new RISService().GetAlldWorklists(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status);
          
            
            foreach(var item in _worklist)
            {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Tag = item;
                    lvi.SubItems.Add(item.PatientId);
                    lvi.SubItems.Add(item.Status.ToString());
                    lvi.SubItems.Add(item.PatientName);
                    lvi.SubItems.Add(item.ProcedureHISName);
                    lvi.SubItems.Add(item.ClinicalHistory);
                    lvi.SubItems.Add(item.NoOfImages.ToString());
                    lvi.SubItems.Add(item.ArrivalDateTime.ToString("dd/MM/yyyy hh:mm tt"));
                    lvi.SubItems.Add(item.HospitalName.ToString());
                    lvi.SubItems.Add(item.Modality.ToString());
                    lvi.SubItems.Add(item.ConsultantName);
                    lvWorklist.Items.Add(lvi);
                
            }


        }

        private void lvWorklist_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                CheckBox cck = new CheckBox();
                // With...
                Text = "";
                Visible = true;
                lvWorklist.SuspendLayout();
                e.DrawBackground();
                cck.BackColor = Color.Transparent;
                cck.UseVisualStyleBackColor = true;

                cck.SetBounds(e.Bounds.X, e.Bounds.Y, cck.GetPreferredSize(new Size(e.Bounds.Width, e.Bounds.Height)).Width, cck.GetPreferredSize(new Size(e.Bounds.Width, e.Bounds.Height)).Width);
                cck.Size = new Size((cck.GetPreferredSize(new Size((e.Bounds.Width - 1), e.Bounds.Height)).Width + 1), e.Bounds.Height);
                cck.Location = new Point(3, 0);
                lvWorklist.Controls.Add(cck);
                cck.Show();
                cck.BringToFront();
                e.DrawText((TextFormatFlags.VerticalCenter | TextFormatFlags.Left));
                cck.Click += new EventHandler(CheckAllCheckboxes);
                lvWorklist.ResumeLayout(true);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void CheckAllCheckboxes(object sender, EventArgs e)
        {
            CheckBox test = sender as CheckBox;

            for (int i = 0; i < lvWorklist.Items.Count; i++)
            {
                lvWorklist.Items[i].Checked = test.Checked;
            }

            if (test.Checked)
            {
                ShowAssignedToRadiologistPanel.Enabled = true;
            }
            else
            {
                ShowAssignedToRadiologistPanel.Enabled = false;
            }
        }

        private void lvWorklist_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvWorklist_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void SetRadiologistPanel(bool isInVisibleArea)
        {
            if (isInVisibleArea)
            {
                RadiologistPanel.Location = new Point(180, 35);
            }
            else
            {
                RadiologistPanel.Location = new Point(-1000, 20);
            }
        }

        private  void lvWorklist_DoubleClick(object sender, EventArgs e)
        {
            //VMRISWorklist wlist = lvWorklist.SelectedItems[0].Tag as VMRISWorklist;

            //var _qyeryDatasets = DicomDatasetHelpers.CreateStudyQueryDicomDatasetByUID(wlist.StudyInstanceUid);

            //var resultDatabaseDatasets = await new DicomService().QueryStudyDatabaseDatasetsForUIAsync(_qyeryDatasets);

            OnPreviewStudies();

            //using (var form = new PreviewForm(resultDatabaseDatasets))
            //    form.ShowDialog();

        }

        private void OnPreviewStudies()
        {
            var selectedStudies = GetSelectedStudies();
            if (selectedStudies.Count == 0)
                return;

            using (var form = new PreviewForm(selectedStudies.Select(s => s.Item1).ToList()))
                form.ShowDialog();
        }

        private List<Tuple<VMRISWorklist, int>> GetSelectedStudies()
        {
            var selectedStudies = new List<Tuple<VMRISWorklist, int>>();

            if (lvWorklist.SelectedIndices.Count > 0)
            {
                foreach (int selectedIndice in lvWorklist.SelectedIndices)
                {
                    if (selectedIndice != -1)
                    {
                        var databaseDataset = (VMRISWorklist)lvWorklist.Items[selectedIndice].Tag;
                        if (databaseDataset != null)
                            selectedStudies.Add(
                                new Tuple<VMRISWorklist, int>(databaseDataset, selectedIndice));
                    }
                }
            }

            return selectedStudies;
        }

        private void SetRadiologistPanelVisible(object sender, EventArgs e)
        {
            SetRadiologistPanel(true);
        }

        private void lvWorklist_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(this.lvWorklist.Columns[e.Column].Tag);
                }
                catch (Exception)
                {
                }
                this.lvWorklist.Columns[e.Column].Tag = !value;
                foreach (ListViewItem item in this.lvWorklist.Items)
                    item.Checked = !value;

                this.lvWorklist.Invalidate();

                ShowAssignedToRadiologistPanel.Enabled = !value;
            }
        }

        private void btnHideRadiologistPanel_Click(object sender, EventArgs e)
        {
            SetRadiologistPanel(false);
        }

        private void previewStudiesToolStripButton_Click(object sender, EventArgs e)
        {
            OnPreviewStudies();
        }
    }
}

