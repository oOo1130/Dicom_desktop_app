
namespace htmledit
{
    partial class frmHtmlReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHtmlReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCreateTemplate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateTemplate = new System.Windows.Forms.Button();
            this.btnReportComplete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSelectTemplate = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.htmlEditor1 = new WinHtmlEditor.HtmlEditor();
            this.htmlEditorForTemplate = new WinHtmlEditor.HtmlEditor();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.htmlEditor1);
            this.panel1.Controls.Add(this.htmlEditorForTemplate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 600);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(9, 311);
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
            this.panel2.Controls.Add(this.btnUpdateTemplate);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
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
            this.pictureBox1.Location = new System.Drawing.Point(31, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 112);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateTemplate
            // 
            this.btnUpdateTemplate.BackColor = System.Drawing.Color.Green;
            this.btnUpdateTemplate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTemplate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateTemplate.Location = new System.Drawing.Point(9, 257);
            this.btnUpdateTemplate.Name = "btnUpdateTemplate";
            this.btnUpdateTemplate.Size = new System.Drawing.Size(247, 33);
            this.btnUpdateTemplate.TabIndex = 11;
            this.btnUpdateTemplate.Text = "Update Template";
            this.btnUpdateTemplate.UseVisualStyleBackColor = false;
            this.btnUpdateTemplate.Click += new System.EventHandler(this.btnUpdateTemplate_Click);
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
            this.cmbSelectTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectTemplate.FormattingEnabled = true;
            this.cmbSelectTemplate.Location = new System.Drawing.Point(9, 154);
            this.cmbSelectTemplate.Name = "cmbSelectTemplate";
            this.cmbSelectTemplate.Size = new System.Drawing.Size(244, 26);
            this.cmbSelectTemplate.TabIndex = 6;
            this.cmbSelectTemplate.SelectedIndexChanged += new System.EventHandler(this.cmbSelectTemplate_SelectedIndexChanged);
            // 
            // htmlEditor1
            // 
            this.htmlEditor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.htmlEditor1.BodyInnerHTML = null;
            this.htmlEditor1.BodyInnerText = null;
            this.htmlEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlEditor1.EnterToBR = false;
            this.htmlEditor1.FontSize = WinHtmlEditor.FontSize.Three;
            this.htmlEditor1.Location = new System.Drawing.Point(0, 0);
            this.htmlEditor1.MacroListDictionary = null;
            this.htmlEditor1.Name = "htmlEditor1";
            this.htmlEditor1.ShowStatusBar = true;
            this.htmlEditor1.ShowToolBar = true;
            this.htmlEditor1.ShowWb = true;
            this.htmlEditor1.Size = new System.Drawing.Size(1015, 600);
            this.htmlEditor1.TabIndex = 3;
            this.htmlEditor1.WebBrowserShortcutsEnabled = true;
            // 
            // htmlEditorForTemplate
            // 
            this.htmlEditorForTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.htmlEditorForTemplate.BodyInnerHTML = null;
            this.htmlEditorForTemplate.BodyInnerText = null;
            this.htmlEditorForTemplate.EnterToBR = false;
            this.htmlEditorForTemplate.FontSize = WinHtmlEditor.FontSize.Three;
            this.htmlEditorForTemplate.Location = new System.Drawing.Point(1077, -488);
            this.htmlEditorForTemplate.MacroListDictionary = null;
            this.htmlEditorForTemplate.Name = "htmlEditorForTemplate";
            this.htmlEditorForTemplate.ShowStatusBar = false;
            this.htmlEditorForTemplate.ShowToolBar = false;
            this.htmlEditorForTemplate.ShowWb = true;
            this.htmlEditorForTemplate.Size = new System.Drawing.Size(339, 266);
            this.htmlEditorForTemplate.TabIndex = 7;
            this.htmlEditorForTemplate.WebBrowserShortcutsEnabled = true;
            // 
            // frmHtmlReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHtmlReport";
            this.Text = "EMSL-Word Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
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
        private WinHtmlEditor.HtmlEditor htmlEditor1;
        private System.Windows.Forms.Button btnCreateTemplate;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSelectTemplate;
        private WinHtmlEditor.HtmlEditor htmlEditorForTemplate;
        private System.Windows.Forms.Button btnReportComplete;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdateTemplate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnWord;
    }
}

