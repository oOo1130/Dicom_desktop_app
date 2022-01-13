using RIS.Models;
using RIS.Models.VWModels;
using RIS.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RIS.Repositories
{
    public partial class frmCreateUser : Form
    {
        bool isLoaded = false;
        bool unlocked = true;
        public frmCreateUser()
        {
            InitializeComponent();
            UpdateFont();
        }

        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dgUsers.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Segoe UI", 14.5F, GraphicsUnit.Pixel);

            }

            dgUsers.Font = new Font("Segoe UI", 14.5F, GraphicsUnit.Pixel);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            bool _IsAssignToRadAllow = false;
            bool _IsViewDownloadAllow = false;
            bool _IsReportWriteEditAllow = false;
            bool _IsAccessToMainViewer = false;
           
            int _roleId = Convert.ToInt32(cmbRole.SelectedValue);
            int _consultantId = Convert.ToInt32(cmbConsultant.SelectedValue);

            int _tenantId = 0;
            if (txtSelectHospital.Tag != null)
            {
                Tenant _tenant = txtSelectHospital.Tag as Tenant;
                if (_tenant != null) _tenantId = _tenant.TenantId;
            }

            string[] _arr= new string[] { };


            if (txtUserName.Tag == null)
            {
                if (!string.IsNullOrWhiteSpace(txtPassword.Text) && txtUserName.Tag == null && String.Compare(txtPassword.Text, txtConfirmPassword.Text) == 0)
                {
                    _arr = HashGenerator.GetPasswordHashAndSalt(txtPassword.Text);
                }
                else
                {
                    MessageBox.Show("Password and confirm password did not match.", "RIS"); return;
                }
            }

            if (_roleId == 3)
            {

                if (_consultantId == 0)
                {
                    MessageBox.Show("Please select consultant for this user name ", "RIS");
                    return;
                }

                if (txtUserName.Tag == null)
                {
                    User _user = new RISService().GetUserByConsultant(_consultantId);
                    if (_user != null)
                    {

                        MessageBox.Show("User already exists for this consultant", "RIS");
                        return;
                    }
                }

            }
            else
            {
                _consultantId = 0;
            }


            if (chkAssigToRad.Checked)
            {
                _IsAssignToRadAllow = true;
            }
            if (chkViewDownload.Checked)
            {
                _IsViewDownloadAllow = true;
            }
            if (chkWriteEdit.Checked)
            {
                _IsReportWriteEditAllow = true;
            }
            if (chkAccessToMainViewer.Checked)
            {
                _IsAccessToMainViewer = true;
            }



            if (txtUserName.Tag != null)
            {
                VMUserDetail _uDetail = (VMUserDetail)txtUserName.Tag;

                User _user = new RISService().GetUserById(_uDetail.UserId);
                _user.FullName = txtFullName.Text;
                _user.MobileNo = txtMobileNo.Text;
                _user.RoleId = ((Role)cmbRole.SelectedItem).RoleId;
                _user.TenantId = _tenantId;
                _user.RCId = _consultantId;
                _user.CloudAccessLink = txtCloudAccessLink.Text;
                _user.CloudUserName = txtCloudUserName.Text;
                _user.CloudPassword = txtCloudPassword.Text;
                _user.IsAssignToRadAllow = _IsAssignToRadAllow;
                _user.IsReportViewAllow = _IsViewDownloadAllow;
                _user.IsReportWriteAllow = _IsReportWriteEditAllow;
                _user.IsMainViewerAlloted = _IsAccessToMainViewer;
                new RISService().UpdateUser(_user);

               


                MessageBox.Show("Update Successful");


                LoadActiveUsers();

                ClearPage();

            }
            else
            {
                if (txtUserName.Text.Contains(" "))
                {
                    MessageBox.Show("Login name should not contain any space", "HERP");
                    return;
                }

                if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Login name, password and confim password are mandatory field. ", "HERP");
                    return;
                }

                if (new RISService().IsLoginNameExists(txtUserName.Text))
                {
                    MessageBox.Show("Login name already taken by another user. Please try using another name ", "HERP");
                    return;
                }

               
                  
                    User _user = new User();
                    _user.LoginName = txtUserName.Text;
                    _user.FullName = txtFullName.Text;
                    _user.MobileNo = txtMobileNo.Text;
                    _user.Password = _arr[0];
                    _user.RoleId = Convert.ToInt32(cmbRole.SelectedValue);
                    _user.CloudAccessLink = txtCloudAccessLink.Text;
                    _user.CloudUserName = txtCloudUserName.Text;
                    _user.CloudPassword = txtCloudPassword.Text;
                    _user.IsAssignToRadAllow = _IsAssignToRadAllow;
                    _user.IsReportViewAllow = _IsViewDownloadAllow;
                    _user.IsReportWriteAllow = _IsReportWriteEditAllow;
                    _user.IsMainViewerAlloted = _IsAccessToMainViewer;
                    _user.RCId = _consultantId;
                    _user.TenantId = _tenantId;
                    _user.Salt = _arr[1];

                    _user.Status = "Active";

                    int _userId = new RISService().CreateUser(_user);

                    if (_userId > 0)
                    {


                        UserRole _urole = new UserRole();
                        _urole.UserId = _userId;
                        _urole.RoleId = Convert.ToInt32(cmbRole.SelectedValue);

                        if (new RISService().MapUserWithRole(_urole))
                        {

                            MessageBox.Show("User created successfully.", "H-ERP");
                        }

                       
                        ClearPage();
                        LoadActiveUsers();
                    }
                    else
                    {
                        MessageBox.Show("Fail to create user.", "HERP");
                    }

               
            }

            
        }

        public List<int> CheckedModules(TreeNodeCollection theNodes)
        {
            List<int> aResult = new List<int>();

            if (theNodes != null)
            {
                foreach (TreeNode aNode in theNodes)
                {
                    if (aNode.Checked)
                    {
                        string[] arr = null;
                        arr = aNode.Tag.ToString().Split('|');
                        aResult.Add(Convert.ToInt32(arr[0]));
                    }

                    aResult.AddRange(CheckedModules(aNode.Nodes));
                }
            }

            return aResult;
        }

        private void ClearPage()
        {
            unlocked = false;
            txtUserName.Text = "";
            txtFullName.Text = "";
            txtMobileNo.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtSelectHospital.Text = "";
            txtSelectHospital.Tag = null;
            LoadRoles(0);
            cmbConsultant.Enabled = false;
            unlocked = true;

        }

        //List<ModulePermission> _permissionList;
        private void frmCreateUser_Load(object sender, EventArgs e)
        {


            isLoaded = false;
            cmbConsultant.Enabled = false;

            LoadRoles(0);


            foreach (Control ctrl in this.Controls)
            {
                ctrl.GotFocus += ctrl_GotFocus;
                ctrl.LostFocus += ctrl_LostFocus;
            }


            LoadConsultants(0);

            isLoaded = true;

            //cmbConsultant.Enabled = false;

            LoadActiveUsers();



            ctrlHospitalSearch.Location = new Point(txtSelectHospital.Location.X, txtSelectHospital.Location.Y);
            ctrlHospitalSearch.ItemSelected += ctrlHospitalSearch_ItemSelected;



        }

        private void ctrlHospitalSearch_ItemSelected(SearchResultListControl<Tenant> sender, Tenant item)
        {
            txtSelectHospital.Text = item.Name;
            txtSelectHospital.Tag = item;
            sender.Visible = false;
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
            }
        }

        private void LoadRoles(int _roleId)
        {
            List<Role> _role = new RISService().GetRoles();
            _role.Insert(0, new Role() { RoleId = 0, Name = "Select Role" });
            cmbRole.DataSource = _role;
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "RoleId";

            cmbRole.SelectedItem = _role.Find(x => x.RoleId == _roleId);

            if (_roleId == 3)
            {
                cmbConsultant.Enabled = true;
            }
            else
            {
                cmbConsultant.Enabled = false;
            }

        }

        private void ctrl_LostFocus(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            //if (ctrl.Tag is Color)
            ctrl.BackColor = Color.White;
        }

        private void ctrl_GotFocus(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            //ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.NavajoWhite;
        }


       

        private async void LoadActiveUsers()
        {
            List<VMUserDetail> _userDetail = await new RISAPIConsumerService().GetUserDetails();

            dgUsers.SuspendLayout();
            dgUsers.Rows.Clear();
            foreach (VMUserDetail user in _userDetail)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 35;
                row.Tag = user;
                row.CreateCells(dgUsers, user.UserId, user.LoginName, user.FullName, user.MobileNo, user.RoleName, user.Status, false);
                dgUsers.Rows.Add(row);
            }

        }

       

      

        private void dgUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            VMUserDetail _udetail = dgUsers.SelectedRows[0].Tag as VMUserDetail;
            txtUserName.Tag = _udetail;
            btnSave.Text = "Update";



            txtUserName.Text = _udetail.LoginName;
            txtFullName.Text = _udetail.FullName;
            txtMobileNo.Text = _udetail.MobileNo;
            LoadRoles(_udetail.RoleId);

            if (_udetail.RCId > 0) {
                LoadConsultants(_udetail.RCId); 
            }
            if (_udetail.TenantId > 0)
            {
                LoadHospital(_udetail.TenantId);
            }

            txtCloudAccessLink.Text = _udetail.CloudAccessLink;
            txtCloudUserName.Text = _udetail.CloudUserName;
            txtCloudPassword.Text = _udetail.CloudPassword;

            chkAssigToRad.Checked = _udetail.IsAssignToRadAllow;
            chkViewDownload.Checked = _udetail.IsReportViewAllow;
            chkWriteEdit.Checked = _udetail.IsReportWriteAllow;
            chkAccessToMainViewer.Checked = _udetail.IsMainViewerAlloted;

        }

        private void LoadHospital(int _tenantId)
        {
            unlocked = false;
            Tenant _tenant = new RISService().GetTenant(_tenantId);
            txtSelectHospital.Text = _tenant.Name;
            txtSelectHospital.Tag = _tenant;

            unlocked = true;
        }

       

        private void CheckPermittedNode(int moduleId, TreeNodeCollection tNodes)
        {
            foreach (TreeNode node in tNodes)
            {
                string[] arr = null;
                arr = node.Tag.ToString().Split('|');
                if (Convert.ToInt32(arr[0]) == moduleId)
                {
                    node.Checked = true;

                }
                else
                {
                    if (node.Nodes.Count > 0)
                    {
                        CheckPermittedNode(moduleId, node.Nodes);
                    }
                }
            }
        }

        private void treeMenu_AfterCheck(object sender, TreeViewEventArgs e)
        {

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Tag = null;
          
            btnSave.Text = "Save";

            txtFullName.Text = "";
            txtMobileNo.Text = "";
            txtUserName.Text = "";
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            //if (txtSearchUser.Text != "Search User")
            //{
            //    List<VMUserDetail> _userDetail = new UserService().GetUserDetailsByLoginName(txtSearchUser.Text).ToList();

            //    dgUsers.SuspendLayout();
            //    dgUsers.Rows.Clear();
            //    foreach (VMUserDetail user in _userDetail)
            //    {
            //        DataGridViewRow row = new DataGridViewRow();
            //        row.Height = 35;
            //        row.Tag = user;
            //        row.CreateCells(dgUsers, user.Id, user.LoginName, user.FullName, user.MobileNo, user.RoleName, user.Status, false);
            //        dgUsers.Rows.Add(row);
            //    }
            //}
        }

        private void radshortdoseYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                Role _r = cmbRole.SelectedItem as Role;
                if (_r != null && _r.RoleId==3)
                {
                    cmbConsultant.Enabled = true;
                    chkWriteEdit.Checked = true;
                    chkAccessToMainViewer.Checked = true;

                    chkAssigToRad.Checked = false;
                    chkViewDownload.Checked = false;
                }
                else
                {
                    cmbConsultant.Enabled = false;
                }

                if (_r != null && _r.RoleId == 4)
                {
                    txtSelectHospital.Enabled = true;

                    chkWriteEdit.Checked = false;
                    chkAccessToMainViewer.Checked = false;

                    chkAssigToRad.Checked = false;
                    chkViewDownload.Checked = true;
                }
                else
                {
                    txtSelectHospital.Enabled = false;
                }

            }
        }

        private void txtSelectHospital_TextChanged(object sender, EventArgs e)
        {

            if (unlocked)
            {
                string _txt = txtSelectHospital.Text;
                HideAllDefaultHidden();
                ctrlHospitalSearch.Visible = true;
                ctrlHospitalSearch.txtSearch.Text = _txt;
                ctrlHospitalSearch.txtSearch.SelectionStart = ctrlHospitalSearch.txtSearch.Text.Length;

                ctrlHospitalSearch.LoadData();
            }
        }

        private void HideAllDefaultHidden()
        {
            ctrlHospitalSearch.Visible = false;
        }

        private void ctrlHospitalSearch_SearchEsacaped(bool IsEscaped)
        {
            if (IsEscaped)
            {
                txtSelectHospital.Focus();
            }
        }
    }
}
