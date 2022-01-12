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

namespace RIS
{
    public partial class frmAddEditTenants : Form
    {
        public frmAddEditTenants()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFullName.Text))
            {

                if(radYes.Checked && dgSelectedRadioModality.Rows.Count ==0)
                {
                    MessageBox.Show("Consultant and modality required.", "Hospital", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
               
                
                if (btnSave.Tag != null)
                {
                    Tenant _tnt = btnSave.Tag as Tenant;
                    if (_tnt != null)
                    {
                        _tnt.Name = txtFullName.Text;
                        _tnt.ShortName = txtShortName.Text;
                        _tnt.Address = txtAddress.Text;
                        _tnt.MobileNo = txtMobileNo.Text;
                        _tnt.PhoneNo = txtPhoneNo.Text;
                        _tnt.Fax = txtFax.Text;
                        _tnt.Email = txtEmail.Text;
                        _tnt.ContactPerson = txtContactPerson.Text;
                        _tnt.IsActive = true;
                        _tnt.HasDefaultRadiologist = radYes.Checked;
                        if (new RISService().UpdateTenant(_tnt))
                        {
                            MessageBox.Show("Tenant updated successfully");
                            LoadTenants();
                        }

                    }

                }
                else
                {
                    Tenant tenant = new Tenant();
                    tenant.Name = txtFullName.Text;
                    tenant.ShortName = txtShortName.Text;
                    tenant.Address = txtAddress.Text;
                    tenant.MobileNo = txtMobileNo.Text;
                    tenant.PhoneNo = txtPhoneNo.Text;
                    tenant.Fax = txtFax.Text;
                    tenant.Email = txtEmail.Text;
                    tenant.ContactPerson = txtContactPerson.Text;
                    tenant.IsActive = true;
                    tenant.HasDefaultRadiologist = radYes.Checked;
                    if (new RISService().SaveTenant(tenant))
                    {
                        if (dgSelectedRadioModality.Rows.Count > 0)
                        {
                            SaveDefaultTenatRCMapping(tenant);
                        }
                        
                        
                        MessageBox.Show("Tenant created successfully");
                        LoadTenants();
                    }
                }
            }
        }

        private void SaveDefaultTenatRCMapping(Tenant tenant)
        {
            List<TenantDefaultConsultantMapping> _mapList = new List<TenantDefaultConsultantMapping>();
            foreach(var item in _tenantRcMapping)
            {
                TenantDefaultConsultantMapping obj = new TenantDefaultConsultantMapping();
                obj.TenantId = tenant.TenantId;
                obj.RCId = item.RCId;
                obj.Modality = item.Modality;
                _mapList.Add(obj);
            }

            if (_mapList.Count > 0)
            {
                new RISService().SaveDefaultTenantRcMapping(_mapList);
            }
        }

        private void LoadTenants()
        {
            List<Tenant> _tenantList = new RISService().GetAllTenants();
            dgTenants.SuspendLayout();
            dgTenants.Rows.Clear();

            foreach(var item in _tenantList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 25;
                row.Tag = item;
                row.CreateCells(dgTenants, item.TenantId, item.Name, item.Address,item.MobileNo);
                dgTenants.Rows.Add(row);
            }
        }

        List<VMTenantRadiologistMapping> _tenantRcMapping;
        private void frmAddEditTenants_Load(object sender, EventArgs e)
        {
            LoadTenants();

            _tenantRcMapping = new List<VMTenantRadiologistMapping>();

            ctrlConsultantSearch.Location = new Point(txtDefaultConsultant.Location.X, txtDefaultConsultant.Location.Y);
            ctrlConsultantSearch.ItemSelected += ConsultantSearchControl_ItemSelected;


            txtDefaultConsultant.Enabled = false;
            cmbModalities.Enabled = false;

        }

        private void ConsultantSearchControl_ItemSelected(SearchResultListControl<ReportConsultant> sender, ReportConsultant item)
        {
            txtDefaultConsultant.Text = item.Name;
            txtDefaultConsultant.Tag = item;
            cmbModalities.Focus();
            sender.Visible = false;
        }

        private void dgTenants_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Tenant _tenant = dgTenants.SelectedRows[0].Tag as Tenant;
           
            if (_tenant != null)
            {
                txtFullName.Text= _tenant.Name;
                txtShortName.Text=_tenant.ShortName;
                txtAddress.Text= _tenant.Address;
                txtMobileNo.Text = _tenant.MobileNo;
                txtPhoneNo.Text= _tenant.PhoneNo;
                txtFax.Text= _tenant.Fax;
                txtEmail.Text = _tenant.Email;
                txtContactPerson.Text=_tenant.ContactPerson;

                btnSave.Tag = _tenant;

                if (_tenant.HasDefaultRadiologist)
                {
                    radYes.Checked = true;
                    txtDefaultConsultant.Enabled = true;
                    cmbModalities.Enabled = true;

                    LoadTenantRcMapping(_tenant.TenantId);
                }
                else
                {
                    radNo.Checked = true;
                    txtDefaultConsultant.Enabled = false;
                    cmbModalities.Enabled = false;
                }
                

            }
        }

        private void LoadTenantRcMapping(int tenantId)
        {
            _tenantRcMapping = new RISService().GetTenantRCMappingList(tenantId);
            FillTenantRCMappingGrid(_tenantRcMapping);
        }

        private void txtDefaultConsultant_TextChanged(object sender, EventArgs e)
        {
            string _txt = txtDefaultConsultant.Text;
            HideAllDefaultHidden();
            ctrlConsultantSearch.Visible = true;
            ctrlConsultantSearch.txtSearch.Text = _txt;
            ctrlConsultantSearch.txtSearch.SelectionStart = ctrlConsultantSearch.txtSearch.Text.Length;

            ctrlConsultantSearch.LoadData();
        }

        private void HideAllDefaultHidden()
        {
            ctrlConsultantSearch.Visible = false;
        }

        private void ctrlConsultantSearch_SearchEsacaped(bool IsEscaped)
        {
            if (IsEscaped)
            {
                txtDefaultConsultant.Focus();
            }
        }


        
        private void btnAddToList_Click(object sender, EventArgs e)
        {
             if((txtDefaultConsultant.Tag!=null) && !string.IsNullOrEmpty(cmbModalities.Text))
            {

                ReportConsultant _consultant = txtDefaultConsultant.Tag as ReportConsultant;


                VMTenantRadiologistMapping Obj = new VMTenantRadiologistMapping();

                Obj.RCId = _consultant.RCId;
                Obj.ConsultantName = _consultant.Name;
                Obj.Modality = cmbModalities.Text;
                _tenantRcMapping.Add(Obj);


                FillTenantRCMappingGrid(_tenantRcMapping);

            }
            else
            {
                MessageBox.Show("Both consultant and modality required.", "Hospital",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillTenantRCMappingGrid(List<VMTenantRadiologistMapping> tenantRcMapping)
        {
            dgSelectedRadioModality.SuspendLayout();
            dgSelectedRadioModality.Rows.Clear();
            int count = 0;
            foreach(var item in tenantRcMapping)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 25;
                row.Tag = item;
                count++;
                row.CreateCells(dgSelectedRadioModality, count, item.ConsultantName, item.Modality);
                dgSelectedRadioModality.Rows.Add(row);
            }
        }

        private void radYes_Click(object sender, EventArgs e)
        {
            SetDefaultMapping();
        }

        private void SetDefaultMapping()
        {
            if (radYes.Checked)
            {
                txtDefaultConsultant.Enabled = true;
                cmbModalities.Enabled = true;
            }
            else
            {
                txtDefaultConsultant.Enabled = false;
                cmbModalities.Enabled = false;

                txtDefaultConsultant.Tag = null;
                txtDefaultConsultant.Text = "";
                cmbModalities.Text = "";
            }
        }

        private void radNo_Click(object sender, EventArgs e)
        {
            SetDefaultMapping();
        }

        private void dgSelectedRadioModality_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            VMTenantRadiologistMapping _SelectedItem = (VMTenantRadiologistMapping)e.Row.Tag;
            if (_SelectedItem.TenantId>0)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this record","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    new RISService().DeleteTenantRcMapping(_SelectedItem.Id);
                }

            }
            
            _tenantRcMapping.Remove(e.Row.Tag as VMTenantRadiologistMapping);
              

            
        }
    }
}
