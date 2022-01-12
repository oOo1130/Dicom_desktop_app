
namespace RIS.UIs
{
    partial class frmReportAndViewerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportAndViewerPanel));
            this.txtTemplateSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlTemplateSearch = new RIS.Controls.TemplateSearchControl();
            this.SuspendLayout();
            // 
            // txtTemplateSearch
            // 
            this.txtTemplateSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemplateSearch.Location = new System.Drawing.Point(914, 38);
            this.txtTemplateSearch.Name = "txtTemplateSearch";
            this.txtTemplateSearch.Size = new System.Drawing.Size(331, 26);
            this.txtTemplateSearch.TabIndex = 0;
            this.txtTemplateSearch.TextChanged += new System.EventHandler(this.txtTemplateSearch_TextChanged);
            this.txtTemplateSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTemplateSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(910, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Template";
            // 
            // ctrlTemplateSearch
            // 
            this.ctrlTemplateSearch.Location = new System.Drawing.Point(772, 191);
            this.ctrlTemplateSearch.Name = "ctrlTemplateSearch";
            this.ctrlTemplateSearch.Size = new System.Drawing.Size(503, 549);
            this.ctrlTemplateSearch.TabIndex = 2;
            this.ctrlTemplateSearch.Visible = false;
            this.ctrlTemplateSearch.SearchEsacaped += new RIS.SearchResultListControl<RIS.Models.ProcedureRadiologistTemplate>.SearchEscapeEventHandler(this.ctrlTemplateSearch_SearchEsacaped);
            // 
            // frmReportAndViewerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 622);
            this.Controls.Add(this.ctrlTemplateSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemplateSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportAndViewerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewer With Report Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportAndViewerPanel_Load);
            this.Shown += new System.EventHandler(this.frmReportAndViewerPanel_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemplateSearch;
        private System.Windows.Forms.Label label1;
        private Controls.TemplateSearchControl ctrlTemplateSearch;
    }
}