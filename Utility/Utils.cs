using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS.Utility
{
    public static class Utils
    {
        static string sql = string.Empty;
        static SqlConnection con;
        static SqlCommand cmd;

        static string _server = @"Server;";

        public static DateTime GetServerDateAndTime()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GetLegacyDbConnectionString()))
                {
                    con.Open();
                    sql = string.Format(@"SELECT GETDATE();");
                    cmd = new SqlCommand(sql, con);
                    return Convert.ToDateTime(cmd.ExecuteScalar());
                }
            }
            catch
            {
                return DateTime.Now;
            }
          

        }

        public static string GetLegacyDbConnectionString()
        {

            return "Data Source=" + _server + "Initial Catalog=DicomServer;" + "Persist Security Info=False;User ID=sa;Password=Emsl#Ris@Dec2014;";

        }


        public static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Name";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

       
    }
}
