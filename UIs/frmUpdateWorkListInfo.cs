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

namespace RIS.UIs
{
    public partial class frmUpdateWorkListInfo : Form
    {
        private VMRISWorklistSubSetForLV _workListItem;
        bool unlocked = true;
        private string _calledFrom = string.Empty; 

        public frmUpdateWorkListInfo(VMRISWorklistSubSetForLV workList, string calledFrom)
        {
            
            InitializeComponent();

            _workListItem = workList;

            _calledFrom = calledFrom;

            DisplayCurrentValues(_workListItem);
        }

        private async void DisplayCurrentValues(VMRISWorklistSubSetForLV workListItem)
        {
            unlocked = false;

            RISWorkList wlObj = await new RISAPIConsumerService().GetWorkList(workListItem.ProcId);
            if (wlObj != null)
            {
                btnUpdate.Tag = wlObj;

                lblHISProcedure.Text = workListItem.ProcedureName;
                txtProcedure.Text = workListItem.ProcedureHISName;
                txtClinicalHistory.Text = workListItem.ClinicalHistory;
                txtReferralPhysician.Text = workListItem.ReferralPhysician;
                cmbStatus.Text = workListItem.Status.ToString();

                if (_calledFrom.Equals("report"))
                {
                    txtProcedure.Enabled=false;
                    txtClinicalHistory.Enabled = false;
                    txtReferralPhysician.Enabled = false;
                }


            }


            unlocked = true;
        }

        private void frmUpdateWorkListInfo_Load(object sender, EventArgs e)
        {
            HideAllDefaultHidden();

            LoadStatuses(_workListItem.Status);

            ctrlProcedureSearch.Location = new Point(txtProcedure.Location.X, txtProcedure.Location.Y);
            ctrlProcedureSearch.ItemSelected += ctrlProcedureSearch_ItemSelected;
        }

        private void ctrlProcedureSearch_ItemSelected(SearchResultListControl<HISProcedure> sender, HISProcedure item)
        {
            txtProcedure.Text = item.ProcName;
            txtProcedure.Tag = item;
            txtClinicalHistory.Focus();
            sender.Visible = false;
        }

        private void LoadStatuses(int status)
        {
            List<ProcedureStatus> _procStatus = new RISService().GetAllStatuses();
           
            cmbStatus.DataSource = _procStatus;
            cmbStatus.DisplayMember = "Status";
            cmbStatus.ValueMember = "Id";

            if (status > 0)
            {
                cmbStatus.SelectedItem = _procStatus.Find(q => q.Id == status);
            }
        }

        private void CtrlProcedureSearch_ItemSelected(SearchResultListControl<HISModalityProcedureMapping> sender, HISModalityProcedureMapping item)
        {
           // txtProcedure.Text = item.HISProcDescription;
            txtProcedure.Tag = item;
            sender.Visible = false;
        }

        private void Procedure_Click(object sender, EventArgs e)
        {

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Tag != null)
            {
                if (!string.IsNullOrWhiteSpace(cmbStatus.Text))
                {

                    RISWorkList wlObj = btnUpdate.Tag as RISWorkList;

                    string _procedure = _workListItem.ProcedureHISName;
                    if (txtProcedure.Tag != null)
                    {
                        HISProcedure _hisproc = txtProcedure.Tag as HISProcedure;
                        if (_hisproc != null)
                        {
                            HISModalityProcedureMapping procMapObj = new RISService().GetHISModaliProcedureMapObj(wlObj.TenantId, _hisproc.PId);

                            if (procMapObj != null)
                            {
                                if (string.IsNullOrEmpty(wlObj.ProcedureName))
                                {
                                    _procedure = _hisproc.ProcName;
                                }
                                else
                                {

                                    if (procMapObj.ModalityProcDescription.ToUpper().Equals("NA"))
                                    {
                                        MessageBox.Show("Procedure will not be updated. Please change the narration 'NA' for procedure modality description and try again.", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }
                                    else
                                    {
                                        _procedure = procMapObj.ModalityProcDescription;
                                    }
                                }
                            }
                        }
                    }

                    ProcedureStatus procStatus = cmbStatus.SelectedItem as ProcedureStatus;


                    wlObj.ProcedureName = _procedure;
                    wlObj.ClinicalHistory = txtClinicalHistory.Text;
                    wlObj.ReferralPhysician = txtReferralPhysician.Text;
                    wlObj.Status = procStatus.Id; //cmbStatus.Text;

                    if(await new RISAPIConsumerService().UpdateWorklist(wlObj))
                    {
                        MessageBox.Show("Work list updated successfully!", "Work List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                }


            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void frmUpdateWorkListInfo_FormClosing(object sender, FormClosingEventArgs e)
        {

          
        }

        private void ctrlProcedureSearch_SearchEsacaped(bool IsEscaped)
        {
            if (IsEscaped)
            {
                txtProcedure.Focus();
            }
        }

        private void txtProcedure_TextChanged(object sender, EventArgs e)
        {
           
                if (unlocked)
                {
                    string _txt = txtProcedure.Text;
                    HideAllDefaultHidden();

                    ctrlProcedureSearch.Visible = true;
                    ctrlProcedureSearch.txtSearch.Text = _txt;
                    ctrlProcedureSearch.txtSearch.SelectionStart = ctrlProcedureSearch.txtSearch.Text.Length;
                    ctrlProcedureSearch.LoadData();
                
            }
            
        }

        private void HideAllDefaultHidden()
        {
            ctrlProcedureSearch.Visible = false;
        }

        private void frmUpdateWorkListInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
           

            //for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            //{
            //    if (Application.OpenForms[index].Name == "frmWorkListV2")
            //    {
            //        Application.OpenForms[index].Close();
            //    }
            //}


            //using (var form = new frmWorkListV2())
            //{
            //    form.WindowState = FormWindowState.Maximized;
            //    form.ShowDialog();
            //}
        }
    }
}
