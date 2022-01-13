
using RIS.Models;
using RIS.Repositories;
using RIS.Repository.ServiceObjects;
using RIS.Services;
using RIS.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDMS.Windows.Forms.UI.Common
{
    public partial class frmChangePassword : Form
    {
        public static LoginUser LoggedinUser { get; set; }
        public frmChangePassword()
        {
            InitializeComponent();
            LoggedinUser = MainForm.LoggedinUser;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {


            foreach (Control ctrl in this.Controls)
            {
                ctrl.GotFocus += ctrl_GotFocus;
                ctrl.LostFocus += ctrl_LostFocus;
            }



            lblUserId.Text = LoggedinUser.UserId.ToString();
            lblUserName.Text = LoggedinUser.Name;
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (new RISService().CheckOldPassword(lblUserName.Text, txtOldPassword.Text))
            {
                if (String.Compare(txtNewPassword.Text, txtConfirmNewPassword.Text) == 0)
                {
                    string[] _arr = HashGenerator.GetPasswordHashAndSalt(txtNewPassword.Text);
                    User _user = await new RISAPIConsumerService().GetUserById(Convert.ToInt32(lblUserId.Text));
                    _user.Password = _arr[0];
                    _user.Salt = _arr[1];
                    if (new RISService().ChangePassword(_user))
                    {
                        MessageBox.Show("Password changed successfully.", "HERP");
                    }
                    else
                    {
                        MessageBox.Show("Fail to change password.", "HERP");
                    }
                    
                }
                else
                {
                    MessageBox.Show("New password and confirm new password did not match.", "HERP");
                }
            }
            else
            {
                MessageBox.Show("Old password wrong.","HERP");
            }
        }
    }
}
