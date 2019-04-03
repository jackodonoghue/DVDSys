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

        #region Window  s Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.btnSearchSubmit = new System.Windows.Forms.Button();
            this.dvdUpdateLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearchReset.Location = new System.Drawing.Point(94, 101);
            this.btnSearchReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(142, 32);
            this.btnSearchReset.TabIndex = 70;
            this.btnSearchReset.Text = "Reset";
            this.btnSearchReset.UseVisualStyleBackColor = true;
            this.btnSearchReset.Click += new System.EventHandler(this.btnSearchReset_Click);
            // 
            // btnSearchSubmit
            // 
            this.btnSearchSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearchSubmit.Location = new System.Drawing.Point(328, 101);
            this.btnSearchSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSubmit.Name = "btnSearchSubmit";
            this.btnSearchSubmit.Size = new System.Drawing.Size(142, 32);
            this.btnSearchSubmit.TabIndex = 69;
            this.btnSearchSubmit.Text = "Submit";
            this.btnSearchSubmit.UseVisualStyleBackColor = true;
            this.btnSearchSubmit.Click += new System.EventHandler(this.btnSearchSubmit_Click);
            // 
            // dvdUpdateLabel
            // 
            this.dvdUpdateLabel.AutoSize = true;
            this.dvdUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdUpdateLabel.Location = new System.Drawing.Point(57, 47);
            this.dvdUpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dvdUpdateLabel.Name = "dvdUpdateLabel";
            this.dvdUpdateLabel.Size = new System.Drawing.Size(126, 18);
            this.dvdUpdateLabel.TabIndex = 68;
            this.dvdUpdateLabel.Text = "Enter DVD Name ";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearch.Location = new System.Drawing.Point(308, 44);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 24);
            this.txtSearch.TabIndex = 67;
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(54, 165);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(532, 244);
            this.dgvSearch.TabIndex = 78;
            this.dgvSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRemove.Location = new System.Drawing.Point(243, 435);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(142, 32);
            this.btnRemove.TabIndex = 49;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.submit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 24);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(627, 30);
            this.menuStrip2.TabIndex = 79;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // frmRemoveDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 483);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnSearchReset);
            this.Controls.Add(this.btnSearchSubmit);
            this.Controls.Add(this.dvdUpdateLabel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRemove);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRemoveDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove DVD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchReset;
        private System.Windows.Forms.Button btnSearchSubmit;
        private System.Windows.Forms.Label dvdUpdateLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
    }
}