namespace DVDSys
{
    partial class frmRentDVD
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.custUpdateLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.lblCustName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDVDName = new System.Windows.Forms.TextBox();
            this.dvdUpdateLabel = new System.Windows.Forms.Label();
            this.btnSearchDVD = new System.Windows.Forms.Button();
            this.dgvDVDSearch = new System.Windows.Forms.DataGridView();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVDSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(868, 25);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(734, 491);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 61;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(653, 491);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 62;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(371, 32);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(95, 23);
            this.btnSearchCustomer.TabIndex = 65;
            this.btnSearchCustomer.Text = "Submit";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.submitCustomer_Click);
            // 
            // custUpdateLabel
            // 
            this.custUpdateLabel.AutoSize = true;
            this.custUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custUpdateLabel.Location = new System.Drawing.Point(12, 37);
            this.custUpdateLabel.Name = "custUpdateLabel";
            this.custUpdateLabel.Size = new System.Drawing.Size(161, 18);
            this.custUpdateLabel.TabIndex = 64;
            this.custUpdateLabel.Text = "Enter Customer Name ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(179, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 20);
            this.txtSearch.TabIndex = 63;
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(15, 61);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(451, 176);
            this.dgvSearch.TabIndex = 66;
            this.dgvSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellClick);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCustName.Location = new System.Drawing.Point(597, 33);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(0, 18);
            this.lblCustName.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(513, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "Customer:";
            // 
            // txtDVDName
            // 
            this.txtDVDName.Location = new System.Drawing.Point(179, 259);
            this.txtDVDName.Name = "txtDVDName";
            this.txtDVDName.Size = new System.Drawing.Size(186, 20);
            this.txtDVDName.TabIndex = 78;
            // 
            // dvdUpdateLabel
            // 
            this.dvdUpdateLabel.AutoSize = true;
            this.dvdUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdUpdateLabel.Location = new System.Drawing.Point(12, 259);
            this.dvdUpdateLabel.Name = "dvdUpdateLabel";
            this.dvdUpdateLabel.Size = new System.Drawing.Size(126, 18);
            this.dvdUpdateLabel.TabIndex = 79;
            this.dvdUpdateLabel.Text = "Enter DVD Name ";
            // 
            // btnSearchDVD
            // 
            this.btnSearchDVD.Location = new System.Drawing.Point(371, 257);
            this.btnSearchDVD.Name = "btnSearchDVD";
            this.btnSearchDVD.Size = new System.Drawing.Size(95, 23);
            this.btnSearchDVD.TabIndex = 80;
            this.btnSearchDVD.Text = "Submit";
            this.btnSearchDVD.UseVisualStyleBackColor = true;
            this.btnSearchDVD.Click += new System.EventHandler(this.btnSearchDVD_Click);
            // 
            // dgvDVDSearch
            // 
            this.dgvDVDSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVDSearch.Location = new System.Drawing.Point(12, 285);
            this.dgvDVDSearch.Name = "dgvDVDSearch";
            this.dgvDVDSearch.Size = new System.Drawing.Size(454, 166);
            this.dgvDVDSearch.TabIndex = 82;
            this.dgvDVDSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVDSearch_CellClick);
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.SystemColors.Control;
            this.lstCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 18;
            this.lstCart.Location = new System.Drawing.Point(496, 285);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(283, 166);
            this.lstCart.TabIndex = 83;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(785, 285);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 84;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotal.Location = new System.Drawing.Point(746, 454);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(0, 18);
            this.lblTotal.TabIndex = 85;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmRentDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 526);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.dgvDVDSearch);
            this.Controls.Add(this.btnSearchDVD);
            this.Controls.Add(this.dvdUpdateLabel);
            this.Controls.Add(this.txtDVDName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.custUpdateLabel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmRentDVD";
            this.Text = "DVD Rental";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVDSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Label custUpdateLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDVDName;
        private System.Windows.Forms.Label dvdUpdateLabel;
        private System.Windows.Forms.Button btnSearchDVD;
        private System.Windows.Forms.DataGridView dgvDVDSearch;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotal;
    }
}