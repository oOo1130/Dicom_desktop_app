
namespace htmledit
{
    partial class frmHtmlReportV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHtmlReportV2));
            SpiceLogic.HtmlEditorControl.Domain.DesignTime.DictionaryFileInfo dictionaryFileInfo1 = new SpiceLogic.HtmlEditorControl.Domain.DesignTime.DictionaryFileInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.htmlEditor1 = new SpiceLogic.WinHTMLEditor.WinForm.WinFormHtmlEditor();
            this.BtnPageSetup = new System.Windows.Forms.ToolStripButton();
            this.BtnPreview = new System.Windows.Forms.ToolStripButton();
            this.tsslWordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCreateTemplate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReportComplete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectTemplate = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.htmlEditor1.Toolbar1.SuspendLayout();
            this.htmlEditor1.Toolbar2.SuspendLayout();
            this.htmlEditor1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.htmlEditor1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 600);
            this.panel1.TabIndex = 1;
            // 
            // htmlEditor1
            // 
            this.htmlEditor1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.htmlEditor1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.htmlEditor1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // 
            // htmlEditor1.BtnAlignCenter
            // 
            this.htmlEditor1.BtnAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnAlignCenter.Image")));
            this.htmlEditor1.BtnAlignCenter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnAlignCenter.Name = "_factoryBtnAlignCenter";
            this.htmlEditor1.BtnAlignCenter.Size = new System.Drawing.Size(26, 26);
            this.htmlEditor1.BtnAlignCenter.Text = "Align Centre";
            // 
            // htmlEditor1.BtnAlignLeft
            // 
            this.htmlEditor1.BtnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnAlignLeft.Image")));
            this.htmlEditor1.BtnAlignLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnAlignLeft.Name = "_factoryBtnAlignLeft";
            this.htmlEditor1.BtnAlignLeft.Size = new System.Drawing.Size(26, 26);
            this.htmlEditor1.BtnAlignLeft.Text = "Align Left";
            // 
            // htmlEditor1.BtnAlignRight
            // 
            this.htmlEditor1.BtnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnAlignRight.Image")));
            this.htmlEditor1.BtnAlignRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnAlignRight.Name = "_factoryBtnAlignRight";
            this.htmlEditor1.BtnAlignRight.Size = new System.Drawing.Size(26, 26);
            this.htmlEditor1.BtnAlignRight.Text = "Align Right";
            // 
            // htmlEditor1.BtnBodyStyle
            // 
            this.htmlEditor1.BtnBodyStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnBodyStyle.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnBodyStyle.Image")));
            this.htmlEditor1.BtnBodyStyle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnBodyStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnBodyStyle.Name = "_factoryBtnBodyStyle";
            this.htmlEditor1.BtnBodyStyle.Size = new System.Drawing.Size(27, 26);
            this.htmlEditor1.BtnBodyStyle.Text = "Document Style ";
            // 
            // htmlEditor1.BtnBold
            // 
            this.htmlEditor1.BtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnBold.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnBold.Image")));
            this.htmlEditor1.BtnBold.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnBold.Name = "_factoryBtnBold";
            this.htmlEditor1.BtnBold.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnBold.Text = "Bold";
            // 
            // htmlEditor1.BtnCopy
            // 
            this.htmlEditor1.BtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnCopy.Image")));
            this.htmlEditor1.BtnCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnCopy.Name = "_factoryBtnCopy";
            this.htmlEditor1.BtnCopy.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnCopy.Text = "Copy";
            // 
            // htmlEditor1.BtnCut
            // 
            this.htmlEditor1.BtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnCut.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnCut.Image")));
            this.htmlEditor1.BtnCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnCut.Name = "_factoryBtnCut";
            this.htmlEditor1.BtnCut.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnCut.Text = "Cut";
            // 
            // htmlEditor1.BtnFontColor
            // 
            this.htmlEditor1.BtnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnFontColor.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnFontColor.Image")));
            this.htmlEditor1.BtnFontColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnFontColor.Name = "_factoryBtnFontColor";
            this.htmlEditor1.BtnFontColor.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnFontColor.Text = "Apply Font Color";
            // 
            // htmlEditor1.BtnFormatRedo
            // 
            this.htmlEditor1.BtnFormatRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnFormatRedo.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnFormatRedo.Image")));
            this.htmlEditor1.BtnFormatRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnFormatRedo.Name = "_factoryBtnRedo";
            this.htmlEditor1.BtnFormatRedo.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnFormatRedo.Text = "Redo";
            // 
            // htmlEditor1.BtnFormatReset
            // 
            this.htmlEditor1.BtnFormatReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnFormatReset.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnFormatReset.Image")));
            this.htmlEditor1.BtnFormatReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnFormatReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnFormatReset.Name = "_factoryBtnFormatReset";
            this.htmlEditor1.BtnFormatReset.Size = new System.Drawing.Size(34, 26);
            this.htmlEditor1.BtnFormatReset.Text = "Remove Format";
            // 
            // htmlEditor1.BtnFormatUndo
            // 
            this.htmlEditor1.BtnFormatUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnFormatUndo.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnFormatUndo.Image")));
            this.htmlEditor1.BtnFormatUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnFormatUndo.Name = "_factoryBtnUndo";
            this.htmlEditor1.BtnFormatUndo.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnFormatUndo.Text = "Undo";
            // 
            // htmlEditor1.BtnHighlightColor
            // 
            this.htmlEditor1.BtnHighlightColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnHighlightColor.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnHighlightColor.Image")));
            this.htmlEditor1.BtnHighlightColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnHighlightColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnHighlightColor.Name = "_factoryBtnHighlightColor";
            this.htmlEditor1.BtnHighlightColor.Size = new System.Drawing.Size(27, 26);
            this.htmlEditor1.BtnHighlightColor.Text = "Apply Highlight Color";
            // 
            // htmlEditor1.BtnHorizontalRule
            // 
            this.htmlEditor1.BtnHorizontalRule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnHorizontalRule.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnHorizontalRule.Image")));
            this.htmlEditor1.BtnHorizontalRule.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnHorizontalRule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnHorizontalRule.Name = "_factoryBtnHorizontalRule";
            this.htmlEditor1.BtnHorizontalRule.Size = new System.Drawing.Size(24, 26);
            this.htmlEditor1.BtnHorizontalRule.Text = "Insert Horizontal Rule";
            // 
            // htmlEditor1.BtnHyperlink
            // 
            this.htmlEditor1.BtnHyperlink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnHyperlink.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnHyperlink.Image")));
            this.htmlEditor1.BtnHyperlink.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnHyperlink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnHyperlink.Name = "_factoryBtnHyperlink";
            this.htmlEditor1.BtnHyperlink.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnHyperlink.Text = "Hyperlink";
            // 
            // htmlEditor1.BtnImage
            // 
            this.htmlEditor1.BtnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnImage.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnImage.Image")));
            this.htmlEditor1.BtnImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnImage.Name = "_factoryBtnImage";
            this.htmlEditor1.BtnImage.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnImage.Text = "Image";
            // 
            // htmlEditor1.BtnIndent
            // 
            this.htmlEditor1.BtnIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnIndent.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnIndent.Image")));
            this.htmlEditor1.BtnIndent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnIndent.Name = "_factoryBtnIndent";
            this.htmlEditor1.BtnIndent.Size = new System.Drawing.Size(27, 26);
            this.htmlEditor1.BtnIndent.Text = "Indent";
            // 
            // htmlEditor1.BtnInsertYouTubeVideo
            // 
            this.htmlEditor1.BtnInsertYouTubeVideo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnInsertYouTubeVideo.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnInsertYouTubeVideo.Image")));
            this.htmlEditor1.BtnInsertYouTubeVideo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnInsertYouTubeVideo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnInsertYouTubeVideo.Name = "_factoryBtnInsertYouTubeVideo";
            this.htmlEditor1.BtnInsertYouTubeVideo.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnInsertYouTubeVideo.Text = "Insert YouTube Video";
            // 
            // htmlEditor1.BtnItalic
            // 
            this.htmlEditor1.BtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnItalic.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnItalic.Image")));
            this.htmlEditor1.BtnItalic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnItalic.Name = "_factoryBtnItalic";
            this.htmlEditor1.BtnItalic.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnItalic.Text = "Italic";
            // 
            // htmlEditor1.BtnNew
            // 
            this.htmlEditor1.BtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnNew.Image")));
            this.htmlEditor1.BtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnNew.Name = "_factoryBtnNew";
            this.htmlEditor1.BtnNew.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnNew.Text = "New";
            // 
            // htmlEditor1.BtnOpen
            // 
            this.htmlEditor1.BtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnOpen.Image")));
            this.htmlEditor1.BtnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnOpen.Name = "_factoryBtnOpen";
            this.htmlEditor1.BtnOpen.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnOpen.Text = "Open";
            // 
            // htmlEditor1.BtnOrderedList
            // 
            this.htmlEditor1.BtnOrderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnOrderedList.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnOrderedList.Image")));
            this.htmlEditor1.BtnOrderedList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnOrderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnOrderedList.Name = "_factoryBtnOrderedList";
            this.htmlEditor1.BtnOrderedList.Size = new System.Drawing.Size(24, 26);
            this.htmlEditor1.BtnOrderedList.Text = "Numbered List";
            // 
            // htmlEditor1.BtnOutdent
            // 
            this.htmlEditor1.BtnOutdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnOutdent.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnOutdent.Image")));
            this.htmlEditor1.BtnOutdent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnOutdent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnOutdent.Name = "_factoryBtnOutdent";
            this.htmlEditor1.BtnOutdent.Size = new System.Drawing.Size(27, 26);
            this.htmlEditor1.BtnOutdent.Text = "Outdent";
            // 
            // htmlEditor1.BtnPaste
            // 
            this.htmlEditor1.BtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnPaste.Image")));
            this.htmlEditor1.BtnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnPaste.Name = "_factoryBtnPaste";
            this.htmlEditor1.BtnPaste.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnPaste.Text = "Paste";
            // 
            // htmlEditor1.BtnPasteFromMSWord
            // 
            this.htmlEditor1.BtnPasteFromMSWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnPasteFromMSWord.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnPasteFromMSWord.Image")));
            this.htmlEditor1.BtnPasteFromMSWord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnPasteFromMSWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnPasteFromMSWord.Name = "_factoryBtnPasteFromMSWord";
            this.htmlEditor1.BtnPasteFromMSWord.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnPasteFromMSWord.Text = "Paste the Content that you Copied from MS Word";
            // 
            // htmlEditor1.BtnPrint
            // 
            this.htmlEditor1.BtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnPrint.Image")));
            this.htmlEditor1.BtnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnPrint.Name = "_factoryBtnPrint";
            this.htmlEditor1.BtnPrint.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnPrint.Text = "Print";
            // 
            // htmlEditor1.BtnSave
            // 
            this.htmlEditor1.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnSave.Image")));
            this.htmlEditor1.BtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnSave.Name = "_factoryBtnSave";
            this.htmlEditor1.BtnSave.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnSave.Text = "Save";
            // 
            // htmlEditor1.BtnSearch
            // 
            this.htmlEditor1.BtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnSearch.Image")));
            this.htmlEditor1.BtnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnSearch.Name = "_factoryBtnSearch";
            this.htmlEditor1.BtnSearch.Size = new System.Drawing.Size(24, 26);
            this.htmlEditor1.BtnSearch.Text = "Search";
            // 
            // htmlEditor1.BtnSpellCheck
            // 
            this.htmlEditor1.BtnSpellCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnSpellCheck.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnSpellCheck.Image")));
            this.htmlEditor1.BtnSpellCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnSpellCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnSpellCheck.Name = "_factoryBtnSpellCheck";
            this.htmlEditor1.BtnSpellCheck.Size = new System.Drawing.Size(26, 26);
            this.htmlEditor1.BtnSpellCheck.Text = "Check Spelling";
            // 
            // htmlEditor1.BtnStrikeThrough
            // 
            this.htmlEditor1.BtnStrikeThrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnStrikeThrough.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnStrikeThrough.Image")));
            this.htmlEditor1.BtnStrikeThrough.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnStrikeThrough.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnStrikeThrough.Name = "_factoryBtnStrikeThrough";
            this.htmlEditor1.BtnStrikeThrough.Size = new System.Drawing.Size(24, 26);
            this.htmlEditor1.BtnStrikeThrough.Text = "Strike Thru";
            // 
            // htmlEditor1.BtnSubscript
            // 
            this.htmlEditor1.BtnSubscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnSubscript.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnSubscript.Image")));
            this.htmlEditor1.BtnSubscript.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnSubscript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnSubscript.Name = "_factoryBtnSubscript";
            this.htmlEditor1.BtnSubscript.Size = new System.Drawing.Size(27, 26);
            this.htmlEditor1.BtnSubscript.Text = "Subscript";
            // 
            // htmlEditor1.BtnSuperScript
            // 
            this.htmlEditor1.BtnSuperScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnSuperScript.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnSuperScript.Image")));
            this.htmlEditor1.BtnSuperScript.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnSuperScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnSuperScript.Name = "_factoryBtnSuperScript";
            this.htmlEditor1.BtnSuperScript.Size = new System.Drawing.Size(27, 26);
            this.htmlEditor1.BtnSuperScript.Text = "Superscript";
            // 
            // htmlEditor1.BtnSymbol
            // 
            this.htmlEditor1.BtnSymbol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnSymbol.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnSymbol.Image")));
            this.htmlEditor1.BtnSymbol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnSymbol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnSymbol.Name = "_factoryBtnSymbol";
            this.htmlEditor1.BtnSymbol.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnSymbol.Text = "Insert Symbols";
            // 
            // htmlEditor1.BtnTable
            // 
            this.htmlEditor1.BtnTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnTable.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnTable.Image")));
            this.htmlEditor1.BtnTable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnTable.Name = "_factoryBtnTable";
            this.htmlEditor1.BtnTable.Size = new System.Drawing.Size(24, 26);
            this.htmlEditor1.BtnTable.Text = "Table";
            // 
            // htmlEditor1.BtnUnderline
            // 
            this.htmlEditor1.BtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnUnderline.Image")));
            this.htmlEditor1.BtnUnderline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnUnderline.Name = "_factoryBtnUnderline";
            this.htmlEditor1.BtnUnderline.Size = new System.Drawing.Size(23, 26);
            this.htmlEditor1.BtnUnderline.Text = "Underline";
            // 
            // htmlEditor1.BtnUnOrderedList
            // 
            this.htmlEditor1.BtnUnOrderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.htmlEditor1.BtnUnOrderedList.Image = ((System.Drawing.Image)(resources.GetObject("htmlEditor1.BtnUnOrderedList.Image")));
            this.htmlEditor1.BtnUnOrderedList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.htmlEditor1.BtnUnOrderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.htmlEditor1.BtnUnOrderedList.Name = "_factoryBtnUnOrderedList";
            this.htmlEditor1.BtnUnOrderedList.Size = new System.Drawing.Size(24, 26);
            this.htmlEditor1.BtnUnOrderedList.Text = "Bullet List";
            // 
            // htmlEditor1.CmbFontName
            // 
            this.htmlEditor1.CmbFontName.AddSystemFonts = true;
            this.htmlEditor1.CmbFontName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.htmlEditor1.CmbFontName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.htmlEditor1.CmbFontName.MaxDropDownItems = 17;
            this.htmlEditor1.CmbFontName.Name = "_factoryCmbFontName";
            this.htmlEditor1.CmbFontName.Size = new System.Drawing.Size(125, 29);
            this.htmlEditor1.CmbFontName.Text = "Times New Roman";
            // 
            // htmlEditor1.CmbFontSize
            // 
            this.htmlEditor1.CmbFontSize.Name = "_factoryCmbFontSize";
            this.htmlEditor1.CmbFontSize.Size = new System.Drawing.Size(75, 29);
            this.htmlEditor1.CmbFontSize.Text = "12pt";
            // 
            // htmlEditor1.CmbTitleInsert
            // 
            this.htmlEditor1.CmbTitleInsert.Name = "_factoryCmbTitleInsert";
            this.htmlEditor1.CmbTitleInsert.Size = new System.Drawing.Size(100, 29);
            this.htmlEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlEditor1.EditorContextMenuStrip = null;
            this.htmlEditor1.HeaderStyleContentElementID = "page_style";
            this.htmlEditor1.HorizontalScroll = null;
            this.htmlEditor1.Location = new System.Drawing.Point(0, 0);
            this.htmlEditor1.Name = "htmlEditor1";
            this.htmlEditor1.Options.ContinueSameStyleAfterEnterKey = true;
            this.htmlEditor1.Options.ConvertFileUrlsToLocalPaths = true;
            this.htmlEditor1.Options.CustomDOCTYPE = null;
            this.htmlEditor1.Options.FooterTagNavigatorFont = null;
            this.htmlEditor1.Options.FooterTagNavigatorTextColor = System.Drawing.Color.Teal;
            this.htmlEditor1.Options.FTPSettingsForRemoteResources.ConnectionMode = SpiceLogic.HtmlEditorControl.Domain.BOs.UserOptions.FTPSettings.ConnectionModes.Active;
            this.htmlEditor1.Options.FTPSettingsForRemoteResources.Host = null;
            this.htmlEditor1.Options.FTPSettingsForRemoteResources.Password = null;
            this.htmlEditor1.Options.FTPSettingsForRemoteResources.Port = null;
            this.htmlEditor1.Options.FTPSettingsForRemoteResources.RemoteFolderPath = null;
            this.htmlEditor1.Options.FTPSettingsForRemoteResources.Timeout = 4000;
            this.htmlEditor1.Options.FTPSettingsForRemoteResources.UrlOfTheRemoteFolderPath = null;
            this.htmlEditor1.Options.FTPSettingsForRemoteResources.UserName = null;
            this.htmlEditor1.Options.PasteImageFromClipboardBehavior = SpiceLogic.HtmlEditorControl.Domain.BOs.UserOptions.UserOption.ImageStorage.Base64;
            this.htmlEditor1.Size = new System.Drawing.Size(1015, 600);
            this.htmlEditor1.SpellCheckOptions.CurlyUnderlineImageFilePath = null;
            dictionaryFileInfo1.AffixFilePath = null;
            dictionaryFileInfo1.DictionaryFilePath = null;
            dictionaryFileInfo1.EnableUserDictionary = true;
            dictionaryFileInfo1.UserDictionaryFilePath = null;
            this.htmlEditor1.SpellCheckOptions.DictionaryFile = dictionaryFileInfo1;
            this.htmlEditor1.SpellCheckOptions.FireInlineSpellCheckingOnKeyStroke = true;
            this.htmlEditor1.SpellCheckOptions.NHunspellDllFolderPath = null;
            this.htmlEditor1.SpellCheckOptions.WaitAlertMessage = "Searching next misspelled word..... (please wait)";
            this.htmlEditor1.TabIndex = 8;
            // 
            // htmlEditor1.TlstrpSeparator1
            // 
            this.htmlEditor1.TlstrpSeparator1.Name = "_toolStripSeparator1";
            this.htmlEditor1.TlstrpSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // htmlEditor1.TlstrpSeparator2
            // 
            this.htmlEditor1.TlstrpSeparator2.Name = "_toolStripSeparator2";
            this.htmlEditor1.TlstrpSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // htmlEditor1.TlstrpSeparator3
            // 
            this.htmlEditor1.TlstrpSeparator3.Name = "_toolStripSeparator3";
            this.htmlEditor1.TlstrpSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // htmlEditor1.TlstrpSeparator4
            // 
            this.htmlEditor1.TlstrpSeparator4.Name = "_toolStripSeparator4";
            this.htmlEditor1.TlstrpSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // htmlEditor1.TlstrpSeparator5
            // 
            this.htmlEditor1.TlstrpSeparator5.Name = "_toolStripSeparator5";
            this.htmlEditor1.TlstrpSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // htmlEditor1.TlstrpSeparator6
            // 
            this.htmlEditor1.TlstrpSeparator6.Name = "_toolStripSeparator6";
            this.htmlEditor1.TlstrpSeparator6.Size = new System.Drawing.Size(6, 29);
            // 
            // htmlEditor1.TlstrpSeparator7
            // 
            this.htmlEditor1.TlstrpSeparator7.Name = "_toolStripSeparator7";
            this.htmlEditor1.TlstrpSeparator7.Size = new System.Drawing.Size(6, 29);
            // 
            // htmlEditor1.TlstrpSeparator8
            // 
            this.htmlEditor1.TlstrpSeparator8.Name = "_toolStripSeparator8";
            this.htmlEditor1.TlstrpSeparator8.Size = new System.Drawing.Size(6, 29);
            // 
            // htmlEditor1.TlstrpSeparator9
            // 
            this.htmlEditor1.TlstrpSeparator9.Name = "_toolStripSeparator9";
            this.htmlEditor1.TlstrpSeparator9.Size = new System.Drawing.Size(6, 29);
            // 
            // htmlEditor1.WinFormHtmlEditor_Toolbar1
            // 
            this.htmlEditor1.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.htmlEditor1.BtnNew,
            this.htmlEditor1.BtnOpen,
            this.htmlEditor1.BtnSave,
            this.htmlEditor1.BtnPrint,
            this.BtnPageSetup,
            this.BtnPreview,
            this.htmlEditor1.TlstrpSeparator1,
            this.htmlEditor1.CmbFontName,
            this.htmlEditor1.CmbFontSize,
            this.htmlEditor1.TlstrpSeparator2,
            this.htmlEditor1.BtnCut,
            this.htmlEditor1.BtnCopy,
            this.htmlEditor1.BtnPaste,
            this.htmlEditor1.BtnPasteFromMSWord,
            this.htmlEditor1.TlstrpSeparator3,
            this.htmlEditor1.BtnBold,
            this.htmlEditor1.BtnItalic,
            this.htmlEditor1.BtnUnderline,
            this.htmlEditor1.TlstrpSeparator4,
            this.htmlEditor1.BtnFormatReset,
            this.htmlEditor1.BtnFormatUndo,
            this.htmlEditor1.BtnFormatRedo,
            this.htmlEditor1.BtnSpellCheck,
            this.htmlEditor1.BtnSearch});
            this.htmlEditor1.Toolbar1.Location = new System.Drawing.Point(0, 0);
            this.htmlEditor1.Toolbar1.Name = "WinFormHtmlEditor_Toolbar1";
            this.htmlEditor1.Toolbar1.Size = new System.Drawing.Size(1015, 29);
            this.htmlEditor1.Toolbar1.TabIndex = 0;
            // 
            // htmlEditor1.WinFormHtmlEditor_Toolbar2
            // 
            this.htmlEditor1.Toolbar2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.htmlEditor1.CmbTitleInsert,
            this.htmlEditor1.BtnHighlightColor,
            this.htmlEditor1.BtnFontColor,
            this.htmlEditor1.TlstrpSeparator5,
            this.htmlEditor1.BtnHyperlink,
            this.htmlEditor1.BtnImage,
            this.htmlEditor1.BtnInsertYouTubeVideo,
            this.htmlEditor1.BtnTable,
            this.htmlEditor1.BtnSymbol,
            this.htmlEditor1.BtnHorizontalRule,
            this.htmlEditor1.TlstrpSeparator6,
            this.htmlEditor1.BtnOrderedList,
            this.htmlEditor1.BtnUnOrderedList,
            this.htmlEditor1.TlstrpSeparator7,
            this.htmlEditor1.BtnAlignLeft,
            this.htmlEditor1.BtnAlignCenter,
            this.htmlEditor1.BtnAlignRight,
            this.htmlEditor1.TlstrpSeparator8,
            this.htmlEditor1.BtnOutdent,
            this.htmlEditor1.BtnIndent,
            this.htmlEditor1.TlstrpSeparator9,
            this.htmlEditor1.BtnStrikeThrough,
            this.htmlEditor1.BtnSuperScript,
            this.htmlEditor1.BtnSubscript,
            this.htmlEditor1.BtnBodyStyle});
            this.htmlEditor1.Toolbar2.Location = new System.Drawing.Point(0, 29);
            this.htmlEditor1.Toolbar2.Name = "WinFormHtmlEditor_Toolbar2";
            this.htmlEditor1.Toolbar2.Size = new System.Drawing.Size(1015, 29);
            this.htmlEditor1.Toolbar2.TabIndex = 0;
            this.htmlEditor1.ToolbarContextMenuStrip = null;
            // 
            // htmlEditor1.WinFormHtmlEditor_ToolbarFooter
            // 
            this.htmlEditor1.ToolbarFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.htmlEditor1.ToolbarFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslWordCount});
            this.htmlEditor1.ToolbarFooter.Location = new System.Drawing.Point(0, 575);
            this.htmlEditor1.ToolbarFooter.Name = "WinFormHtmlEditor_ToolbarFooter";
            this.htmlEditor1.ToolbarFooter.Size = new System.Drawing.Size(1015, 25);
            this.htmlEditor1.ToolbarFooter.TabIndex = 7;
            this.htmlEditor1.VerticalScroll = null;
            this.htmlEditor1.z__ignore = true;
            this.htmlEditor1.KeyUp += new System.EventHandler<SpiceLogic.HtmlEditorControl.Domain.BOs.EditorEventArgs.EditorKeyEventArgs>(this.htmlEditor1_KeyUp);
            // 
            // BtnPageSetup
            // 
            this.BtnPageSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPageSetup.Image = global::RIS.Properties.Resources.pagesetup;
            this.BtnPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPageSetup.Name = "BtnPageSetup";
            this.BtnPageSetup.Size = new System.Drawing.Size(23, 26);
            this.BtnPageSetup.Text = "toolStripButton2";
            this.BtnPageSetup.Click += new System.EventHandler(this.BtnPageSetup_Click);
            // 
            // BtnPreview
            // 
            this.BtnPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPreview.Image = global::RIS.Properties.Resources.Preview1;
            this.BtnPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(23, 26);
            this.BtnPreview.Text = "toolStripButton1";
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // tsslWordCount
            // 
            this.tsslWordCount.Name = "tsslWordCount";
            this.tsslWordCount.Size = new System.Drawing.Size(40, 20);
            this.tsslWordCount.Text = "Count";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(12, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "Create Shortcut Key";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCreateTemplate
            // 
            this.btnCreateTemplate.BackColor = System.Drawing.Color.Green;
            this.btnCreateTemplate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTemplate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateTemplate.Location = new System.Drawing.Point(9, 201);
            this.btnCreateTemplate.Name = "btnCreateTemplate";
            this.btnCreateTemplate.Size = new System.Drawing.Size(247, 33);
            this.btnCreateTemplate.TabIndex = 4;
            this.btnCreateTemplate.Text = "Create Template";
            this.btnCreateTemplate.UseVisualStyleBackColor = false;
            this.btnCreateTemplate.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(7, -100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save to MS-Word document";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPDF);
            this.panel2.Controls.Add(this.btnWord);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.btnReportComplete);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbSelectTemplate);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnCreateTemplate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1015, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 600);
            this.panel2.TabIndex = 3;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPDF.BackgroundImage = global::RIS.Properties.Resources.pdf_icon31;
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPDF.Location = new System.Drawing.Point(139, 369);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(66, 61);
            this.btnPDF.TabIndex = 14;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnWord
            // 
            this.btnWord.BackgroundImage = global::RIS.Properties.Resources.w2_icon_2;
            this.btnWord.Location = new System.Drawing.Point(41, 369);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(66, 61);
            this.btnWord.TabIndex = 13;
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.91667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.08334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 479);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 121);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RIS.Properties.Resources.logo_emedical;
            this.pictureBox1.Location = new System.Drawing.Point(27, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 112);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnReportComplete
            // 
            this.btnReportComplete.BackgroundImage = global::RIS.Properties.Resources.btnReportDone;
            this.btnReportComplete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnReportComplete.FlatAppearance.BorderSize = 0;
            this.btnReportComplete.Location = new System.Drawing.Point(41, 12);
            this.btnReportComplete.Name = "btnReportComplete";
            this.btnReportComplete.Size = new System.Drawing.Size(164, 105);
            this.btnReportComplete.TabIndex = 9;
            this.btnReportComplete.UseVisualStyleBackColor = true;
            this.btnReportComplete.Click += new System.EventHandler(this.btnReportComplete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Template";
            // 
            // cmbSelectTemplate
            // 
            this.cmbSelectTemplate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSelectTemplate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSelectTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectTemplate.FormattingEnabled = true;
            this.cmbSelectTemplate.Location = new System.Drawing.Point(12, 154);
            this.cmbSelectTemplate.Name = "cmbSelectTemplate";
            this.cmbSelectTemplate.Size = new System.Drawing.Size(232, 26);
            this.cmbSelectTemplate.TabIndex = 6;
            this.cmbSelectTemplate.SelectedIndexChanged += new System.EventHandler(this.cmbSelectTemplate_SelectedIndexChanged);
            // 
            // frmHtmlReportV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHtmlReportV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EMSL-Word Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.htmlEditor1.Toolbar1.ResumeLayout(false);
            this.htmlEditor1.Toolbar1.PerformLayout();
            this.htmlEditor1.Toolbar2.ResumeLayout(false);
            this.htmlEditor1.Toolbar2.PerformLayout();
            this.htmlEditor1.ResumeLayout(false);
            this.htmlEditor1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateTemplate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelectTemplate;
       
        private System.Windows.Forms.Button btnReportComplete;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnWord;
        private SpiceLogic.WinHTMLEditor.WinForm.WinFormHtmlEditor htmlEditor1;
        
        private System.Windows.Forms.ToolStripButton BtnPreview;
        private System.Windows.Forms.ToolStripButton BtnPageSetup;
        private System.Windows.Forms.ToolStripStatusLabel tsslWordCount;
    }
}

