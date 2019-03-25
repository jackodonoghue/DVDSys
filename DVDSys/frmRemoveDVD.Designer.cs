namespace DVDSys
{
    partial class frmRemoveDVD
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.btnSearchSubmit = new System.Windows.Forms.Button();
            this.dvdUpdateLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(418, 24);
            this.menuStrip2.TabIndex = 66;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.back_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.Location = new System.Drawing.Point(63, 73);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(95, 23);
            this.btnSearchReset.TabIndex = 70;
            this.btnSearchReset.Text = "Reset";
            this.btnSearchReset.UseVisualStyleBackColor = true;
            // 
            // btnSearchSubmit
            // 
            this.btnSearchSubmit.Location = new System.Drawing.Point(219, 73);
            this.btnSearchSubmit.Name = "btnSearchSubmit";
            this.btnSearchSubmit.Size = new System.Drawing.Size(95, 23);
            this.btnSearchSubmit.TabIndex = 69;
            this.btnSearchSubmit.Text = "Submit";
            this.btnSearchSubmit.UseVisualStyleBackColor = true;
            this.btnSearchSubmit.Click += new System.EventHandler(this.btnSearchSubmit_Click);
            // 
            // dvdUpdateLabel
            // 
            this.dvdUpdateLabel.AutoSize = true;
            this.dvdUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdUpdateLabel.Location = new System.Drawing.Point(38, 34);
            this.dvdUpdateLabel.Name = "dvdUpdateLabel";
            this.dvdUpdateLabel.Size = new System.Drawing.Size(126, 18);
            this.dvdUpdateLabel.TabIndex = 68;
            this.dvdUpdateLabel.Text = "Enter DVD Name ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(205, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 20);
            this.txtSearch.TabIndex = 67;
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(36, 119);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(355, 176);
            this.dgvSearch.TabIndex = 78;
            this.dgvSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellContentDoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(162, 314);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 23);
            this.btnRemove.TabIndex = 49;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.submit_Click);
            // 
            // frmRemoveDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 349);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnSearchReset);
            this.Controls.Add(this.btnSearchSubmit);
            this.Controls.Add(this.dvdUpdateLabel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnRemove);
            this.Name = "frmRemoveDVD";
            this.Text = "Remove DVD";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnSearchReset;
        private System.Windows.Forms.Button btnSearchSubmit;
        private System.Windows.Forms.Label dvdUpdateLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnRemove;
    }
}