namespace DVDSys
{
    partial class frmDVDRet
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.custUpdateLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grdSearch = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1314, 27);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.back_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(552, 57);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 32);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.Text = "Submit";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // custUpdateLabel
            // 
            this.custUpdateLabel.AutoSize = true;
            this.custUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custUpdateLabel.Location = new System.Drawing.Point(14, 64);
            this.custUpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.custUpdateLabel.Name = "custUpdateLabel";
            this.custUpdateLabel.Size = new System.Drawing.Size(126, 18);
            this.custUpdateLabel.TabIndex = 71;
            this.custUpdateLabel.Text = "Enter DVD Name ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(264, 61);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 24);
            this.txtSearch.TabIndex = 70;
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.SystemColors.Control;
            this.lstCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 18;
            this.lstCart.Location = new System.Drawing.Point(766, 97);
            this.lstCart.Margin = new System.Windows.Forms.Padding(4);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(486, 526);
            this.lstCart.TabIndex = 91;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.Location = new System.Drawing.Point(822, 652);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 43);
            this.btnReset.TabIndex = 86;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnConfirm.Location = new System.Drawing.Point(1088, 652);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 43);
            this.btnConfirm.TabIndex = 85;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // grdSearch
            // 
            this.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearch.Location = new System.Drawing.Point(18, 97);
            this.grdSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(676, 529);
            this.grdSearch.TabIndex = 73;
            this.grdSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellClick);
            // 
            // frmDVDRet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 732);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.custUpdateLabel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDVDRet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return DVD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label custUpdateLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView grdSearch;
    }
}