
namespace htmledit
{
    partial class DoctorListForm
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
            this.pbSignature = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUploadImage = new System.Windows.Forms.Label();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.htmledSignature = new WinHtmlEditor.HtmlEditor();
            this.htmledPreview = new WinHtmlEditor.HtmlEditor();
            this.lblPreview = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSignature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSignature
            // 
            this.pbSignature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSignature.Location = new System.Drawing.Point(403, 25);
            this.pbSignature.Name = "pbSignature";
            this.pbSignature.Size = new System.Drawing.Size(188, 85);
            this.pbSignature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSignature.TabIndex = 0;
            this.pbSignature.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 390);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Signature preview";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Signature image";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(306, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(15, 25);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(285, 20);
            this.txtDoctorName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(400, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Signature text";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 447);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(692, 447);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUploadImage
            // 
            this.lblUploadImage.AutoSize = true;
            this.lblUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadImage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblUploadImage.Location = new System.Drawing.Point(550, 9);
            this.lblUploadImage.Name = "lblUploadImage";
            this.lblUploadImage.Size = new System.Drawing.Size(41, 13);
            this.lblUploadImage.TabIndex = 6;
            this.lblUploadImage.Text = "Upload";
            this.lblUploadImage.Click += new System.EventHandler(this.lblUploadImage_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Location = new System.Drawing.Point(577, 447);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(109, 23);
            this.btnSaveClose.TabIndex = 12;
            this.btnSaveClose.Text = "Save and Close";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(498, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG Images (*.png)|*.png";
            this.openFileDialog1.Title = "Select image file";
            // 
            // htmledSignature
            // 
            //this.htmledSignature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            //this.htmledSignature.BodyInnerHTML = null;
            //this.htmledSignature.BodyInnerText = null;
            //this.htmledSignature.EnterToBR = true;
            //this.htmledSignature.FontSize = WinHtmlEditor.FontSize.Three;
            //this.htmledSignature.Location = new System.Drawing.Point(403, 129);
            //this.htmledSignature.MacroListDictionary = null;
            //this.htmledSignature.Name = "htmledSignature";
            //this.htmledSignature.ShowStatusBar = false;
            //this.htmledSignature.ShowToolBar = false;
            //this.htmledSignature.ShowWb = true;
            //this.htmledSignature.Size = new System.Drawing.Size(364, 116);
            //this.htmledSignature.TabIndex = 8;
            //this.htmledSignature.WebBrowserShortcutsEnabled = true;
            //// 
            //// htmledPreview
            //// 
            //this.htmledPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            //this.htmledPreview.BodyInnerHTML = null;
            //this.htmledPreview.BodyInnerText = null;
            //this.htmledPreview.EnterToBR = true;
            //this.htmledPreview.FontSize = WinHtmlEditor.FontSize.Three;
            //this.htmledPreview.Location = new System.Drawing.Point(403, 264);
            //this.htmledPreview.MacroListDictionary = null;
            //this.htmledPreview.Name = "htmledPreview";
            //this.htmledPreview.ShowStatusBar = false;
            //this.htmledPreview.ShowToolBar = false;
            //this.htmledPreview.ShowWb = true;
            //this.htmledPreview.Size = new System.Drawing.Size(364, 177);
            //this.htmledPreview.TabIndex = 10;
            //this.htmledPreview.WebBrowserShortcutsEnabled = true;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPreview.Location = new System.Drawing.Point(498, 248);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(45, 13);
            this.lblPreview.TabIndex = 14;
            this.lblPreview.Text = "Preview";
            this.lblPreview.Click += new System.EventHandler(this.lblPreview_Click);
            // 
            // DoctorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 477);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSaveClose);
            this.Controls.Add(this.lblUploadImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            //this.Controls.Add(this.htmledSignature);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
           // this.Controls.Add(this.htmledPreview);
            this.Controls.Add(this.pbSignature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DoctorListForm";
            this.Text = "Doctor List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoctorListForm_FormClosed);
            this.Load += new System.EventHandler(this.DoctorListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSignature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSignature;
       
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDoctorName;
      
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUploadImage;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPreview;
    }
}