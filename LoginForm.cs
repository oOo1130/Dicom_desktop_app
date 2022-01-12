using DicomServer;
using MaterialSkin.Controls;
using RIS.Repository.ServiceObjects;
using RIS.Services;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RIS.UI
{
    public partial class LoginForm : MaterialForm
    {

       public static LoginUser loggedInuser=null;
        public LoginForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager manager = MaterialSkin.MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme =new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue300,MaterialSkin.Primary.Blue500,MaterialSkin.Primary.Blue500,MaterialSkin.Accent.LightBlue400,MaterialSkin.TextShade.WHITE);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Text = "Loading...";
            btnOk.Enabled = false;

            Exception exception = null;
            using (var form = new WaitingForm(async () =>
            {
                try
                {
                    PerformLogin();

                }
                catch (Exception ex)
                {
                    exception = ex;
                    Log.ApplicationLog.Error("Login: " + ex.GetAllMessages());
                }
            })
            {
                Title = "Login",
                Message = "Please wait checking your aunthenticity..."
            })
            {
                form.ShowDialog();

                if (exception != null)
                {
                    MessageBox.Show(this, exception.Message,
                        "Authenticaltion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //DialogResult = DialogResult.OK;
            }





            btnOk.Enabled = true;
            btnOk.Text = "&Login";

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Exception exception = null;
                using (var form = new WaitingForm(async () =>
                {
                    try
                    {
                        PerformLogin();

                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                        Log.ApplicationLog.Error("Login: " + ex.GetAllMessages());
                    }
                })
                {
                    Title = "Login",
                    Message = "Please wait checking your aunthenticity..."
                })
                {
                    form.ShowDialog();

                    if (exception != null)
                    {
                        MessageBox.Show(this, exception.Message,
                            "Authenticaltion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //DialogResult = DialogResult.OK;
                }


            }
        }

        private void PerformLogin()
        {
            
            if ((new RISService()).CheckLogin(txtUserName.Text, txtPassword.Text, out loggedInuser))
            {

                // string applicationDirectory = Application.StartupPath;

                // string rootPath = (Path.GetDirectoryName(Application.StartupPath).Replace(@"debug\", string.Empty)).Replace(@"bin", string.Empty);
                // string _rootPath = rootPath.Replace(@"bin", string.Empty);

                this.Invoke(new MethodInvoker(delegate ()
                {
                    new MainForm(loggedInuser).Show();
                    this.Hide();
                }));
            

                //var url = $"?userName={txtUserName.Text}&password={txtPassword.Text}";

                //var request = (HttpWebRequest)WebRequest.Create(url);
            
                //request.Method = "POST";
                //request.ContentType = "application/json";
               
                //var response = (HttpWebResponse)request.GetResponse();

                //var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();



              
            }
            else
            {
                MessageBox.Show("Username or password mismatched", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnOk.Text = "Loading...";
                btnOk.Enabled = false;
                PerformLogin();
                btnOk.Enabled = true;
                btnOk.Text = "&Login";
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //panel2.Paint += new PaintEventHandler(panel2_Paint);
           // panel2.Refresh();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(0, 0);
            Point endPoint = new Point(438, 513);

            LinearGradientBrush lgb =
                new LinearGradientBrush(startPoint, endPoint, Color.FromArgb(224, 123, 57), Color.FromArgb(5, 46, 102, 255));
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, 0, 0, 438, 513);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
