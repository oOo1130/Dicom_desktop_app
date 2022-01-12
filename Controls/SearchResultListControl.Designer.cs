namespace RIS
{
    partial class SearchResultListControl<T>
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lstSearch = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(927, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 29);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(927, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // lstSearch
            // 
            this.lstSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearch.FullRowSelect = true;
            this.lstSearch.GridLines = true;
            this.lstSearch.Location = new System.Drawing.Point(0, 32);
            this.lstSearch.MultiSelect = false;
            this.lstSearch.Name = "lstSearch";
            this.lstSearch.Size = new System.Drawing.Size(927, 618);
            this.lstSearch.TabIndex = 2;
            this.lstSearch.UseCompatibleStateImageBehavior = false;
            this.lstSearch.View = System.Windows.Forms.View.Details;
            this.lstSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstSearch_KeyPress);
            this.lstSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSearch_MouseDoubleClick);
            // 
            // SearchResultListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstSearch);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtSearch);
            this.Name = "SearchResultListControl";
            this.Size = new System.Drawing.Size(927, 650);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lstSearch;
    }
}
