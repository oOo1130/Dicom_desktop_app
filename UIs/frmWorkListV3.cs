using BrightIdeasSoftware;
using DicomServer;
using DocumentFormat.OpenXml.Packaging;
using htmledit;
using Itenso.TimePeriod;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Novacode;
using OpenXmlPowerTools;
using RIS.Models;
using RIS.Models.VWModels;
using RIS.Properties;
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
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Linq;
using Timer = System.Threading.Timer;

namespace RIS.UIs
{

    public partial class frmWorkListV3 : Form
    {
        bool IsInVisibleArea = false;
        bool unlocked = true;
        static DocX g_document;
        string ReportFilePath = string.Empty;
        string ReportFileNameWithPath = string.Empty;
        private bool IsUNCConnected = false;
        private bool _isReportWindowAllowed = false;
        User _user;
        VMReportObj rptObjUsedForOldReport;

        DateTime _datefrm = Convert.ToDateTime("2021/10/01");
        DateTime _dateto;
        DateTime _serverDateTime;
        private int _roleId = 0;
        private int _tenantId = 0;
        private int _consultantId = 0;
        private string _status = "All";

        IDictionary<string, string> macroListDictionary;

        private int nCurPageNumber = 0;
        private int nPageCount = 0;

        private int onePageItemCount = 0;

        private string _baseUrl = "http://115.69.214.82/api/Riswork/";

        [DllImport("user32")]

        public static extern long SetWindowPos(IntPtr hwnd, int hWndInsertAfter, int X, int y, int cx, int cy, int wFlagslong);

        const short SWP_NOSIZE = 0x0001;

        const short SWP_NOMOVE = 0x0002;

        const int SWP_NOZORDER = 0x0004;

        const int SWP_SHOWWINDOW = 0x0040;


        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]

        public static extern int GetWindowLong(

        IntPtr hwnd,

        int nIndex

        );


        const int WS_THICKFRAME = 0x00040000;

        const int GWL_STYLE = -16;


        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]

        public static extern int SetWindowLong(

        IntPtr hwnd,

        int nIndex,

        int dwNewLong

        );


        public frmWorkListV3()
        {
            InitializeComponent();

            //olvWorklist.MouseDoubleClick += new MouseEventHandler(olvWorklist_MouseDoubleClick);
        }

        private void olvWorklist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You have clicked me!");
        }

        private async void frmWorkListV3_Load(object sender, EventArgs e)
        {

            macroListDictionary = new Dictionary<string, string>();

            _user = await new RISAPIConsumerService().GetUserById(MainForm.LoggedinUser.UserId);

            _roleId = _user.RoleId;
            _tenantId = _user.TenantId;
            _consultantId = _user.RCId;

            ctrlHospitalSearch.Location = new Point(txtStudySource.Location.X, txtStudySource.Location.Y);
            ctrlHospitalSearch.ItemSelected += ctrlHospitalSearch_ItemSelected;



            ctrlProcedureSearch.Location = new Point(txtProcedure.Location.X, txtProcedure.Location.Y);
            ctrlProcedureSearch.ItemSelected += CtrlProcedureSearch_ItemSelected; ;



            btnCreateOrder.GotFocus += btnCreateOrder_GotFocus;
            btnCreateOrder.LostFocus += btnCreateOrder_LostFocus;


            Exception exception = null;
            using (var form = new WaitingForm(async () =>
            {
                try
                {
                    LoadIncompleteWorkListOnPageLoading(_user);

                }
                catch (Exception ex)
                {
                    exception = ex;
                    Log.ApplicationLog.Error("WorkList Loading: " + ex.GetAllMessages());
                }
            })
            {
                Title = "WorkList Loading",
                Message = "WorkList Loading..."
            })
            {
                form.ShowDialog();

                if (exception != null)
                {
                    MessageBox.Show(this, exception.Message,
                        "WorkList Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //DialogResult = DialogResult.OK;
            }


        }

        private void btnCreateOrder_LostFocus(object sender, EventArgs e)
        {
            btnCreateOrder.FlatStyle = FlatStyle.Standard;
            btnCreateOrder.FlatAppearance.BorderColor = Color.Gray;
        }

        private void btnCreateOrder_GotFocus(object sender, EventArgs e)
        {
            btnCreateOrder.FlatStyle = FlatStyle.Flat;
            btnCreateOrder.FlatAppearance.BorderColor = Color.DarkGreen;
        }

        private async void LoadIncompleteWorkListOnPageLoading(User user)
        {


            nCurPageNumber = 0;
            nPageCount = 0;
            // this.PageNumber.Text = "";


            string SearchFilter = "";

            _serverDateTime = await new RISAPIConsumerService().GetServerDateAndTimeAPICallFuncAsync();
            _datefrm = _serverDateTime.AddDays(-8);
            _dateto = _serverDateTime;


            try
            {

                this.Invoke(new MethodInvoker(delegate ()
                {
                    dateTimePickerStudyFrom.Value = _serverDateTime.AddDays(-8);
                    dateTimePickerStudyTo.Value = _serverDateTime;
                    SearchFilter = textBoxFilterSimple.Text;
                    RadiologistPanel.Location = new Point(-1000, 20);

                }));



                if (_user.RoleId == 3)
                {
                    ReportConsultant _consultant = new ReportService().GetReportConsultant(_user.RCId);

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        tabPage2.Tag = _consultant;
                        ShowAssignedToRadiologistPanel.Visible = false;

                        contextMenuStrip1.Visible = false;
                        contextMenuStrip1.Hide();

                        tabControl1.TabPages.Remove(tabPage3);

                    }));


                    _isReportWindowAllowed = true;

                    macroListDictionary = await new RISAPIConsumerService().GetMacroList(_user.RCId);

                    List<HtmlTempleForReport> _templistList = await new RISAPIConsumerService().GetHtmlTemplateForReport(_consultant.RCId);

                    ShowAssignedToRadiologistPanel.Tag = _templistList;

                }

                if (_user.RoleId == 4)
                {

                    this.Invoke(new MethodInvoker(delegate ()
                    {

                        ShowAssignedToRadiologistPanel.Visible = true;
                        contextMenuStrip1.Visible = false;
                        contextMenuStrip1.Hide();

                    }));


                }



                if (_user.RoleId != 3)
                {
                    List<VMReportConsultant> _radList = await new RISAPIConsumerService().GetReportConsultants();

                    LoadRadiologistSimpleLv(_radList);

                }


                MasterTemplate _mtemplate = await new RISAPIConsumerService().GetWordMasterTemplateContent();

                tabPage1.Tag = _mtemplate;



                LoadInitialIncompleteStudies(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status, SearchFilter);

            }
            catch (Exception ex)
            {
                Log.ApplicationLog.Error("Import worklist for display on LV: " + ex.GetAllMessages());
            }


            timer1.Start();



        }

        DateTime g_datefrm;
        DateTime g_dateto;
        int g_roleId;
        int g_tenantId;
        int g_consultantId;
        string g_status;
        string g_SearchFilter;
        int g_nTotalItemCount;

        private async void LoadInitialIncompleteStudies(DateTime _datefrm, DateTime _dateto, int _roleId, int _tenantId, int _consultantId, string _status, string SearchFilter)
        {

            onePageItemCount = Decimal.ToInt32(this.txtRowPerpage.Value);

            g_datefrm = _datefrm; g_dateto = _dateto; g_roleId = _roleId; g_tenantId = _tenantId; g_consultantId = _consultantId; g_status = _status; g_SearchFilter = SearchFilter;



            int nTotalItemCount = await GetIncompleteItemCount(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status, SearchFilter);

            g_nTotalItemCount = nTotalItemCount;



            nPageCount = (new RISPagingService()).GetPageCount(nTotalItemCount, onePageItemCount);


            nCurPageNumber = 1;




            LoadWorkListOnePageToLvListCtrl(nCurPageNumber, onePageItemCount);


            if (nPageCount > 0) SetEnabledPrevNextBtn(true);
            else SetEnabledPrevNextBtn(false);

            //if (_consultantId > 0)
            //{
            //    GetTextMacrosList(ref macroListDictionary, _consultantId);
            //    lblMacroDictionary.Tag = macroListDictionary;
            //}



        }

        private void GetTextMacrosList(ref IDictionary<string, string> d, int _consultantId)
        {
            string m, e;

            List<ShortCutKey> _shortKeys = new ReportService().GetShortCutKeys(_consultantId);

            d.Clear();

            foreach (var item in _shortKeys)
            {
                m = item.textmacro.ToUpper(); //convert to upper case
                e = item.expandedtext.ToString();

                d.Add(m, e);
            }
        }

        private void SetEnabledPrevNextBtn(bool state)
        {
            //toolStripStatusLabel3.Text = "aasdfasdfasdf";
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    PageNumber.Text = $"{nCurPageNumber}/{nPageCount}  (Count={g_nTotalItemCount})";
                    prevPageBtn.Enabled = state;
                    nextPageBtn.Enabled = state;
                }));
            }

        }


        private void SetEnabledReportPagePrevNextBtn(bool state)
        {
            //toolStripStatusLabel3.Text = "aasdfasdfasdf";
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    ReportPageNumber.Text = $"{nCurPageNumber}/{nPageCount}  (Count={g_nTotalItemCount})";
                    rptPrevBtn.Enabled = state;
                    rptNextBtn.Enabled = state;
                }));
            }

        }

        private async void LoadWorkListOnePageToLvListCtrl(int nCurPageNumber, int onePageItemCount)
        {


            if (nPageCount == 0)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.olvWorklist.Items.Clear();
                }));
                return;
            }


            List<VMRISWorklistSubSetForLV> _wListItem = await (new RISAPIConsumerService()).GetSearchFilterIncompleteOnePageItems(g_datefrm, g_dateto, g_roleId, g_tenantId, g_consultantId, g_status, g_SearchFilter, nCurPageNumber, onePageItemCount);
            if (_wListItem == null || _wListItem.Count() == 0)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.olvWorklist.Items.Clear();
                }));
                return;
            }


            setObjectToLvList(_wListItem);

        }

        private void setObjectToLvList(List<VMRISWorklistSubSetForLV> worklistItem)
        {
            if (worklistItem == null || worklistItem.Count() == 0) return;




            this.PersonColumn.ImageGetter = delegate (object row)
            {

                string sex = ((VMRISWorklistSubSetForLV)row).PatientSex.ToUpperInvariant();
                if (sex.Equals("M"))
                    return "groom";
                if (sex.Equals("F"))
                    return "woman"; // person


                return "user";
            };


            this.viewerImgColumn.ImageGetter = delegate (object rowObject)
            {
                // this would essentially be the same as using the ImageAspectName
                return RIS.Properties.Resources.RVIcon;
            };



            this.emslViewer.ImageGetter = delegate (object rowObject)
            {
                // this would essentially be the same as using the ImageAspectName
                return RIS.Properties.Resources.EMSLViewer2;
            };


            //viewerImgColumn.ImageGetter += delegate (object rowObject) {
            //    int imageListIndex = 19;

            //    // some logic here
            //    // decide which image to use based on rowObject properties or any other criteria

            //    return imageListIndex;
            //};



            this.olvWorklist.SetObjects(worklistItem);
        }

        private static async Task<int> GetIncompleteItemCount(DateTime _datefrm, DateTime _dateto, int _roleId, int _tenantId, int _consultantId, string _status, string SearchFilter)
        {
            return await new RISAPIConsumerService().GetIncompleteItemCount(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status, SearchFilter);
        }

        private void GetTextMacrosList(ReportConsultant _counsultant, ref IDictionary<string, string> d)
        {
            string m, e;

            List<ShortCutKey> _shortKeys = new ReportService().GetShortCutKeys(_counsultant.RCId);

            d.Clear();

            foreach (var item in _shortKeys)
            {
                m = item.textmacro.ToUpper(); //convert to upper case
                e = item.expandedtext.ToString();

                d.Add(m, e);
            }

        }

        //private async void LoadWorkListAndReportList(User user)
        //{

        //    _serverDateTime = await new RISAPIConsumerService().GetServerDateAndTimeAPICallFuncAsync();

        //    DateTime _datefrm = Convert.ToDateTime("2021/10/01");
        //    DateTime _dateto = _serverDateTime;

        //    try
        //    {
        //        List<VMRISWorklist> _wListItem = await LoadAllIncompleteStudies(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status);

        //        List<VMRISWorklist> _CompletedList = await LoadAllCompletedStudies(_serverDateTime, _serverDateTime, _roleId, _tenantId, _consultantId, _status);



        //        populateReportLv(_CompletedList);



        //        if (_user.RoleId != 3)
        //        {
        //            LoadRadiologists();




        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //         Log.ApplicationLog.Error("Import worklist for display on LV: " + ex.GetAllMessages());
        //    }


        //    timer1.Start();


        //}

        private async Task<List<VMRISWorklist>> LoadAllCompletedStudies(DateTime datefrm, DateTime dateto, int roleId, int tenantId, int consultantId, string status)
        {
            List<VMRISWorklist> _worklistItem = await new RISService().GetCompletedWorklistsUsingHtmlEditor(datefrm, dateto, roleId, tenantId, consultantId, status);

            //populateReportLv(_worklistItem);

            return _worklistItem;

        }

        private void populateReportLv(List<VMRISWorklist> worklistItem)
        {
            this.olvCompleteWorklist.SetObjects(worklistItem);
        }

        private void CtrlProcedureSearch_ItemSelected(SearchResultListControl<HISProcedure> sender, HISProcedure item)
        {
            txtProcedure.Text = item.ProcName;
            txtProcedure.Tag = item;
            txtMRN.Focus();
            sender.Visible = false;
        }


        //private async void LoadRadiologists()
        //{

        //    List<ReportConsultant> _radList = await new RISAPIConsumerService().GetReportConsultants();

        //    LoadRadiologistSimpleLv(_radList);

        //}

        private void LoadRadiologistSimpleLv(List<VMReportConsultant> radList)
        {
            this.lvRadiologist.SetObjects(radList);
        }

        private void ctrlProcedureSearch_ItemSelected(SearchResultListControl<HISModalityProcedureMapping> sender, HISModalityProcedureMapping item)
        {
            // txtProcedure.Text = item.HISProcDescription;
            txtProcedure.Tag = item;
            sender.Visible = false;
        }

        private void ctrlHospitalSearch_ItemSelected(SearchResultListControl<Tenant> sender, Tenant item)
        {
            txtStudySource.Text = item.Name;
            txtStudySource.Tag = item;
            sender.Visible = false;
        }

        private async Task<List<VMRISWorklist>> LoadAllIncompleteStudies(DateTime datefrm, DateTime dateto, int roleId, int tenantId, int consultantId, string status)
        {


            List<VMRISWorklist> _worklistItem = await new RISService().GetAlldWorklists(datefrm, dateto, roleId, tenantId, consultantId, status);

            return _worklistItem;

        }

        private void SetRadiologistPanel(bool isInVisibleArea)
        {
            if (isInVisibleArea)
            {
                RadiologistPanel.Location = new Point(290, 100);
            }
            else
            {
                RadiologistPanel.Location = new Point(-1000, 20);
            }
        }

        private void olvWorklist_CellClick(object sender, CellClickEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine(String.Format("clicked ({0}, {1}). model {2}. click count: {3}",
               e.RowIndex, e.ColumnIndex, e.Model, e.ClickCount));
        }

        private void olvWorklist_GroupStateChanged(object sender, GroupStateChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(String.Format("Group '{0}' was {1}{2}{3}{4}{5}{6}",
                e.Group.Header,
                e.Selected ? "Selected" : "",
                e.Focused ? "Focused" : "",
                e.Collapsed ? "Collapsed" : "",
                e.Unselected ? "Unselected" : "",
                e.Unfocused ? "Unfocused" : "",
                e.Uncollapsed ? "Uncollapsed" : ""));
        }

        private void olvWorklist_HotItemChanged(object sender, HotItemChangedEventArgs e)
        {
            if (sender == null)
            {
                this.toolStripStatusLabel3.Text = "";
                return;
            }

            switch (e.HotCellHitLocation)
            {
                case HitTestLocation.Nothing:
                    this.toolStripStatusLabel3.Text = @"Over nothing";
                    break;
                case HitTestLocation.Header:
                case HitTestLocation.HeaderCheckBox:
                case HitTestLocation.HeaderDivider:
                    this.toolStripStatusLabel3.Text = String.Format("Over {0} of column #{1}", e.HotCellHitLocation, e.HotColumnIndex);
                    break;
                case HitTestLocation.Group:
                    this.toolStripStatusLabel3.Text = String.Format("Over group '{0}', {1}", e.HotGroup.Header, e.HotCellHitLocationEx);
                    break;
                case HitTestLocation.GroupExpander:
                    this.toolStripStatusLabel3.Text = String.Format("Over group expander of '{0}'", e.HotGroup.Header);
                    break;
                default:
                    this.toolStripStatusLabel3.Text = String.Format("Over {0} of ({1}, {2})", e.HotCellHitLocation, e.HotRowIndex, e.HotColumnIndex);
                    break;
            }
        }

        private void olvWorklist_ModelCanDrop(object sender, ModelDropEventArgs e)
        {
            e.Effect = DragDropEffects.None;

            // Only allow dropping if we are grouped on the cooking column
            if (!olvWorklist.ShowGroups)
                return;

            if (e.DropTargetLocation == DropTargetLocation.Item ||
                e.DropTargetLocation == DropTargetLocation.AboveItem ||
                e.DropTargetLocation == DropTargetLocation.BelowItem)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void olvWorklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSelectionChanged((ObjectListView)sender);
        }

        void HandleSelectionChanged(ObjectListView listView)
        {
            string msg;
            VMRISWorklistSubSetForLV p = (VMRISWorklistSubSetForLV)listView.SelectedObject;
            if (p == null)
                msg = listView.SelectedIndices.Count.ToString();
            else
                msg = String.Format("'{0}'", p.PatientName);
            VMRISWorklist focused = listView.FocusedItem == null ? null : (((OLVListItem)listView.FocusedItem).RowObject) as VMRISWorklist;
            this.toolStripStatusLabel1.Text = String.Format("Selected {0} of {1} items", msg, listView.GetItemCount());
        }

        private void olvWorklist_ModelDropped(object sender, ModelDropEventArgs e)
        {
            // What item was dropped on?
            VMRISWorklist target = e.TargetModel as VMRISWorklist;
            if (target == null)
                return;

            foreach (VMRISWorklist source in e.SourceModels)
            {
                source.NoOfImages = target.NoOfImages;
            }

            olvWorklist.BuildList(true);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3CheckedChanged(object sender, EventArgs e)
        {
            ShowGroupsChecked(this.olvWorklist, (CheckBox)sender);
        }

        void ShowGroupsChecked(ObjectListView olv, CheckBox cb)
        {
            if (cb.Checked && olv.View == System.Windows.Forms.View.List)
            {
                cb.Checked = false;
                MessageBox.Show("ListView's cannot show groups when in List view.", "Object List View Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                olv.ShowGroups = cb.Checked;
                olv.BuildList();
            }
        }

        private void chkItemCount_CheckedChanged(object sender, EventArgs e)
        {
            ShowLabelsOnGroupsChecked(this.olvWorklist, (CheckBox)sender);
        }

        void ShowLabelsOnGroupsChecked(ObjectListView olv, CheckBox cb)
        {
            olv.ShowItemCountOnGroups = cb.Checked;
            if (olv.ShowGroups)
                olv.BuildGroups();
        }

        private void olvWorklist_DoubleClick(object sender, EventArgs e)
        {
            if (_user.RoleId == 3)
            {
                OpenProcedureWithViewer();
            }
            else if (_user.RoleId == 4)
            {
                OnPreviewStudies();
            }
            else
            {
                OpenProcedureWithViewer();
            }


        }

        private void OnPreviewStudies()
        {
            var selectedStudies = GetSelectedStudies(olvWorklist);
            if (selectedStudies.Count == 0)
                return;

            using (var form = new PreviewForm(selectedStudies.Select(s => s.Item1).ToList()))
                form.ShowDialog();
        }

        private List<Tuple<VMRISWorklistSubSetForLV, int>> GetSelectedStudies(ObjectListView lv)
        {
            var selectedStudies = new List<Tuple<VMRISWorklistSubSetForLV, int>>();

            if (lv.SelectedIndices.Count > 0)
            {
                foreach (int selectedIndice in lv.SelectedIndices)
                {
                    if (selectedIndice != -1)
                    {
                        var databaseDataset = (VMRISWorklistSubSetForLV)lv.Items[selectedIndice].Tag;
                        if (databaseDataset != null)
                            selectedStudies.Add(
                                new Tuple<VMRISWorklistSubSetForLV, int>(databaseDataset, selectedIndice));
                    }
                }
            }

            return selectedStudies;
        }

        private void ShowAssignedToRadiologistPanel_Click(object sender, EventArgs e)
        {
            SetRadiologistPanel(true);
        }

        private void btnHideRadiologistPanel_Click(object sender, EventArgs e)
        {
            SetRadiologistPanel(false);
        }

        private void CommandUpdateWorkListInfo_Click(object sender, EventArgs e)
        {
            if (olvWorklist.Items.Count == 0) return;

            VMRISWorklistSubSetForLV wItem = (VMRISWorklistSubSetForLV)olvWorklist.Items[olvWorklist.SelectedIndex].Tag;

            if (wItem != null)
            {
                using (var form = new frmUpdateWorkListInfo(wItem, "worklist"))
                    form.ShowDialog();
            }
        }
        private void CommandCancelWorkListItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Select Files";
                openFileDialog.Filter = "Pdf|*.pdf|Image Files|*.jpg;*.jpeg;*.tif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    lvImgLists.DoubleBuffered(true);

                    lvImgLists.BeginUpdate();
                    lvImgLists.View = View.Details;


                    string[] images = openFileDialog.FileNames;
                    foreach (string imgsrc in images)
                    {

                        FileInfo fi = new FileInfo(imgsrc);

                        ListViewItem _item = new ListViewItem();
                        _item.SubItems.Add(imgsrc);
                        _item.Tag = fi.Name + "|" + fi.FullName + "|" + fi.Extension;
                        _item.ToolTipText = imgsrc;
                        lvImgLists.Items.Add(_item);
                    }

                    lvImgLists.Columns.Add("", 20, HorizontalAlignment.Left);
                    lvImgLists.Columns.Add("File Name", 400, HorizontalAlignment.Left);

                    lvImgLists.EndUpdate();
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void previewStudiesToolStripButton_Click(object sender, EventArgs e)
        {
            OnPreviewStudies();
        }

        private async void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (txtStudySource.Tag == null)
            {
                MessageBox.Show("Study source required!", "Order Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtStudySource.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
            {

                MessageBox.Show("Patient name required!", "Order Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtPatientName.Focus();

                return;
            }

            if (string.IsNullOrEmpty(cmbModalityInOrderEntry.Text))
            {

                MessageBox.Show("Modality required!", "Order Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbModalityInOrderEntry.Focus();

                return;
            }


            if (string.IsNullOrWhiteSpace(txtMRN.Text))
            {

                MessageBox.Show("MRN/IDNo required!", "Order Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMRN.Focus();

                return;
            }

            if (!radMale.Checked && !radFemale.Checked)
            {
                MessageBox.Show("Sex/Gender required!", "Order Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int _y = 0, _m = 0, _d = 0;
            int.TryParse(txtYears.Text, out _y);
            int.TryParse(txtMonths.Text, out _m);
            int.TryParse(txtDays.Text, out _d);

            if (_y == 0 && _m == 0 && _d == 0)
            {
                MessageBox.Show("Age required!", "Order Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Tenant _tenant = txtStudySource.Tag as Tenant;

            HISModalityProcedureMapping _procedure = txtProcedure.Tag as HISModalityProcedureMapping;

            string _sex = string.Empty;
            if (radMale.Checked)
            {
                _sex = "Male";
            }
            else
            {
                _sex = "Female";
            }


            DateTime _serverDateTime = await new RISAPIConsumerService().GetServerDateAndTimeAPICallFuncAsync();

            if (await FileUploaded(_tenant))
            {

                RISWorkList wListObj = new RISWorkList();
                wListObj.PatientId = txtMRN.Text;
                wListObj.TenantId = _tenant.TenantId;
                wListObj.PatientName = txtPatientName.Text;
                wListObj.PatientBirthdate = dtpDOB.Value;
                wListObj.PatientSex = _sex;
                wListObj.ProcedureName = _procedure.ModalityProcDescription;
                wListObj.Status = 2;

                MessageBox.Show("Order created");

            }
            else
            {
                MessageBox.Show("File not uploaded. Plz check your internet connection and try again.", "Order Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async Task<bool> FileUploaded(Tenant _tenant)
        {

            try
            {

                for (int i = 0; i < lvImgLists.Items.Count; i++)
                {

                    DateTime _serverDateTime = await new RISAPIConsumerService().GetServerDateAndTimeAPICallFuncAsync();

                    ListViewItem litem = lvImgLists.Items[i];  //picks list item
                    string[] fileinfo = litem.Tag.ToString().Split('|');
                    _inputParameter.Username = "ftp-user";
                    _inputParameter.Password = "123";
                    _inputParameter.Server = "FTP://103.120.201.105/";
                    _inputParameter.Filename = _tenant.ShortName + "_" + _serverDateTime.Ticks.ToString() + fileinfo[2].ToString();
                    _inputParameter.FullName = fileinfo[1].ToString();

                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", _inputParameter.Server, _inputParameter.Filename)));
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(_inputParameter.Username, _inputParameter.Password);
                    Stream ftpStream = request.GetRequestStream();
                    FileStream fs = File.OpenRead(_inputParameter.FullName);
                    byte[] buffer = new byte[1024];
                    double total = (double)fs.Length;
                    int byteRead = 0;

                    do
                    {
                        byteRead = fs.Read(buffer, 0, 1024);
                        ftpStream.Write(buffer, 0, byteRead);


                    } while (byteRead != 0);

                    fs.Close();
                    ftpStream.Close();


                }

                return await Task.FromResult(true);

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void txtStudySource_TextChanged(object sender, EventArgs e)
        {
            if (unlocked)
            {
                string _txt = txtStudySource.Text;
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

        private void ctrlProcedureSearch_SearchEsacaped(bool IsEscaped)
        {
            if (IsEscaped)
            {
                txtProcedure.Focus();
            }
        }

        private void ctrlHospitalSearch_SearchEsacaped(bool IsEscaped)
        {
            if (IsEscaped)
            {
                txtStudySource.Focus();
            }
        }

        private void txtPatientName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPatientName.Text)) return;

            txtPatientName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtPatientName.Text.ToLower());

        }

        private void txtYears_TextChanged(object sender, EventArgs e)
        {
            int _yrs = 0;
            int.TryParse(txtYears.Text, out _yrs);
            if (_yrs <= 200)
            {
                this.GetDOB();
            }
            else
            {
                //MessageBox.Show("Years exceed the limit");
                //txtYears.Focus();
            }
        }

        private void GetDOB()
        {
            int yrs = 0, mnths = 0, dys = 0;
            int.TryParse(txtYears.Text, out yrs);
            int.TryParse(txtMonths.Text, out mnths);
            int.TryParse(txtDays.Text, out dys);

            DateTime _dt = DateTime.Now;
            _dt = _dt.AddYears(0 - yrs);
            _dt = _dt.AddMonths(0 - mnths);
            _dt = _dt.AddDays(0 - dys);

            dtpDOB.Value = _dt;
        }

        private void txtMonths_TextChanged(object sender, EventArgs e)
        {
            int _months = 0;
            int.TryParse(txtMonths.Text, out _months);
            if (_months > 0 && _months <= 12)
            {
                this.GetDOB();
            }
            else
            {
                //MessageBox.Show("days exceed the limit");
                //txtDays.Focus();
            }
        }

        private void txtDays_TextChanged(object sender, EventArgs e)
        {
            int _dys = 0;
            int.TryParse(txtDays.Text, out _dys);
            if (_dys > 0 && _dys <= 31)
            {
                this.GetDOB();
            }
            else
            {
                //MessageBox.Show("days exceed the limit");
                //txtDays.Focus();
            }
        }

        private void txtProcedure_TextChanged(object sender, EventArgs e)
        {
            if (unlocked)
            {
                string _txt = txtProcedure.Text;
                HideAllDefaultHidden();
                //ctrlProcedureSearch.Visible = true;
                //ctrlProcedureSearch.txtSearch.Text = _txt;
                //ctrlProcedureSearch.txtSearch.SelectionStart = ctrlProcedureSearch.txtSearch.Text.Length;

                //ctrlProcedureSearch.LoadData();
            }
        }

        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            DateDiff dateDiff = new DateDiff(dtpDOB.Value, DateTime.Now);
            int yrs = dateDiff.ElapsedYears;
            int months = dateDiff.ElapsedMonths;
            int dys = dateDiff.ElapsedDays;

            txtYears.Text = yrs.ToString();
            txtMonths.Text = months.ToString();
            txtDays.Text = dys.ToString();
        }


        struct FtpSetting
        {
            public string Server { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Filename { get; set; }
            public string FullName { get; set; }
        }


        FtpSetting _inputParameter;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string fileName = ((FtpSetting)e.Argument).Filename;
            string fullName = ((FtpSetting)e.Argument).FullName;
            string userName = ((FtpSetting)e.Argument).Username;
            string passWord = ((FtpSetting)e.Argument).Password;
            string server = ((FtpSetting)e.Argument).Server;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", server, fileName)));
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(userName, passWord);
            Stream ftpStream = request.GetRequestStream();
            FileStream fs = File.OpenRead(fullName);
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;
            do
            {
                //if (!backgroundWorker.CancellationPending)
                //{
                byteRead = fs.Read(buffer, 0, 1024);
                ftpStream.Write(buffer, 0, byteRead);
                read += (double)byteRead;
                double percentage = (read / total) * 100;
                // backgroundWorker.ReportProgress((int)percentage);
                //}

            } while (byteRead != 0);

            fs.Close();
            ftpStream.Close();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //lblUploadStatus.Text = $"Upload {e.ProgressPercentage} %";
            //Progessbar.Value = e.ProgressPercentage;
            //Progessbar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //lblUploadStatus.Text = "Upload completed !";
        }

        private void openWithRadiantToolStripButton_Click(object sender, EventArgs e)
        {

            OpenProcedureWithViewer();

            //OpenExamWithRadiAnt(radiAntPath, networkRootPath, studies);
        }

        private async void OpenProcedureWithViewer()
        {
            var selectedStudies = GetSelectedStudies(olvWorklist);
            if (selectedStudies.Count == 0)
                return;

            var studies = selectedStudies.Select(s => s.Item1).ToList();


            VMRISWorklistSubSetForLV wlObj = studies.FirstOrDefault();

            if (wlObj != null)
            {
                if (wlObj.Status == 1)
                {
                    OpenAddendumForReview(wlObj);
                }
                else
                {


                    UNCAccessWithCredentials unc = new UNCAccessWithCredentials();

                    //if (!IsUNCConnected)
                    //{
                    //    IsUNCConnected = unc.NetUseWithCredentials(Constants._DicomFilePath, "Administrator", "", "EmslAdm@2014");
                    //}

                    if (!IsUNCConnected)
                    {
                        // TODO: These can be configurable

                        DateTime _OpinionDateTime = await new RISAPIConsumerService().GetServerDateAndTimeAPICallFuncAsync();

                        ReportConsultant _radiologist = tabPage2.Tag as ReportConsultant;
                        var radiAntPath = @"C:\Program Files\RadiAntViewer64bit\RadiAntViewer.exe";
                        var networkRootPath = _radiologist.DicomImagePath; //@"D:\DICOM\DicomServer_v1.5.0\Incoming\1";

                        var reportObj = new VMReportObj()
                        {
                            Studies = studies,
                            ViewerExecutablePath = radiAntPath,
                            NetworkRootPath = networkRootPath,
                            WordfilePath = ReportFileNameWithPath,
                            isReportWindowAllowed = MainForm.LoggedinUser.IsReportWriteAllow,
                            isMainViewerAlloted = MainForm.LoggedinUser.IsMainViewerAlloted,
                            ReportFileNameWithPath = ReportFileNameWithPath,
                            ReportFilePath = ReportFilePath,
                            vmRISWorkList = wlObj,
                            MsWord_masteremplatecontent = (tabPage1.Tag as MasterTemplate).TemplateContent,
                            Html_masteremplatecontent = (tabPage1.Tag as MasterTemplate).HtmlContent,
                            ReportConsultant = tabPage2.Tag as ReportConsultant,
                            user = _user,
                            IsEditWillSave = true,
                            ConsultantOpinionOnStudy = null,
                            OpinionDateTime = _OpinionDateTime,
                            htmlTemplates = ShowAssignedToRadiologistPanel.Tag as List<HtmlTempleForReport>,
                            macroDictionary = lblMacroDictionary.Tag as Dictionary<string, string>
                        };


                        if (MainForm.LoggedinUser.IsReportWriteAllow)
                        {
                            //this.StartViewer(studies, networkRootPath, radiAntPath);

                            using (var form = new frmHtmlReport(reportObj))
                            {
                                form.Owner = this;
                                DialogResult result = form.ShowDialog();

                                if (result == DialogResult.OK)
                                {
                                    //form.Dispose();
                                    this.RefreshPage();
                                }
                            }

                        }
                        else if (!MainForm.LoggedinUser.IsReportWriteAllow && MainForm.LoggedinUser.IsMainViewerAlloted)
                        {

                            this.StartViewer(studies, networkRootPath, radiAntPath);

                        }

                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Failed to connect to with server." + "\r\nPlz. check your internet connection and try again." + Constants._DicomFilePath + "\r\nLastError = " + unc.LastError.ToString(),
                                        "Failed to connect",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                        IsUNCConnected = false;
                    }
                    //StartViewer(reportObj);
                    //StartReportFile(reportObj);
                }

            }
        }

        private void StartViewer(List<VMRISWorklistSubSetForLV> studies, string networkRootPath, string ViewerPath)
        {
            this.EndTask("RadiAntViewer.exe");

            //     var directories = studies
            //.Select(item => Path.Combine(networkRootPath, item.TenantId.ToString(), item.StudyInstanceUid))
            //.ToList();

            var directories = studies
                   .Select(item => Path.Combine(networkRootPath, item.StudyInstanceUid))
                   .ToList();

            var args = String.Format("-d {0}", String.Join(" ", directories));

            ProcessStartInfo vrProcess = new ProcessStartInfo
            {
                Arguments = args,
                FileName = ViewerPath
            };


            Process p2 = new Process();

            p2.StartInfo = vrProcess;

            p2.Start();


        }

        private string GetNetworkPath()
        {
            WebRequest request = HttpWebRequest.Create("http://115.69.214.82:8001/myfiles/Incoming/");

            var response = (HttpWebResponse)request.GetResponse();

            string path;

            //using (var reader = new StreamReader(response.GetResponseStream()))
            //{
            //    path = reader.ReadToEnd();

            //    path = path.Substring(path.IndexOf("http:"));

            //    path = path.Remove(path.IndexOf("\",\n        \"word\""));
            //}

            return request.RequestUri.AbsoluteUri;
        }

        private void OpenAddendumForReview(VMRISWorklistSubSetForLV _wlObj)
        {
            var selectedStudies = GetSelectedStudies(olvWorklist);
            if (selectedStudies.Count == 0)
                return;

            var studies = selectedStudies.Select(s => s.Item1).ToList();
            VMRISWorklistSubSetForLV wlObj = _wlObj;

            RadiologistOpinionOne _existingXrayOpinion = null;
            RadiologistOpinionTwo _existingCTMRIOpinion = null;



        }





        public void EndTask(string taskname)
        {
            string processName = taskname.Replace(".exe", "");

            try
            {
                foreach (Process process in Process.GetProcessesByName(processName))
                {
                    process.Kill();

                }
            }
            catch (Exception ex)
            {

            }
        }

        private DocX CreateReportFromTemplate(DocX template, VMRISWorklist wListItem)
        {

            DateTime _serverDateTime = Utils.GetServerDateAndTime();


            template.ReplaceText("Report_Type", "DEPARTMENT OF RADIOLOGY & IMAGING");



            template.ReplaceText("Id_No", wListItem.PatientId.ToString());

            template.ReplaceText("Received_date", wListItem.OrderDateTime.ToString());
            template.ReplaceText("Report_Date", _serverDateTime.ToString());
            //template.ReplaceText("daily_id", txtDID.Text);
            template.ReplaceText("Report_Date", DateTime.Now.ToString("dd/MM/yyyy"));
            template.ReplaceText("Patient_Name", wListItem.PatientName);
            template.ReplaceText("Patient_Age", "");
            template.ReplaceText("Patient_Sex", wListItem.PatientSex);
            template.ReplaceText("Refd_By", wListItem.ReferralPhysician);


            template.AddFooters();

            ReportConsultant _doctor = tabPage2.Tag as ReportConsultant;

            if (_doctor != null)
            {

                MemoryStream ms = new MemoryStream(_doctor.ESignature);

                Novacode.Image image = template.AddImage(ms);

                Picture picture = image.CreatePicture();

                // Get the default Footer for this document.
                Footer footer_default = template.Footers.odd;

                // Insert a new Paragraph into the document.
                Paragraph p1 = footer_default.InsertParagraph();
                p1.Alignment = Alignment.left;
                p1.AppendPicture(picture);



                p1.AppendLine(_doctor.Name);
                p1.AppendLine(_doctor.IdentityLine1);
                p1.AppendLine(_doctor.IdentityLine2);
                p1.AppendLine(_doctor.IdentityLine3);
                p1.AppendLine(_doctor.IdentityLine4);

            }
            else
            {
                template.ReplaceText("Doctor_Name", "");
                template.ReplaceText("Identity_Line1", "");
                template.ReplaceText("Identity_Line2", "");
                template.ReplaceText("Identity_Line3", "");
                template.ReplaceText("Identity_Line4", "");
                template.ReplaceText("Identity_Line5", " ");
            }


            return template;
        }

        private byte[] OpenAndCombine(IList<byte[]> documents)
        {
            MemoryStream mainStream = new MemoryStream();

            mainStream.Write(documents[0], 0, documents[0].Length);
            mainStream.Position = 0;

            int pointer = 1;
            byte[] ret;
            try
            {
                using (WordprocessingDocument mainDocument = WordprocessingDocument.Open(mainStream, true))
                {

                    XElement newBody = XElement.Parse(mainDocument.MainDocumentPart.Document.Body.OuterXml);

                    for (pointer = 1; pointer < documents.Count; pointer++)
                    {
                        WordprocessingDocument tempDocument = WordprocessingDocument.Open(new MemoryStream(documents[pointer]), true);
                        XElement tempBody = XElement.Parse(tempDocument.MainDocumentPart.Document.Body.OuterXml);

                        newBody.Add(tempBody);
                        mainDocument.MainDocumentPart.Document.Body = new DocumentFormat.OpenXml.Wordprocessing.Body(newBody.ToString());
                        mainDocument.MainDocumentPart.Document.Save();
                        mainDocument.Package.Flush();
                    }
                }
            }
            catch (OpenXmlPackageException oxmle)
            {
                throw new Exception(string.Format(CultureInfo.CurrentCulture, "Error while merging files. Document index {0}", pointer), oxmle);

            }
            catch (Exception e)
            {
                throw new Exception(string.Format(CultureInfo.CurrentCulture, "Error while merging files. Document index {0}", pointer), e);
            }
            finally
            {
                ret = mainStream.ToArray();
                mainStream.Close();
                mainStream.Dispose();
            }
            return (ret);
        }


        private void StartReportFile(VMReportObj _reportObj)
        {

            //this.KillRunningProcess();

            Process p1 = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo(_reportObj.WordfilePath);

            p1.StartInfo = startInfo;

            p1.Start();


            int i = 0;

            while (i == 0)

            {

                System.Console.WriteLine("asdas");

                System.Threading.Thread.Sleep(100);

                p1.Refresh();

                i = p1.MainWindowHandle.ToInt32();

            }


            IntPtr h1 = p1.MainWindowHandle;

            Point screenlocation = Screen.AllScreens[0].Bounds.Location;

            SetWindowPos(h1, -1, screenlocation.X + Screen.AllScreens[0].Bounds.Width / 2, screenlocation.Y, Screen.AllScreens[0].Bounds.Width / 2, Screen.AllScreens[0].Bounds.Height, SWP_NOZORDER | SWP_SHOWWINDOW);

            int lNewLong = GetWindowLong(h1, GWL_STYLE);

            SetWindowLong(h1, GWL_STYLE, lNewLong & ~WS_THICKFRAME);
        }


        private void StartViewer(VMReportObj _reportObj)
        {

            //this.EndTask("RadiAntViewer.exe");

            var directories = _reportObj.Studies
       .Select(item => Path.Combine(_reportObj.NetworkRootPath, item.TenantId.ToString(), item.StudyInstanceUid))
       .ToList();
            var args = String.Format("-d {0}", String.Join(" ", directories));

            ProcessStartInfo vrProcess = new ProcessStartInfo
            {
                Arguments = args,
                FileName = _reportObj.ViewerExecutablePath
            };



            // Process procvr = Process.Start(vrProcess);

            Process p2 = new Process();


            p2.StartInfo = vrProcess;

            p2.Start();


            int i = 0;

            while (i == 0)

            {

                // System.Console.WriteLine("asdas");

                System.Threading.Thread.Sleep(100);

                p2.Refresh();

                i = p2.MainWindowHandle.ToInt32();

            }


            IntPtr h1 = p2.MainWindowHandle;

            Point screenlocation = Screen.AllScreens[0].Bounds.Location;

            SetWindowPos(h1, -1, screenlocation.X, screenlocation.Y, Screen.AllScreens[0].Bounds.Width / 2, Screen.AllScreens[0].Bounds.Height, SWP_NOZORDER | SWP_SHOWWINDOW);

            int lNewLong = GetWindowLong(h1, GWL_STYLE);

            SetWindowLong(h1, GWL_STYLE, lNewLong & ~WS_THICKFRAME);

        }



        private void OpenExamWithRadiAnt(string radiAntPath, string networkPath, List<VMRISWorklist> items)
        {
            var directories = items
         .Select(item => Path.Combine(networkPath, item.TenantId.ToString(), item.StudyInstanceUid))
         .ToList();
            var args = String.Format("-d {0}", String.Join(" ", directories));

            var start = new ProcessStartInfo
            {
                Arguments = args,
                FileName = radiAntPath
            };

            Process.Start(start);
        }

        private void btnHideRadiologistPanel_Click_1(object sender, EventArgs e)
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

        private void lvRadiologist_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void btnAssingToRad_Click(object sender, EventArgs e)
        {

            try
            {
                VMReportConsultant _consultant = lvRadiologist.Items[lvRadiologist.CheckedIndices[0]].Tag as VMReportConsultant;

                if (_consultant == null)
                {
                    MessageBox.Show("Plz. select a consultant and try again", "Radiologist", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }



                List<SelectedProcedureForAssign> _assignProcList = new List<SelectedProcedureForAssign>();
                foreach (ListViewItem eachItem in olvWorklist.CheckedItems)
                {
                    VMRISWorklistSubSetForLV vmWLObj = eachItem.Tag as VMRISWorklistSubSetForLV;
                    SelectedProcedureForAssign Obj = new SelectedProcedureForAssign();
                    if (vmWLObj != null)
                    {
                        Obj.ProcId = vmWLObj.ProcId;
                        Obj.ConsultantID = _consultant.RCId;
                        Obj.Status = 4;
                        Obj.RadNextCloudID = _consultant.RadNextCloudID;
                        _assignProcList.Add(Obj);
                    }
                }

                if (_assignProcList.Count > 0)
                {

                    var result = Task.Run(async () => await new RISAPIConsumerService().AssignedToRadiologistAPICall(_assignProcList)).GetAwaiter().GetResult();

                    if (result)
                    {

                        SetRadiologistPanel(false);

                        txtSearchRadiologist.Text = "";

                        MessageBox.Show("Work assigned to " + _consultant.Name, "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        foreach (ListViewItem item in lvRadiologist.Items)
                        {
                            item.Checked = false;
                        }

                        foreach (ListViewItem item in olvWorklist.Items)
                        {
                            item.Checked = false;
                        }

                        if (_user != null)
                        {
                            _serverDateTime = Task.Run(async () => await new RISAPIConsumerService().GetServerDateAndTimeAPICallFuncAsync()).GetAwaiter().GetResult();


                            _datefrm = dateTimePickerStudyFrom.Value;
                            _dateto = dateTimePickerStudyTo.Value;


                            string SearchFilter = this.textBoxFilterSimple.Text;
                            LoadInitialIncompleteStudies(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status, SearchFilter);
                            //List<VMRISWorklist> _IncompleteworkList = await LoadAllIncompleteStudies(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status);

                            //InitializeSimpleExampleLv(_IncompleteworkList);
                        }


                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "RIS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lvRadiologist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach (ListViewItem item in lvRadiologist.Items)
            {

                if (item.Index != e.Index) item.Checked = false;
            }
        }

        private void textBoxFilterSimple_TextChanged(object sender, EventArgs e)
        {
            this.TimedFilter(this.olvWorklist, textBoxFilterSimple.Text);
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

        private void rowHeightUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.olvWorklist.RowHeight = Decimal.ToInt32(this.rowHeightUpDown.Value);
        }

        private void txtSearchRadiologist_TextChanged(object sender, EventArgs e)
        {
            this.TimedFilter(this.lvRadiologist, txtSearchRadiologist.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {


                RefreshPage();


            }
        }

        private void RefreshPage()
        {
            Exception exception = null;
            using (var form = new WaitingForm(async () =>
            {
                try
                {
                    LoadIncompleteWorkListOnPageLoading(_user);

                }
                catch (Exception ex)
                {
                    exception = ex;
                    Log.ApplicationLog.Error("WorkList Loading: " + ex.GetAllMessages());
                }
            })
            {
                Title = "WorkList Loading",
                Message = "WorkList Loading..."
            })
            {
                form.ShowDialog();

                if (exception != null)
                {
                    MessageBox.Show(this, exception.Message,
                        "WorkList Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //DialogResult = DialogResult.OK;
            }

        }

        private void SetPageNumberValue()
        {
            PageNumber.Text = $"{nCurPageNumber}/{nPageCount}  (Count={g_nTotalItemCount})";
        }


        private void SetReportPageNumberValue()
        {
            PageNumber.Text = $"{nCurPageNumber}/{nPageCount}  (Count={g_nTotalItemCount})";
        }


        private void btnRefreshReportList_Click(object sender, EventArgs e)
        {
            if (_user != null)
            {

                Exception exception = null;
                using (var form = new WaitingForm(async () =>
                {
                    try
                    {
                        LoadCompletedWorkListOnPageLoading(_user);

                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                        Log.ApplicationLog.Error("WorkList Loading: " + ex.GetAllMessages());
                    }
                })
                {
                    Title = "WorkList Loading",
                    Message = "WorkList Loading..."
                })
                {
                    form.ShowDialog();

                    if (exception != null)
                    {
                        MessageBox.Show(this, exception.Message,
                            "WorkList Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //DialogResult = DialogResult.OK;
                }

            }
        }

        private async void btnOpenInViewer_Click(object sender, EventArgs e)
        {

            var selectedStudies = GetSelectedStudies(olvCompleteWorklist);
            if (selectedStudies.Count == 0)
                return;

            var studies = selectedStudies.Select(s => s.Item1).ToList();
            VMRISWorklistSubSetForLV wlObj = studies.FirstOrDefault();

            DateTime _OpinionDateTime = await new RISAPIConsumerService().GetServerDateAndTimeAPICallFuncAsync();


            if (_roleId == 4)
            {
                if (MainForm.LoggedinUser.IsMainViewerAlloted)
                {
                    OpenReportWithViewerNonEditable(wlObj, _OpinionDateTime);
                }
                else
                {
                    OpenReportPrintOnly(wlObj, _OpinionDateTime);
                }

            }


            if (_roleId == 3)
            {

                OpenReportWithViewerEditable(wlObj, _OpinionDateTime);

            }


            if (_roleId != 3 && _roleId != 4)
            {
                if (MainForm.LoggedinUser.IsMainViewerAlloted)
                {
                    OpenReportWithViewerNonEditable(wlObj, _OpinionDateTime);
                }
                else
                {
                    OpenReportPrintOnly(wlObj, _OpinionDateTime);
                }
            }



        }

        private void OpenReportWithViewerNonEditable(VMRISWorklistSubSetForLV wlObj, DateTime opdate)
        {
            var selectedStudies = GetSelectedStudies(olvCompleteWorklist);
            if (selectedStudies.Count == 0)
                return;

            var studies = selectedStudies.Select(s => s.Item1).ToList();


            var radiAntPath = @"C:\Program Files\RadiAntViewer64bit\RadiAntViewer.exe";
            var networkRootPath = Constants._DicomFilePath; //@"D:\DICOM\DicomServer_v1.5.0\Incoming";
            ConsultantOpinionOnStudy Obj = new ReportService().GetReportConsultantOpinionOnStudy(wlObj.ProcId, wlObj.ConsultantId);

            var reportObj = new VMReportObj()
            {

                vmRISWorkList = wlObj,

                Html_masteremplatecontent = (tabPage1.Tag as MasterTemplate).HtmlContent,
                ReportConsultant = tabPage2.Tag as ReportConsultant,
                user = _user,
                IsEditWillSave = false,
                ConsultantOpinionOnStudy = Obj,
                OpinionDateTime = opdate,
                htmlTemplates = ShowAssignedToRadiologistPanel.Tag as List<HtmlTempleForReport>
            };


            if (MainForm.LoggedinUser.IsMainViewerAlloted)
            {
                this.StartViewer(studies, networkRootPath, radiAntPath);


            }

            using (var form = new frmHtmlReport(reportObj))
            {
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK || form.DialogResult == DialogResult.Cancel)
                {
                    RefreshPage();
                }

            }
        }

        private void OpenReportWithViewerEditable(VMRISWorklistSubSetForLV wlObj, DateTime opdate)
        {

            var selectedStudies = GetSelectedStudies(olvCompleteWorklist);
            if (selectedStudies.Count == 0)
                return;

            var studies = selectedStudies.Select(s => s.Item1).ToList();


            var radiAntPath = @"C:\Program Files\RadiAntViewer64bit\RadiAntViewer.exe";
            var networkRootPath = Constants._DicomFilePath; //@"D:\Cloud\DICOMFILES\Incoming\1";
            ConsultantOpinionOnStudy Obj = new ReportService().GetReportConsultantOpinionOnStudy(wlObj.ProcId, wlObj.ConsultantId);

            var reportObj = new VMReportObj()
            {

                vmRISWorkList = wlObj,

                Html_masteremplatecontent = (tabPage1.Tag as MasterTemplate).HtmlContent,
                ReportConsultant = tabPage2.Tag as ReportConsultant,
                user = _user,
                IsEditWillSave = true,
                ConsultantOpinionOnStudy = Obj,
                OpinionDateTime = opdate,
                htmlTemplates = ShowAssignedToRadiologistPanel.Tag as List<HtmlTempleForReport>
            };


            if (MainForm.LoggedinUser.IsMainViewerAlloted)
            {
                this.StartViewer(studies, networkRootPath, radiAntPath);


            }

            using (var form = new frmHtmlReport(reportObj))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK || form.DialogResult == DialogResult.Cancel)
                {
                    RefreshPage();
                }
            }

        }

        private void OpenReportPrintOnly(VMRISWorklistSubSetForLV wlObj, DateTime opdate)
        {

            ConsultantOpinionOnStudy Obj = new ReportService().GetReportConsultantOpinionOnStudy(wlObj.ProcId, wlObj.ConsultantId);

            var reportObj = new VMReportObj()
            {
                vmRISWorkList = wlObj,
                ConsultantOpinionOnStudy = Obj,
                Html_masteremplatecontent = (tabPage1.Tag as MasterTemplate).HtmlContent,
                ReportConsultant = tabPage2.Tag as ReportConsultant,
                user = _user,
                OpinionDateTime = opdate,
                IsEditWillSave = false
            };


            using (var form = new frmHtmlReport(reportObj))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK || form.DialogResult == DialogResult.Cancel)
                {
                    RefreshPage();
                }
            }

        }

        private void btnPdfDownload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (olvCompleteWorklist.Items.Count == 0) return;

            VMRISWorklistSubSetForLV wItem = (VMRISWorklistSubSetForLV)olvCompleteWorklist.Items[olvCompleteWorklist.SelectedIndex].Tag;

            if (wItem != null)
            {
                using (var form = new frmUpdateWorkListInfo(wItem, "report"))
                {
                    form.ShowDialog();

                    if (form.DialogResult == DialogResult.OK || form.DialogResult == DialogResult.Cancel)
                    {
                        RefreshPage();
                    }
                }
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            Exception exception = null;
            using (var form = new WaitingForm(async () =>
            {
                try
                {
                    //LoadWorkListAndReportList(_user);

                }
                catch (Exception ex)
                {
                    exception = ex;
                    Log.ApplicationLog.Error("WorkList Loading: " + ex.GetAllMessages());
                }
            })
            {
                Title = "WorkList Loading",
                Message = "WorkList Loading..."
            })
            {
                form.ShowDialog();

                if (exception != null)
                {
                    MessageBox.Show(this, exception.Message,
                        "WorkList Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //DialogResult = DialogResult.OK;
            }






        }

        private void searchStudiesButton_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchReports_Click(object sender, EventArgs e)
        {

            Exception exception = null;
            using (var form = new WaitingForm(async () =>
            {
                try
                {
                    LoadReportListOnly();

                }
                catch (Exception ex)
                {
                    exception = ex;
                    Log.ApplicationLog.Error("Report Loading: " + ex.GetAllMessages());
                }
            })
            {
                Title = "Report Loading",
                Message = "Report Loading..."
            })
            {
                form.ShowDialog();

                if (exception != null)
                {
                    MessageBox.Show(this, exception.Message,
                        "Report List Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //DialogResult = DialogResult.OK;
            }




        }

        private async void LoadReportListOnly()
        {
            List<VMRISWorklist> _CompletedList = await LoadAllCompletedStudies(dtpReportfrom.Value, dtpReportTo.Value, _roleId, _tenantId, _consultantId, _status);

            populateReportLv(_CompletedList);
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            VMRISWorklist wlObj = olvWorklist.Items[olvWorklist.SelectedIndex].Tag as VMRISWorklist;
            if (wlObj != null)
            {

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])//your specific tabname

            {
                Exception exception = null;
                using (var form = new WaitingForm(async () =>
                {
                    try
                    {
                        LoadCompletedWorkListOnPageLoading(_user);

                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                        Log.ApplicationLog.Error("WorkList Loading: " + ex.GetAllMessages());
                    }
                })
                {
                    Title = "WorkList Loading",
                    Message = "WorkList Loading..."
                })
                {
                    form.ShowDialog();

                    if (exception != null)
                    {
                        MessageBox.Show(this, exception.Message,
                            "WorkList Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //DialogResult = DialogResult.OK;
                }

            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"]) //your specific tabname
            {
                Exception exception = null;
                using (var form = new WaitingForm(async () =>
                {
                    try
                    {
                        LoadInitialIncompleteStudies(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status, ""); //LoadIncompleteWorkListOnPageLoading(_user);

                    }
                    catch (Exception ex)
                    {
                        exception = ex;
                        Log.ApplicationLog.Error("WorkList Loading: " + ex.GetAllMessages());
                    }
                })
                {
                    Title = "WorkList Loading",
                    Message = "WorkList Loading..."
                })
                {
                    form.ShowDialog();

                    if (exception != null)
                    {
                        MessageBox.Show(this, exception.Message,
                            "WorkList Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //DialogResult = DialogResult.OK;
                }
            }
        }


        private void LoadCompletedWorkListOnPageLoading(User user)
        {
            DateTime _datefrm = dtpReportfrom.Value;
            DateTime _dateto = dtpReportTo.Value;
            string SearchFilter = textBoxFilterSimple.Text;

            LoadInitialCompletedStudies(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status, SearchFilter);
        }

        private async void LoadInitialCompletedStudies(DateTime _datefrm, DateTime _dateto, int _roleId, int _tenantId, int _consultantId, string _status, string SearchFilter)
        {

            int nTotalItemCount = await GetCompletedItemCount(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status, SearchFilter);

            g_datefrm = _datefrm; g_dateto = _dateto; g_roleId = _roleId; g_tenantId = _tenantId; g_consultantId = _consultantId; g_status = _status; g_SearchFilter = SearchFilter;


            g_nTotalItemCount = nTotalItemCount;

            nPageCount = (new RISPagingService()).GetPageCount(nTotalItemCount, onePageItemCount);
            nCurPageNumber = 1;



            LoadCompletedWorkListOnePageToLvListCtrl(nCurPageNumber, onePageItemCount);


            if (nPageCount > 0) SetEnabledReportPagePrevNextBtn(true);
            else SetEnabledReportPagePrevNextBtn(false);

        }

        private static async Task<int> GetCompletedItemCount(DateTime _datefrm, DateTime _dateto, int _roleId, int _tenantId, int _consultantId, string _status, string SearchFilter)
        {
            return await new RISAPIConsumerService().GetCompletedItemCount(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status, SearchFilter);
        }

        private async void LoadCompletedWorkListOnePageToLvListCtrl(int nCurPageNumber, int onePageItemCount)
        {

            if (nPageCount == 0)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.olvWorklist.Items.Clear();
                }));
                return;
            }


            List<VMRISWorklistSubSetForLV> _wListItem = await (new RISAPIConsumerService()).GetSearchFilterCompleteOnePageItems(g_datefrm, g_dateto, g_roleId, g_tenantId, g_consultantId, g_status, g_SearchFilter, nCurPageNumber, onePageItemCount);
            if (_wListItem == null || _wListItem.Count() == 0)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.olvWorklist.Items.Clear();
                }));
                return;
            }


            setObjectToReportLvList(_wListItem);



        }

        private void setObjectToReportLvList(List<VMRISWorklistSubSetForLV> objectRes)
        {
            if (objectRes == null || objectRes.Count() == 0) return;
            this.olvCompleteWorklist.SetObjects(objectRes);
        }

        private void prevPageBtn_Click(object sender, EventArgs e)
        {
            if (nCurPageNumber - 1 < 1) return;
            nCurPageNumber--;
            SetPageNumberValue();
            LoadWorkListOnePageToLvListCtrl(nCurPageNumber, onePageItemCount);
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            if (nCurPageNumber + 1 > nPageCount) return;
            nCurPageNumber++;
            SetPageNumberValue();
            LoadWorkListOnePageToLvListCtrl(nCurPageNumber, onePageItemCount);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            if (olvWorklist.Items.Count == 0) return;

            List<SelectedProcedureForAssign> _assignProcList = new List<SelectedProcedureForAssign>();
            foreach (ListViewItem eachItem in olvWorklist.CheckedItems)
            {
                VMRISWorklistSubSetForLV vmWLObj = eachItem.Tag as VMRISWorklistSubSetForLV;
                SelectedProcedureForAssign Obj = new SelectedProcedureForAssign();
                if (vmWLObj != null)
                {
                    Obj.ProcId = vmWLObj.ProcId;
                    Obj.ConsultantID = 0;
                    Obj.Status = 3;
                    Obj.RadNextCloudID = null;
                    _assignProcList.Add(Obj);
                }
            }
            if (_assignProcList.Count > 0)
            {
                var result = Task.Run(async () => await new RISAPIConsumerService().CancelAssignedToRadiologistAPICall(_assignProcList)).GetAwaiter().GetResult();

                if (result)
                {

                    SetRadiologistPanel(false);

                    txtSearchRadiologist.Text = "";

                    MessageBox.Show("Cancel Assignment", "RIS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (ListViewItem item in lvRadiologist.Items)
                    {
                        item.Checked = false;
                    }

                    foreach (ListViewItem item in olvWorklist.Items)
                    {
                        item.Checked = false;
                    }

                    if (_user != null)
                    {
                        _serverDateTime = Task.Run(async () => await new RISAPIConsumerService().GetServerDateAndTimeAPICallFuncAsync()).GetAwaiter().GetResult();


                        _datefrm = dateTimePickerStudyFrom.Value;
                        _dateto = dateTimePickerStudyTo.Value;


                        string SearchFilter = this.textBoxFilterSimple.Text;
                        LoadInitialIncompleteStudies(_datefrm, _dateto, _roleId, _tenantId, _consultantId, _status, SearchFilter);
                    }

                }
            }

        }

        public class JsonResponseStruct
        {
            public string Data;

        }


    }
}
