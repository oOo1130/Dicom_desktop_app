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
    public partial class frmAddEditRemoteNode : Form
    {
        public frmAddEditRemoteNode()
        {
            InitializeComponent();
        }

        private void frmAddEditRemoteNode_Load(object sender, EventArgs e)
        {
            LoadTenants(0);
            LoadRemoteNodes();
        }

        private void LoadTenants(int tenantId)
        {
            List<Tenant> _tenantList = new RISService().GetAllTenants();
            _tenantList.Insert(0, new Tenant() { TenantId = 0, Name = "Select Tenant" });

            cbTenant.DataSource = _tenantList;
            cbTenant.DisplayMember = "Name";
            cbTenant.ValueMember = "TenantId";

            cbTenant.SelectedItem = _tenantList.Find(x => x.TenantId == tenantId);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var nodeName = tbNodeName.Text;
            if (String.IsNullOrWhiteSpace(nodeName))
            {
                MessageBox.Show(this, "Specify a node name.",
                    "Remote Node Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var nodeHost = tbNodeHost.Text;
            if (String.IsNullOrWhiteSpace(nodeHost))
            {
                MessageBox.Show(this, "Specify a node host.",
                    "Remote Node Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var nodeAet = tbNodeAet.Text;
            if (String.IsNullOrWhiteSpace(nodeAet))
            {
                MessageBox.Show(this, "Specify a node AE title.",
                    "Remote Node Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var tenant = cbTenant.SelectedItem as Tenant;
            if (tenant!=null && tenant.TenantId == 0)
            {
                MessageBox.Show(this, "Specify a tenant.",
                    "Remote Node Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (tbNodeName.Tag==null)
            {
                var nodeWithSameAet = new RISService().GetNodeWithSameAet(nodeAet.ToUpper());
                if (nodeWithSameAet != null)
                {
                    MessageBox.Show(this, "A remote node with the same AET exists. Specify a different AET.",
                        "Remote Node Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

               RemoteDicomNode newNode = new RemoteDicomNode()
                {
                    NodeGuid = Guid.NewGuid(),
                    NodeName = nodeName,
                    NodeHost = nodeHost,
                    NodePort = (int)nuNodePort.Value,
                    NodeAet = nodeAet,
                    TenantId = tenant.TenantId
               };

                if(new RISService().CreateNewRemoteNode(newNode))
                {
                    MessageBox.Show(this, "New node created successfully",
                      "Remote Node Create", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                }
            }
            else
            {
                RemoteDicomNode _node = tbNodeName.Tag as RemoteDicomNode;

                _node.NodeName = nodeName;
                _node.NodeHost = nodeHost;
                _node.NodePort = (int)nuNodePort.Value;
                _node.NodeAet = nodeAet;
                _node.TenantId = tenant.TenantId;

                if(new RISService().UpdateRemoteNode(_node))
                {
                    MessageBox.Show(this, "Selected node updated successfully",
                       "Remote Node Update", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                }

            }

            LoadRemoteNodes();
        }

        private void LoadRemoteNodes()
        {
            List<VMRemoteDicomNode> _remoteNodes = new RISService().GetAllRemoteDicomNodes();
            dgRemoteNodes.SuspendLayout();
            dgRemoteNodes.Rows.Clear();
            foreach(var item in _remoteNodes)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 20;
                row.Tag = item;
                row.CreateCells(dgRemoteNodes, item.NodeName,item.NodeHost,item.NodePort,item.NodeAet,item.TenantName);

                dgRemoteNodes.Rows.Add(row);
            }


        }

        private void dgRemoteNodes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VMRemoteDicomNode _node = dgRemoteNodes.SelectedRows[0].Tag as VMRemoteDicomNode;
            if (_node != null)
            {
                tbNodeName.Text= _node.NodeName;
                tbNodeHost.Text= _node.NodeHost;
                tbNodeAet.Text= _node.NodeAet;
                nuNodePort.Value = _node.NodePort;
                LoadTenants(_node.TenantId);
            }
        }
    }
}
