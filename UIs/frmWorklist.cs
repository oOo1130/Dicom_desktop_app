using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS
{
    public partial class frmWorklist : Form
    {
        bool IsInVisibleArea = false;
        
        public frmWorklist()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            SetRadiologistPanel(IsInVisibleArea);
            
            LoadFiles();
        }

        private void SetRadiologistPanel(bool isInVisibleArea)
        {
            if (isInVisibleArea)
            {
                RadiologistPanel.Location = new Point(180, 35);
            }
            else
            {
                RadiologistPanel.Location = new Point(-500, 20);
            }
        }

        private void LoadFiles()
        {
            string currDir = @"C:\Windows\System32";
            DirectoryInfo di = new DirectoryInfo(currDir);
            FileInfo[] files = di.GetFiles();

            listView1.DoubleBuffered(true);

            listView1.BeginUpdate();
            listView1.View = View.Details;

            foreach (var fi in files)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(fi.Name);
                lvi.SubItems.Add("");
                listView1.Items.Add(lvi);
            }

            listView1.Columns.Add("", 20, HorizontalAlignment.Left);
            listView1.Columns.Add("Filename", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Comment", 100, HorizontalAlignment.Left);
            listView1.EndUpdate();

            Timer timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += (s, ea) =>
            {
                listView1.BeginUpdate();
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.Items[i].SubItems[2].Text = DateTime.Now.Second.ToString();
                }
                listView1.EndUpdate();
            };
            timer1.Enabled = true;

        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.DrawBackground();
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(e.Header.Tag);
                }
                catch (Exception)
                {
                }
                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.Left + 4, e.Bounds.Top + 4),
                    value ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal :
                    System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(this.listView1.Columns[e.Column].Tag);
                }
                catch (Exception)
                {
                }
                this.listView1.Columns[e.Column].Tag = !value;
                foreach (ListViewItem item in this.listView1.Items)
                    item.Checked = !value;

                this.listView1.Invalidate();

                btnAssignToRAD.Visible= !value;
            }
        }

        private void btnAssignToRAD_Click(object sender, EventArgs e)
        {
            SetRadiologistPanel(true);

        }

        private void btnHideRadiologistPanel_Click(object sender, EventArgs e)
        {
            SetRadiologistPanel(false);
        }

        private void lvRadiologist_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex % 2) == 1)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems = true;
            }
        }
    }
}
