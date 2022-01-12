using RIS.Models;
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



namespace RIS
{
    public partial class frmCreateRole : Form
    {
        public frmCreateRole()
        {
            InitializeComponent();
        }

        private void frmCreateRole_Load(object sender, EventArgs e)
        {
            if (MainForm.IsInternetConnected)
            {
                LoadMenus();
                LoadRoles();
            }
            else
            {
                MessageBox.Show(Constants.offlineMsg);
            }
        }

        private void LoadMenus()
        {
            List<ProjectMenu> _PermittedParentsList = new RISService().GetAllMenus();

            if (_PermittedParentsList.Count() > 0)
            {
                treeMenu.Nodes.Clear();
                FillNode(_PermittedParentsList, null);
                treeMenu.ExpandAll();
            }

        }

        private void FillNode(List<ProjectMenu> items, TreeNode node)
        {
            string[] strArr = null;

            if (node != null)
            {
                strArr = node.Tag.ToString().Split('|');
            }

            var parentID = node != null
                ? Convert.ToInt32(strArr[0])
                : 0;

            var nodesCollection = node != null
                ? node.Nodes
                : treeMenu.Nodes;

            foreach (var item in items.Where(i => i.ParentId == parentID))
            {
                var newNode = nodesCollection.Add(item.Name, item.Name);
                newNode.Tag = item.MenuId + "|" + item.frmName + "|" + item.DisplayType;

                FillNode(items, newNode);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MainForm.IsInternetConnected)
            {

                if (!string.IsNullOrWhiteSpace(txtRoleName.Text))
                {

                    List<int> _selectedModules = CheckedModules(treeMenu.Nodes);

                    if (_selectedModules.Count() == 0)
                    {
                        MessageBox.Show("Plz. select at least one menu item", "Role Create", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        return;
                    }

                    if (txtRoleName.Tag != null)
                    {
                        Role _role = txtRoleName.Tag as Role;
                        new RISService().GrantMenuPermission(_selectedModules, _role.RoleId);
                        MessageBox.Show("Role updated successfully.","Role Management",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {

                        Role roleExits = new RISService().GetRoleByName(txtRoleName.Text);
                        if (roleExits != null)
                        {
                            MessageBox.Show("Role name already exists!", "Role Create", MessageBoxButtons.OK,
                            MessageBoxIcon.Information); return;
                        }

                        Role _role = new Role();
                        _role.Name = txtRoleName.Text;

                        if (new RISService().CreateRole(_role))
                        {
                            new RISService().GrantMenuPermission(_selectedModules, _role.RoleId);

                            MessageBox.Show("New role created successfully.", "Role Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadRoles();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(Constants.offlineMsg,"Create Role", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

        private void LoadRoles()
        {
            List<Role> _roleList = new RISService().GetRoles();
            dgRoles.SuspendLayout();
            dgRoles.Rows.Clear();

            foreach(var item in _roleList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 25;
                row.Tag = item;
                row.CreateCells(dgRoles, item.RoleId, item.Name);
                dgRoles.Rows.Add(row);
            }

        }

        private void dgRoles_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Role _role = dgRoles.SelectedRows[0].Tag as Role;
            if (_role != null)
            {
                txtRoleName.Text = _role.Name;
                txtRoleName.Tag = _role;

               List<MenuPermission>  _permissionList =new RISService().GetPermittedMenusByRoleId(_role.RoleId);
                
                LoadMenus();

                foreach (MenuPermission _permission in _permissionList)
                {
                    CheckPermittedNode(_permission.MenuId, treeMenu.Nodes);

                }
            }
        }


        private void CheckPermittedNode(int menuId, TreeNodeCollection tNodes)
        {
            foreach (TreeNode node in tNodes)
            {
                string[] arr = null;
                arr = node.Tag.ToString().Split('|');
                if (Convert.ToInt32(arr[0]) == menuId)
                {
                    node.Checked = true;

                }
                else
                {
                    if (node.Nodes.Count > 0)
                    {
                        CheckPermittedNode(menuId, node.Nodes);
                    }
                }
            }
        }

    }
}
