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
    public partial class frmAddEditModalityProceduresMapping : Form
    {
        bool unlocked = true;

        public frmAddEditModalityProceduresMapping()
        {
            InitializeComponent();
        }

        private void frmAddEditProcedures_Load(object sender, EventArgs e)
        {
            if (MainForm.IsInternetConnected)
            {
             
                LoadProcedures();
            }
            else
            {
                MessageBox.Show(Constants.offlineMsg, "Add/Edit Procedure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            HideAllDefaultHidden();

            ctrlHospitalSearch.Location = new Point(txtHospital.Location.X, txtHospital.Location.Y);
            ctrlHospitalSearch.ItemSelected += ctrlHospitalSearch_ItemSelected;

            ctrlProcedureSearch.Location = new Point(txtHISProcedure.Location.X, txtHISProcedure.Location.Y);
            ctrlProcedureSearch.ItemSelected += ctrlProcedureSearch_ItemSelected;

        }

        private void HideAllDefaultHidden()
        {
            ctrlHospitalSearch.Visible = false;
            ctrlProcedureSearch.Visible = false;
        }

        private void ctrlProcedureSearch_ItemSelected(SearchResultListControl<HISProcedure> sender, HISProcedure item)
        {
            txtHISProcedure.Text = item.ProcName;
            txtHISProcedure.Tag = item;
            txtModalityProcedure.Focus();
            sender.Visible = false;
        }

        private void ctrlHospitalSearch_ItemSelected(SearchResultListControl<Tenant> sender, Tenant item)
        {
            txtHospital.Text = item.Name;
            txtHospital.Tag = item;
            txtHISProcedure.Focus();
            sender.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MainForm.IsInternetConnected)
            {

                if (txtHospital.Tag!=null && txtHISProcedure.Tag!=null &&  !string.IsNullOrWhiteSpace(txtModalityProcedure.Text))
                {
                    Tenant _tenant = txtHospital.Tag as Tenant;
                    HISProcedure _proc = txtHISProcedure.Tag as HISProcedure;

                        if (btnSave.Tag != null)
                        {
                            HISModalityProcedureMapping upprocObj = btnSave.Tag as HISModalityProcedureMapping;
                            if (upprocObj != null)
                            {
                                upprocObj.TenantId = _tenant.TenantId;
                                upprocObj.PId = _proc.PId;
                                upprocObj.ModalityProcDescription = txtModalityProcedure.Text;
                             
                                if (new RISService().UpdateProcedure(upprocObj))
                                {
                                    MessageBox.Show("Procedure updated successfully.");
                                    ClearFields();
                                    LoadProcedures();
                                }

                            }

                        }
                        else
                        {
                            HISModalityProcedureMapping procObj = new HISModalityProcedureMapping();
                            procObj.TenantId = _tenant.TenantId;
                            procObj.PId = _proc.PId;
                            procObj.ModalityProcDescription = txtModalityProcedure.Text;
                           
                            if (new RISService().SaveProcedure(procObj))
                            {
                                MessageBox.Show("Procedure created successfully.");
                                ClearFields();
                                LoadProcedures();
                            }
                        }
                   
                }
            }
            else
            {
                MessageBox.Show(Constants.offlineMsg, "HIS-Modality Procedure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadProcedures()
        {
            List<VMHISModalityProcedureMapping> _procList = new RISService().GetAllHISModalityProcedures();
            dgProcedures.SuspendLayout();
            dgProcedures.Rows.Clear();
            dgProcedures.Tag = _procList;
            foreach (var item in _procList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 25;
                row.Tag = item;
                row.CreateCells(dgProcedures, item.MapId,item.ModalityProcDescription, item.HISProcedureName,item.Modality);
                dgProcedures.Rows.Add(row);
            }
        }

        private void ClearFields()
        {
            unlocked = false;
            txtModalityProcedure.Text = "";
            txtHISProcedure.Text = "";
            txtHISProcedure.Tag = null;
            btnSave.Tag = null;
            unlocked = true;
        }

        private void dgProcedures_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            HISModalityProcedureMapping _Proc = dgProcedures.SelectedRows[0].Tag as HISModalityProcedureMapping;
            if (_Proc != null)
            {
                txtModalityProcedure.Text = _Proc.ModalityProcDescription;
               // txtHISProcedure.Text= _Proc.;
                btnSave.Tag = _Proc;
              

            }
        }

        private void txtHospital_TextChanged(object sender, EventArgs e)
        {
            if (unlocked)
            {
                string _txt = txtHospital.Text;
                HideAllDefaultHidden();
                ctrlHospitalSearch.Visible = true;
                ctrlHospitalSearch.txtSearch.Text = _txt;
                ctrlHospitalSearch.txtSearch.SelectionStart = ctrlHospitalSearch.txtSearch.Text.Length;

                ctrlHospitalSearch.LoadData();
            }
        }

        private void txtHISProcedure_TextChanged(object sender, EventArgs e)
        {
            if (unlocked)
            {
                string _txt = txtHISProcedure.Text;
                HideAllDefaultHidden();
                ctrlProcedureSearch.Visible = true;
                ctrlProcedureSearch.txtSearch.Text = _txt;
                ctrlProcedureSearch.txtSearch.SelectionStart = ctrlProcedureSearch.txtSearch.Text.Length;

                ctrlProcedureSearch.LoadData();
            }
        }
    }
}
