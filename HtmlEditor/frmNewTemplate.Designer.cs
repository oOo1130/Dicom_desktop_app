
namespace RIS.HtmlEditor
{
    partial class frmNewTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTemplate));
            SpiceLogic.HtmlEditorControl.Domain.DesignTime.DictionaryFileInfo dictionaryFileInfo1 = new SpiceLogic.HtmlEditorControl.Domain.DesignTime.DictionaryFileInfo();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HtmlEditor1 = new SpiceLogic.WinHTMLEditor.WinForm.WinFormHtmlEditor();
            this.btnClearContent = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.HtmlEditor1.Toolbar1.SuspendLayout();
            this.HtmlEditor1.Toolbar2.SuspendLayout();
            this.HtmlEditor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemplateName.Location = new System.Drawing.Point(134, 34);
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Size = new System.Drawing.Size(385, 25);
            this.txtTemplateName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Template Name";
            // 
            // HtmlEditor1
            // 
            this.HtmlEditor1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.HtmlEditor1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.HtmlEditor1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // 
            // HtmlEditor1.BtnAlignCenter
            // 
            this.HtmlEditor1.BtnAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnAlignCenter.Image")));
            this.HtmlEditor1.BtnAlignCenter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnAlignCenter.Name = "_factoryBtnAlignCenter";
            this.HtmlEditor1.BtnAlignCenter.Size = new System.Drawing.Size(26, 26);
            this.HtmlEditor1.BtnAlignCenter.Text = "Align Centre";
            // 
            // HtmlEditor1.BtnAlignLeft
            // 
            this.HtmlEditor1.BtnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnAlignLeft.Image")));
            this.HtmlEditor1.BtnAlignLeft.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnAlignLeft.Name = "_factoryBtnAlignLeft";
            this.HtmlEditor1.BtnAlignLeft.Size = new System.Drawing.Size(26, 26);
            this.HtmlEditor1.BtnAlignLeft.Text = "Align Left";
            // 
            // HtmlEditor1.BtnAlignRight
            // 
            this.HtmlEditor1.BtnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnAlignRight.Image")));
            this.HtmlEditor1.BtnAlignRight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnAlignRight.Name = "_factoryBtnAlignRight";
            this.HtmlEditor1.BtnAlignRight.Size = new System.Drawing.Size(26, 26);
            this.HtmlEditor1.BtnAlignRight.Text = "Align Right";
            // 
            // HtmlEditor1.BtnBodyStyle
            // 
            this.HtmlEditor1.BtnBodyStyle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnBodyStyle.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnBodyStyle.Image")));
            this.HtmlEditor1.BtnBodyStyle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnBodyStyle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnBodyStyle.Name = "_factoryBtnBodyStyle";
            this.HtmlEditor1.BtnBodyStyle.Size = new System.Drawing.Size(27, 26);
            this.HtmlEditor1.BtnBodyStyle.Text = "Document Style ";
            // 
            // HtmlEditor1.BtnBold
            // 
            this.HtmlEditor1.BtnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnBold.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnBold.Image")));
            this.HtmlEditor1.BtnBold.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnBold.Name = "_factoryBtnBold";
            this.HtmlEditor1.BtnBold.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnBold.Text = "Bold";
            // 
            // HtmlEditor1.BtnCopy
            // 
            this.HtmlEditor1.BtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnCopy.Image")));
            this.HtmlEditor1.BtnCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnCopy.Name = "_factoryBtnCopy";
            this.HtmlEditor1.BtnCopy.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnCopy.Text = "Copy";
            // 
            // HtmlEditor1.BtnCut
            // 
            this.HtmlEditor1.BtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnCut.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnCut.Image")));
            this.HtmlEditor1.BtnCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnCut.Name = "_factoryBtnCut";
            this.HtmlEditor1.BtnCut.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnCut.Text = "Cut";
            // 
            // HtmlEditor1.BtnFontColor
            // 
            this.HtmlEditor1.BtnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnFontColor.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnFontColor.Image")));
            this.HtmlEditor1.BtnFontColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnFontColor.Name = "_factoryBtnFontColor";
            this.HtmlEditor1.BtnFontColor.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnFontColor.Text = "Apply Font Color";
            // 
            // HtmlEditor1.BtnFormatRedo
            // 
            this.HtmlEditor1.BtnFormatRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnFormatRedo.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnFormatRedo.Image")));
            this.HtmlEditor1.BtnFormatRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnFormatRedo.Name = "_factoryBtnRedo";
            this.HtmlEditor1.BtnFormatRedo.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnFormatRedo.Text = "Redo";
            // 
            // HtmlEditor1.BtnFormatReset
            // 
            this.HtmlEditor1.BtnFormatReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnFormatReset.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnFormatReset.Image")));
            this.HtmlEditor1.BtnFormatReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnFormatReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnFormatReset.Name = "_factoryBtnFormatReset";
            this.HtmlEditor1.BtnFormatReset.Size = new System.Drawing.Size(34, 26);
            this.HtmlEditor1.BtnFormatReset.Text = "Remove Format";
            // 
            // HtmlEditor1.BtnFormatUndo
            // 
            this.HtmlEditor1.BtnFormatUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnFormatUndo.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnFormatUndo.Image")));
            this.HtmlEditor1.BtnFormatUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnFormatUndo.Name = "_factoryBtnUndo";
            this.HtmlEditor1.BtnFormatUndo.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnFormatUndo.Text = "Undo";
            // 
            // HtmlEditor1.BtnHighlightColor
            // 
            this.HtmlEditor1.BtnHighlightColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnHighlightColor.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnHighlightColor.Image")));
            this.HtmlEditor1.BtnHighlightColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnHighlightColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnHighlightColor.Name = "_factoryBtnHighlightColor";
            this.HtmlEditor1.BtnHighlightColor.Size = new System.Drawing.Size(27, 26);
            this.HtmlEditor1.BtnHighlightColor.Text = "Apply Highlight Color";
            // 
            // HtmlEditor1.BtnHorizontalRule
            // 
            this.HtmlEditor1.BtnHorizontalRule.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnHorizontalRule.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnHorizontalRule.Image")));
            this.HtmlEditor1.BtnHorizontalRule.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnHorizontalRule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnHorizontalRule.Name = "_factoryBtnHorizontalRule";
            this.HtmlEditor1.BtnHorizontalRule.Size = new System.Drawing.Size(24, 26);
            this.HtmlEditor1.BtnHorizontalRule.Text = "Insert Horizontal Rule";
            // 
            // HtmlEditor1.BtnHyperlink
            // 
            this.HtmlEditor1.BtnHyperlink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnHyperlink.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnHyperlink.Image")));
            this.HtmlEditor1.BtnHyperlink.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnHyperlink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnHyperlink.Name = "_factoryBtnHyperlink";
            this.HtmlEditor1.BtnHyperlink.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnHyperlink.Text = "Hyperlink";
            // 
            // HtmlEditor1.BtnImage
            // 
            this.HtmlEditor1.BtnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnImage.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnImage.Image")));
            this.HtmlEditor1.BtnImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnImage.Name = "_factoryBtnImage";
            this.HtmlEditor1.BtnImage.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnImage.Text = "Image";
            // 
            // HtmlEditor1.BtnIndent
            // 
            this.HtmlEditor1.BtnIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnIndent.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnIndent.Image")));
            this.HtmlEditor1.BtnIndent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnIndent.Name = "_factoryBtnIndent";
            this.HtmlEditor1.BtnIndent.Size = new System.Drawing.Size(27, 26);
            this.HtmlEditor1.BtnIndent.Text = "Indent";
            // 
            // HtmlEditor1.BtnInsertYouTubeVideo
            // 
            this.HtmlEditor1.BtnInsertYouTubeVideo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnInsertYouTubeVideo.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnInsertYouTubeVideo.Image")));
            this.HtmlEditor1.BtnInsertYouTubeVideo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnInsertYouTubeVideo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnInsertYouTubeVideo.Name = "_factoryBtnInsertYouTubeVideo";
            this.HtmlEditor1.BtnInsertYouTubeVideo.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnInsertYouTubeVideo.Text = "Insert YouTube Video";
            // 
            // HtmlEditor1.BtnItalic
            // 
            this.HtmlEditor1.BtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnItalic.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnItalic.Image")));
            this.HtmlEditor1.BtnItalic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnItalic.Name = "_factoryBtnItalic";
            this.HtmlEditor1.BtnItalic.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnItalic.Text = "Italic";
            // 
            // HtmlEditor1.BtnNew
            // 
            this.HtmlEditor1.BtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnNew.Image")));
            this.HtmlEditor1.BtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnNew.Name = "_factoryBtnNew";
            this.HtmlEditor1.BtnNew.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnNew.Text = "New";
            // 
            // HtmlEditor1.BtnOpen
            // 
            this.HtmlEditor1.BtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnOpen.Image")));
            this.HtmlEditor1.BtnOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnOpen.Name = "_factoryBtnOpen";
            this.HtmlEditor1.BtnOpen.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnOpen.Text = "Open";
            // 
            // HtmlEditor1.BtnOrderedList
            // 
            this.HtmlEditor1.BtnOrderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnOrderedList.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnOrderedList.Image")));
            this.HtmlEditor1.BtnOrderedList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnOrderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnOrderedList.Name = "_factoryBtnOrderedList";
            this.HtmlEditor1.BtnOrderedList.Size = new System.Drawing.Size(24, 26);
            this.HtmlEditor1.BtnOrderedList.Text = "Numbered List";
            // 
            // HtmlEditor1.BtnOutdent
            // 
            this.HtmlEditor1.BtnOutdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnOutdent.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnOutdent.Image")));
            this.HtmlEditor1.BtnOutdent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnOutdent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnOutdent.Name = "_factoryBtnOutdent";
            this.HtmlEditor1.BtnOutdent.Size = new System.Drawing.Size(27, 26);
            this.HtmlEditor1.BtnOutdent.Text = "Outdent";
            // 
            // HtmlEditor1.BtnPaste
            // 
            this.HtmlEditor1.BtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnPaste.Image")));
            this.HtmlEditor1.BtnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnPaste.Name = "_factoryBtnPaste";
            this.HtmlEditor1.BtnPaste.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnPaste.Text = "Paste";
            // 
            // HtmlEditor1.BtnPasteFromMSWord
            // 
            this.HtmlEditor1.BtnPasteFromMSWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnPasteFromMSWord.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnPasteFromMSWord.Image")));
            this.HtmlEditor1.BtnPasteFromMSWord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnPasteFromMSWord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnPasteFromMSWord.Name = "_factoryBtnPasteFromMSWord";
            this.HtmlEditor1.BtnPasteFromMSWord.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnPasteFromMSWord.Text = "Paste the Content that you Copied from MS Word";
            // 
            // HtmlEditor1.BtnPrint
            // 
            this.HtmlEditor1.BtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnPrint.Image")));
            this.HtmlEditor1.BtnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnPrint.Name = "_factoryBtnPrint";
            this.HtmlEditor1.BtnPrint.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnPrint.Text = "Print";
            // 
            // HtmlEditor1.BtnSave
            // 
            this.HtmlEditor1.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnSave.Image")));
            this.HtmlEditor1.BtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnSave.Name = "_factoryBtnSave";
            this.HtmlEditor1.BtnSave.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnSave.Text = "Save";
            // 
            // HtmlEditor1.BtnSearch
            // 
            this.HtmlEditor1.BtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnSearch.Image")));
            this.HtmlEditor1.BtnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnSearch.Name = "_factoryBtnSearch";
            this.HtmlEditor1.BtnSearch.Size = new System.Drawing.Size(24, 26);
            this.HtmlEditor1.BtnSearch.Text = "Search";
            // 
            // HtmlEditor1.BtnSpellCheck
            // 
            this.HtmlEditor1.BtnSpellCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnSpellCheck.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnSpellCheck.Image")));
            this.HtmlEditor1.BtnSpellCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnSpellCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnSpellCheck.Name = "_factoryBtnSpellCheck";
            this.HtmlEditor1.BtnSpellCheck.Size = new System.Drawing.Size(26, 26);
            this.HtmlEditor1.BtnSpellCheck.Text = "Check Spelling";
            // 
            // HtmlEditor1.BtnStrikeThrough
            // 
            this.HtmlEditor1.BtnStrikeThrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnStrikeThrough.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnStrikeThrough.Image")));
            this.HtmlEditor1.BtnStrikeThrough.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnStrikeThrough.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnStrikeThrough.Name = "_factoryBtnStrikeThrough";
            this.HtmlEditor1.BtnStrikeThrough.Size = new System.Drawing.Size(24, 26);
            this.HtmlEditor1.BtnStrikeThrough.Text = "Strike Thru";
            // 
            // HtmlEditor1.BtnSubscript
            // 
            this.HtmlEditor1.BtnSubscript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnSubscript.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnSubscript.Image")));
            this.HtmlEditor1.BtnSubscript.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnSubscript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnSubscript.Name = "_factoryBtnSubscript";
            this.HtmlEditor1.BtnSubscript.Size = new System.Drawing.Size(27, 26);
            this.HtmlEditor1.BtnSubscript.Text = "Subscript";
            // 
            // HtmlEditor1.BtnSuperScript
            // 
            this.HtmlEditor1.BtnSuperScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnSuperScript.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnSuperScript.Image")));
            this.HtmlEditor1.BtnSuperScript.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnSuperScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnSuperScript.Name = "_factoryBtnSuperScript";
            this.HtmlEditor1.BtnSuperScript.Size = new System.Drawing.Size(27, 26);
            this.HtmlEditor1.BtnSuperScript.Text = "Superscript";
            // 
            // HtmlEditor1.BtnSymbol
            // 
            this.HtmlEditor1.BtnSymbol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnSymbol.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnSymbol.Image")));
            this.HtmlEditor1.BtnSymbol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnSymbol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnSymbol.Name = "_factoryBtnSymbol";
            this.HtmlEditor1.BtnSymbol.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnSymbol.Text = "Insert Symbols";
            // 
            // HtmlEditor1.BtnTable
            // 
            this.HtmlEditor1.BtnTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnTable.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnTable.Image")));
            this.HtmlEditor1.BtnTable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnTable.Name = "_factoryBtnTable";
            this.HtmlEditor1.BtnTable.Size = new System.Drawing.Size(24, 26);
            this.HtmlEditor1.BtnTable.Text = "Table";
            // 
            // HtmlEditor1.BtnUnderline
            // 
            this.HtmlEditor1.BtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnUnderline.Image")));
            this.HtmlEditor1.BtnUnderline.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnUnderline.Name = "_factoryBtnUnderline";
            this.HtmlEditor1.BtnUnderline.Size = new System.Drawing.Size(23, 26);
            this.HtmlEditor1.BtnUnderline.Text = "Underline";
            // 
            // HtmlEditor1.BtnUnOrderedList
            // 
            this.HtmlEditor1.BtnUnOrderedList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HtmlEditor1.BtnUnOrderedList.Image = ((System.Drawing.Image)(resources.GetObject("HtmlEditor1.BtnUnOrderedList.Image")));
            this.HtmlEditor1.BtnUnOrderedList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HtmlEditor1.BtnUnOrderedList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HtmlEditor1.BtnUnOrderedList.Name = "_factoryBtnUnOrderedList";
            this.HtmlEditor1.BtnUnOrderedList.Size = new System.Drawing.Size(24, 26);
            this.HtmlEditor1.BtnUnOrderedList.Text = "Bullet List";
            // 
            // HtmlEditor1.CmbFontName
            // 
            this.HtmlEditor1.CmbFontName.AddSystemFonts = true;
            this.HtmlEditor1.CmbFontName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.HtmlEditor1.CmbFontName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.HtmlEditor1.CmbFontName.MaxDropDownItems = 17;
            this.HtmlEditor1.CmbFontName.Name = "_factoryCmbFontName";
            this.HtmlEditor1.CmbFontName.Size = new System.Drawing.Size(125, 29);
            this.HtmlEditor1.CmbFontName.Text = "Times New Roman";
            // 
            // HtmlEditor1.CmbFontSize
            // 
            this.HtmlEditor1.CmbFontSize.Name = "_factoryCmbFontSize";
            this.HtmlEditor1.CmbFontSize.Size = new System.Drawing.Size(75, 29);
            this.HtmlEditor1.CmbFontSize.Text = "12pt";
            // 
            // HtmlEditor1.CmbTitleInsert
            // 
            this.HtmlEditor1.CmbTitleInsert.Name = "_factoryCmbTitleInsert";
            this.HtmlEditor1.CmbTitleInsert.Size = new System.Drawing.Size(100, 29);
            this.HtmlEditor1.EditorContextMenuStrip = null;
            this.HtmlEditor1.HeaderStyleContentElementID = "page_style";
            this.HtmlEditor1.HorizontalScroll = null;
            this.HtmlEditor1.Location = new System.Drawing.Point(23, 75);
            this.HtmlEditor1.Name = "HtmlEditor1";
            this.HtmlEditor1.Options.ContinueSameStyleAfterEnterKey = true;
            this.HtmlEditor1.Options.ConvertFileUrlsToLocalPaths = true;
            this.HtmlEditor1.Options.CustomDOCTYPE = null;
            this.HtmlEditor1.Options.FooterTagNavigatorFont = null;
            this.HtmlEditor1.Options.FooterTagNavigatorTextColor = System.Drawing.Color.Teal;
            this.HtmlEditor1.Options.FTPSettingsForRemoteResources.ConnectionMode = SpiceLogic.HtmlEditorControl.Domain.BOs.UserOptions.FTPSettings.ConnectionModes.Active;
            this.HtmlEditor1.Options.FTPSettingsForRemoteResources.Host = null;
            this.HtmlEditor1.Options.FTPSettingsForRemoteResources.Password = null;
            this.HtmlEditor1.Options.FTPSettingsForRemoteResources.Port = null;
            this.HtmlEditor1.Options.FTPSettingsForRemoteResources.RemoteFolderPath = null;
            this.HtmlEditor1.Options.FTPSettingsForRemoteResources.Timeout = 4000;
            this.HtmlEditor1.Options.FTPSettingsForRemoteResources.UrlOfTheRemoteFolderPath = null;
            this.HtmlEditor1.Options.FTPSettingsForRemoteResources.UserName = null;
            this.HtmlEditor1.Options.PasteImageFromClipboardBehavior = SpiceLogic.HtmlEditorControl.Domain.BOs.UserOptions.UserOption.ImageStorage.Base64;
            this.HtmlEditor1.Size = new System.Drawing.Size(680, 470);
            this.HtmlEditor1.SpellCheckOptions.CurlyUnderlineImageFilePath = null;
            dictionaryFileInfo1.AffixFilePath = null;
            dictionaryFileInfo1.DictionaryFilePath = null;
            dictionaryFileInfo1.EnableUserDictionary = true;
            dictionaryFileInfo1.UserDictionaryFilePath = null;
            this.HtmlEditor1.SpellCheckOptions.DictionaryFile = dictionaryFileInfo1;
            this.HtmlEditor1.SpellCheckOptions.FireInlineSpellCheckingOnKeyStroke = true;
            this.HtmlEditor1.SpellCheckOptions.NHunspellDllFolderPath = null;
            this.HtmlEditor1.SpellCheckOptions.WaitAlertMessage = "Searching next misspelled word..... (please wait)";
            this.HtmlEditor1.TabIndex = 2;
            // 
            // HtmlEditor1.TlstrpSeparator1
            // 
            this.HtmlEditor1.TlstrpSeparator1.Name = "_toolStripSeparator1";
            this.HtmlEditor1.TlstrpSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // HtmlEditor1.TlstrpSeparator2
            // 
            this.HtmlEditor1.TlstrpSeparator2.Name = "_toolStripSeparator2";
            this.HtmlEditor1.TlstrpSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // HtmlEditor1.TlstrpSeparator3
            // 
            this.HtmlEditor1.TlstrpSeparator3.Name = "_toolStripSeparator3";
            this.HtmlEditor1.TlstrpSeparator3.Size = new System.Drawing.Size(6, 29);
            // 
            // HtmlEditor1.TlstrpSeparator4
            // 
            this.HtmlEditor1.TlstrpSeparator4.Name = "_toolStripSeparator4";
            this.HtmlEditor1.TlstrpSeparator4.Size = new System.Drawing.Size(6, 29);
            // 
            // HtmlEditor1.TlstrpSeparator5
            // 
            this.HtmlEditor1.TlstrpSeparator5.Name = "_toolStripSeparator5";
            this.HtmlEditor1.TlstrpSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // HtmlEditor1.TlstrpSeparator6
            // 
            this.HtmlEditor1.TlstrpSeparator6.Name = "_toolStripSeparator6";
            this.HtmlEditor1.TlstrpSeparator6.Size = new System.Drawing.Size(6, 29);
            // 
            // HtmlEditor1.TlstrpSeparator7
            // 
            this.HtmlEditor1.TlstrpSeparator7.Name = "_toolStripSeparator7";
            this.HtmlEditor1.TlstrpSeparator7.Size = new System.Drawing.Size(6, 29);
            // 
            // HtmlEditor1.TlstrpSeparator8
            // 
            this.HtmlEditor1.TlstrpSeparator8.Name = "_toolStripSeparator8";
            this.HtmlEditor1.TlstrpSeparator8.Size = new System.Drawing.Size(6, 29);
            // 
            // HtmlEditor1.TlstrpSeparator9
            // 
            this.HtmlEditor1.TlstrpSeparator9.Name = "_toolStripSeparator9";
            this.HtmlEditor1.TlstrpSeparator9.Size = new System.Drawing.Size(6, 29);
            // 
            // HtmlEditor1.WinFormHtmlEditor_Toolbar1
            // 
            this.HtmlEditor1.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HtmlEditor1.BtnNew,
            this.HtmlEditor1.BtnOpen,
            this.HtmlEditor1.BtnSave,
            this.HtmlEditor1.TlstrpSeparator1,
            this.HtmlEditor1.CmbFontName,
            this.HtmlEditor1.CmbFontSize,
            this.HtmlEditor1.TlstrpSeparator2,
            this.HtmlEditor1.BtnCut,
            this.HtmlEditor1.BtnCopy,
            this.HtmlEditor1.BtnPaste,
            this.HtmlEditor1.BtnPasteFromMSWord,
            this.HtmlEditor1.TlstrpSeparator3,
            this.HtmlEditor1.BtnBold,
            this.HtmlEditor1.BtnItalic,
            this.HtmlEditor1.BtnUnderline,
            this.HtmlEditor1.TlstrpSeparator4,
            this.HtmlEditor1.BtnFormatReset,
            this.HtmlEditor1.BtnFormatUndo,
            this.HtmlEditor1.BtnFormatRedo,
            this.HtmlEditor1.BtnPrint,
            this.HtmlEditor1.BtnSpellCheck,
            this.HtmlEditor1.BtnSearch});
            this.HtmlEditor1.Toolbar1.Location = new System.Drawing.Point(0, 0);
            this.HtmlEditor1.Toolbar1.Name = "WinFormHtmlEditor_Toolbar1";
            this.HtmlEditor1.Toolbar1.Size = new System.Drawing.Size(680, 29);
            this.HtmlEditor1.Toolbar1.TabIndex = 0;
            // 
            // HtmlEditor1.WinFormHtmlEditor_Toolbar2
            // 
            this.HtmlEditor1.Toolbar2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HtmlEditor1.CmbTitleInsert,
            this.HtmlEditor1.BtnHighlightColor,
            this.HtmlEditor1.BtnFontColor,
            this.HtmlEditor1.TlstrpSeparator5,
            this.HtmlEditor1.BtnHyperlink,
            this.HtmlEditor1.BtnImage,
            this.HtmlEditor1.BtnInsertYouTubeVideo,
            this.HtmlEditor1.BtnTable,
            this.HtmlEditor1.BtnSymbol,
            this.HtmlEditor1.BtnHorizontalRule,
            this.HtmlEditor1.TlstrpSeparator6,
            this.HtmlEditor1.BtnOrderedList,
            this.HtmlEditor1.BtnUnOrderedList,
            this.HtmlEditor1.TlstrpSeparator7,
            this.HtmlEditor1.BtnAlignLeft,
            this.HtmlEditor1.BtnAlignCenter,
            this.HtmlEditor1.BtnAlignRight,
            this.HtmlEditor1.TlstrpSeparator8,
            this.HtmlEditor1.BtnOutdent,
            this.HtmlEditor1.BtnIndent,
            this.HtmlEditor1.TlstrpSeparator9,
            this.HtmlEditor1.BtnStrikeThrough,
            this.HtmlEditor1.BtnSuperScript,
            this.HtmlEditor1.BtnSubscript,
            this.HtmlEditor1.BtnBodyStyle});
            this.HtmlEditor1.Toolbar2.Location = new System.Drawing.Point(0, 29);
            this.HtmlEditor1.Toolbar2.Name = "WinFormHtmlEditor_Toolbar2";
            this.HtmlEditor1.Toolbar2.Size = new System.Drawing.Size(680, 29);
            this.HtmlEditor1.Toolbar2.TabIndex = 0;
            this.HtmlEditor1.ToolbarContextMenuStrip = null;
            // 
            // HtmlEditor1.WinFormHtmlEditor_ToolbarFooter
            // 
            this.HtmlEditor1.ToolbarFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HtmlEditor1.ToolbarFooter.Location = new System.Drawing.Point(0, 445);
            this.HtmlEditor1.ToolbarFooter.Name = "WinFormHtmlEditor_ToolbarFooter";
            this.HtmlEditor1.ToolbarFooter.Size = new System.Drawing.Size(680, 25);
            this.HtmlEditor1.ToolbarFooter.TabIndex = 7;
            this.HtmlEditor1.VerticalScroll = null;
            this.HtmlEditor1.z__ignore = true;
            // 
            // btnClearContent
            // 
            this.btnClearContent.BackgroundImage = global::RIS.Properties.Resources.CleanContent_2;
            this.btnClearContent.Location = new System.Drawing.Point(722, 216);
            this.btnClearContent.Name = "btnClearContent";
            this.btnClearContent.Size = new System.Drawing.Size(149, 147);
            this.btnClearContent.TabIndex = 11;
            this.btnClearContent.UseVisualStyleBackColor = true;
            this.btnClearContent.Click += new System.EventHandler(this.btnClearContent_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::RIS.Properties.Resources.btnReportDone;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(722, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 105);
            this.btnSave.TabIndex = 10;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmNewTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 608);
            this.Controls.Add(this.btnClearContent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.HtmlEditor1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemplateName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmNewTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Template";
            this.Load += new System.EventHandler(this.frmNewTemplate_Load);
            this.HtmlEditor1.Toolbar1.ResumeLayout(false);
            this.HtmlEditor1.Toolbar1.PerformLayout();
            this.HtmlEditor1.Toolbar2.ResumeLayout(false);
            this.HtmlEditor1.Toolbar2.PerformLayout();
            this.HtmlEditor1.ResumeLayout(false);
            this.HtmlEditor1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.Label label1;
        private SpiceLogic.WinHTMLEditor.WinForm.WinFormHtmlEditor HtmlEditor1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearContent;
    }
}