using BrightIdeasSoftware;
using RIS.Models;
using RIS.Services;
using RIS.UI;
using RIS.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RIS.UIs
{
    public partial class frmHISProcedure : Form
    {
        public bool isLoaded = false;
        
        public frmHISProcedure()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbModality.Text))
            {
                MessageBox.Show("Modality required.","Procedure",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtHISProcedure.Text))
            {
                MessageBox.Show("Procedure name required.", "Procedure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cmbModality.Tag != null)
            {
                HISProcedure hisProc = cmbModality.Tag as HISProcedure;
                hisProc.ProcName = txtHISProcedure.Text;
                if(new RISService().UpdateHISProcedure(hisProc))
                {
                    MessageBox.Show("Procedure update successful.", "Procedure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                HISProcedure hisProc = new HISProcedure();
                hisProc.Modality = cmbModality.Text;
                hisProc.ProcName = txtHISProcedure.Text;
                if (new RISService().SaveHISProcedure(hisProc))
                {
                    MessageBox.Show("Procedure creation successful.", "Procedure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


           
        }

        private void frmHISProcedure_Load(object sender, EventArgs e)
        {
            if (MainForm.IsInternetConnected)
            {
                isLoaded = false;


                LoadModalities("");

                isLoaded = true;

            }
            else
            {
                MessageBox.Show(Constants.offlineMsg, "Add/Edit Procedure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadProcedures(string _modality)
        {
           
            List<HISProcedure> _procList = new RISService().GetHISProcedures(_modality);
            this.lvHISProcedures.SetObjects(_procList);

        }

        private void ClearFields()
        {
        
            txtHISProcedure.Text = "";
            btnSave.Tag = null;
        }

        private void LoadModalities(string _modality)
        {
            List<Modality> _modLists = new RISService().GetAllowedModalities();
            _modLists.Insert(0, new Modality() { Id = 0, Name = "Select Modality" });
            cmbModality.DataSource = _modLists;
            cmbModality.DisplayMember = "Name";

            if (!string.IsNullOrEmpty(_modality))
            {
                cmbModality.SelectedItem = _modLists.Find(x => x.Name == _modality);
            }

        }

        private void cmbModality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                Modality _selectedModality = cmbModality.SelectedItem as Modality;
                if (_selectedModality.Id == 0) return;

                LoadProcedures(_selectedModality.Name);
            }
        }

        private void textBoxFilterSimple_TextChanged(object sender, EventArgs e)
        {
            this.TimedFilter(this.lvHISProcedures, textBoxFilterSimple.Text);
        }

        void TimedFilter(ObjectListView olv, string txt)
        {
            this.TimedFilter(olv, txt, 0);
        }

        void TimedFilter(ObjectListView olv, string txt, int matchKind)
        {
            TextMatchFilter filter = null;
            if (!String.IsNullOrEmpty(txt))
            {
                switch (matchKind)
                {
                    case 0:
                    default:
                        filter = TextMatchFilter.Contains(olv, txt);
                        break;
                    case 1:
                        filter = TextMatchFilter.Prefix(olv, txt);
                        break;
                    case 2:
                        filter = TextMatchFilter.Regex(olv, txt);
                        break;
                }
            }
            // Setup a default renderer to draw the filter matches
            if (filter == null)
                olv.DefaultRenderer = null;
            else
            {
                olv.DefaultRenderer = new HighlightTextRenderer(filter);

                // Uncomment this line to see how the GDI+ rendering looks
                //olv.DefaultRenderer = new HighlightTextRenderer { Filter = filter, UseGdiTextRendering = false };
            }

            // Some lists have renderers already installed
            HighlightTextRenderer highlightingRenderer = olv.GetColumn(0).Renderer as HighlightTextRenderer;
            if (highlightingRenderer != null)
                highlightingRenderer.Filter = filter;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            olv.AdditionalFilter = filter;
            //olv.Invalidate();
            stopWatch.Stop();

            IList objects = olv.Objects as IList;
            if (objects == null)
                this.toolStripStatusLabel1.Text =
                    String.Format("Filtered in {0}ms", stopWatch.ElapsedMilliseconds);
            else
                this.toolStripStatusLabel1.Text =
                    String.Format("Filtered {0} items down to {1} items in {2}ms",
                                  objects.Count,
                                  olv.Items.Count,
                                  stopWatch.ElapsedMilliseconds);
        }

        private void lvHISProcedures_DoubleClick(object sender, EventArgs e)
        {
            HISProcedure procObj = lvHISProcedures.Items[lvHISProcedures.SelectedIndex].Tag as HISProcedure;
            if (procObj != null)
            {
                cmbModality.Tag = procObj;
                txtHISProcedure.Text = procObj.ProcName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process photoViewer = new Process();
            //photoViewer.StartInfo.FileName = @"E:\Backup Soft\DCIM\Camera\20200215_162934.jpg";
            //photoViewer.StartInfo.Arguments = @"E:\Backup Soft\DCIM\Camera\20200215_162934.jpg";
            //photoViewer.Start();


            string msgresult = CustomMessageBox.showBox("RIS-REPORT","Are you sure");

            MessageBox.Show(msgresult);

            //var files = System.IO.Directory.GetFiles(@"\\abc\Test\AllFiles");

        }
    }
}
