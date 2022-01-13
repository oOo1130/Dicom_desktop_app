using RIS.Models;
using RIS.Repository.ServiceObjects;
using RIS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS.UI
{
    public partial class MainForm : Form
    {
        public static LoginUser LoggedinUser{get; set;}
        public static bool IsInternetConnected { get; set; }
        public static string WorkStationId { get; set; }
        public MainForm(LoginUser user)
        {
            InitializeComponent();
            LoggedinUser = user;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.MdiParent = this;
            form.Show();
        }

        public void LoginSuccess(LoginUser user)
        {
           
            //this.lblUserId.Text = LoggedinUser.Id.ToString();
        }

       
        private void ShowChildForm(Form form)
        {
            form.MdiParent = this;
            form.WindowState = FormWindowState.Minimized;
            form.Show();
            form.WindowState = FormWindowState.Maximized;

        }

       
        private void tubeSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       
        private  void MainForm_Load(object sender, EventArgs e)
        {

            List<ProjectMenu> _PermittedMenuList = new RISService().GetPermittedMenusByUser(LoggedinUser.UserId);
            _PermittedMenuList = _PermittedMenuList.OrderBy(x => x.DisplayOrder).ToList();

            ImageList imageList = new ImageList { ImageSize = new Size(200, 200) };
            Image img = new Bitmap(Properties.Resources.folderImage2);
            treeImageList.Images.Add("imgFolder", img);
            treeMenu.ImageList = treeImageList;
           
            FillNode(_PermittedMenuList, null);

            //foreach (ToolStripMenuItem item in this.menuStrip1.Items)
            //{
            //    if (new UserService().IsUserPermitted(Convert.ToString(item.Tag), LoggedinUser))
            //    {
            //        item.Enabled = true;
            //        SetEnabled(item);
            //    }
            //    else
            //    {
            //        item.Enabled = false;
            //    }
            //}

            this.FormClosed += MainForm_FormClosed;

            string _macAddress = GetMacAddress();

            lblWorkStationId.Text = "Workstation Id: " + _macAddress + "   Logged in as " + MainForm.LoggedinUser.Name;
            WorkStationId = _macAddress;
            // this.lblUserNameLabel.Text = "Welcome,";
            //this.lblUserName.Text = LoggedinUser.Name;

            //if (!new PhProductService().IsOpeningStockSet(Utils.GetServerDateAndTime()))
            //{
            //    await new PhProductService().SetOpeningStock(Utils.GetServerDateAndTime());
            //}

            //orgSetting = new CommonService().GetOrgSettings();


            if(true) //(new Ping().Send("www.google.com").Status == IPStatus.Success)
            {

                lblNetConnectionStatus.Text = "Online";
                lblNetConnectionStatus.ForeColor = Color.Green;
                IsInternetConnected = true;

            }
            else
            {
                lblNetConnectionStatus.Text = "Offline";
                lblNetConnectionStatus.ForeColor = Color.IndianRed;
                IsInternetConnected = false;
            }



                timer1.Start();

        }

        private string GetMacAddress()
        {
            const int MIN_MAC_ADDR_LENGTH = 12;
            string macAddress = string.Empty;
            long maxSpeed = -1;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                //log.Debug(
                //    "Found MAC Address: " + nic.GetPhysicalAddress() +
                //    " Type: " + nic.NetworkInterfaceType);

                string tempMac = nic.GetPhysicalAddress().ToString();
                if (nic.Speed > maxSpeed &&
                    !string.IsNullOrEmpty(tempMac) &&
                    tempMac.Length >= MIN_MAC_ADDR_LENGTH)
                {
                    //log.Debug("New Max Speed = " + nic.Speed + ", MAC: " + tempMac);
                    maxSpeed = nic.Speed;
                    macAddress = tempMac;
                }
            }

            return macAddress;
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
                newNode.Tag = item.MenuId+"|" + item.frmName + "|" + item.DisplayType;
                newNode.ImageKey = "imgFolder";
                newNode.SelectedImageKey = "";
                FillNode(items, newNode);
            }

           
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
        private void treeMenu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Assembly frmAssembly = Assembly.LoadFile(Application.ExecutablePath);

            var selectedNode = e.Node.Tag;

            if (selectedNode == null) return;

            string[] strArr = null;
            if (selectedNode != null)
            {
                strArr = selectedNode.ToString().Split('|');
            }

            if (strArr[1] == null) return;

            if (strArr[2] == null) return;

            string _frm = strArr[1];
            string _displayType= strArr[2];

            foreach (Type type in frmAssembly.GetTypes())

            {

                //MessageBox.Show(type.Name);

                if (type.BaseType == typeof(Form))
                {

                   // MessageBox.Show(type.Name);
                    if (type.Name == _frm)

                    {


                        Form frmShow = (Form)frmAssembly.CreateInstance(type.ToString());

                        // then we  close all of the child Forms with  simple below code



                        foreach (Form form in this.MdiChildren)
                        {
                             form.Close();
                        }


                        if (_frm.Equals("frmWorkListV3") && (LoggedinUser.RoleId == 3 || LoggedinUser.RoleId == 4))
                        {
                            frmShow.WindowState = FormWindowState.Normal;
                            this.Hide();
                            frmShow.Show();
                            

                            return;
                        }


                        if (_displayType == "MDIChild") {

                            frmShow.MdiParent = this;
                            frmShow.WindowState = FormWindowState.Maximized;
                            frmShow.Show();

                        }
                        else if(_displayType == "WS")
                        {
                            frmShow.WindowState = FormWindowState.Normal;
                            frmShow.Show();
                           
                            //this.Enabled = false;
                        }
                        else
                        {
                            frmShow.Show();
                            //this.Enabled = false;
                        }

                        
                        
                        //frmShow.ControlBox = false;

                       
                        
                    }

                }
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if(true) //(new Ping().Send("www.google.com").Status == IPStatus.Success)
                {
                    lblNetConnectionStatus.Text = "Online";
                    lblNetConnectionStatus.ForeColor = Color.Green;
                    IsInternetConnected = true;
                }
                else
                {
                    lblNetConnectionStatus.Text = "Offline";
                }
            }catch(Exception ex)
            {
                lblNetConnectionStatus.Text = "Offline";
                lblNetConnectionStatus.ForeColor = Color.Red;
                IsInternetConnected = false;
            }
        }
    }
}
