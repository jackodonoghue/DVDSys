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
            this.grdSearch = new System.Windows.Forms.DataGridView();
            this.lblCustName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDVDName = new System.Windows.Forms.TextBox();
            this.dvdUpdateLabel = new System.Windows.Forms.Label();
            this.grdDVDSearch = new System.Windows.Forms.DataGridView();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnDVDSearch = new System.Windows.Forms.Button();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlInvoice = new System.Windows.Forms.Panel();
            this.lblRetDate = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.lstInv = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRentID = new System.Windows.Forms.Label();
            this.lblDateIss = new System.Windows.Forms.Label();
            this.lblCustInv = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDVDSearch)).BeginInit();
            this.grpInvoice.SuspendLayout();
            this.pnlInvoice.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1302, 32);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnConfirm.Location = new System.Drawing.Point(1035, 658);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 43);
            this.btnConfirm.TabIndex = 70;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.Location = new System.Drawing.Point(786, 658);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 43);
            this.btnReset.TabIndex = 60;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Location = new System.Drawing.Point(556, 44);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(142, 39);
            this.btnSearchCustomer.TabIndex = 20;
            this.btnSearchCustomer.Text = "Submit";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.submitCustomer_Click);
            // 
            // custUpdateLabel
            // 
            this.custUpdateLabel.AutoSize = true;
            this.custUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custUpdateLabel.Location = new System.Drawing.Point(18, 51);
            this.custUpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.custUpdateLabel.Name = "custUpdateLabel";
            this.custUpdateLabel.Size = new System.Drawing.Size(161, 18);
            this.custUpdateLabel.TabIndex = 64;
            this.custUpdateLabel.Text = "Enter Customer Name ";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearch.Location = new System.Drawing.Point(268, 48);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 24);
            this.txtSearch.TabIndex = 10;
            // 
            // grdSearch
            // 
            this.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearch.Location = new System.Drawing.Point(22, 93);
            this.grdSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(676, 244);
            this.grdSearch.TabIndex = 66;
            this.grdSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellClick);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCustName.Location = new System.Drawing.Point(896, 46);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(0, 18);
            this.lblCustName.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(770, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "Customer:";
            // 
            // txtDVDName
            // 
            this.txtDVDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDVDName.Location = new System.Drawing.Point(268, 359);
            this.txtDVDName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDVDName.Name = "txtDVDName";
            this.txtDVDName.Size = new System.Drawing.Size(277, 24);
            this.txtDVDName.TabIndex = 30;
            // 
            // dvdUpdateLabel
            // 
            this.dvdUpdateLabel.AutoSize = true;
            this.dvdUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdUpdateLabel.Location = new System.Drawing.Point(18, 359);
            this.dvdUpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dvdUpdateLabel.Name = "dvdUpdateLabel";
            this.dvdUpdateLabel.Size = new System.Drawing.Size(126, 18);
            this.dvdUpdateLabel.TabIndex = 79;
            this.dvdUpdateLabel.Text = "Enter DVD Name ";
            // 
            // grdDVDSearch
            // 
            this.grdDVDSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDVDSearch.Location = new System.Drawing.Point(18, 403);
            this.grdDVDSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grdDVDSearch.Name = "grdDVDSearch";
            this.grdDVDSearch.Size = new System.Drawing.Size(681, 230);
            this.grdDVDSearch.TabIndex = 82;
            this.grdDVDSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVDSearch_CellClick);
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.SystemColors.Control;
            this.lstCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 18;
            this.lstCart.Location = new System.Drawing.Point(744, 395);
            this.lstCart.Margin = new System.Windows.Forms.Padding(4);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(422, 220);
            this.lstCart.TabIndex = 83;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRemove.Location = new System.Drawing.Point(1178, 395);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 43);
            this.btnRemove.TabIndex = 50;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTotal.Location = new System.Drawing.Point(1119, 629);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(0, 18);
            this.lblTotal.TabIndex = 85;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDVDSearch
            // 
            this.btnDVDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDVDSearch.Location = new System.Drawing.Point(557, 352);
            this.btnDVDSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnDVDSearch.Name = "btnDVDSearch";
            this.btnDVDSearch.Size = new System.Drawing.Size(142, 39);
            this.btnDVDSearch.TabIndex = 95;
            this.btnDVDSearch.Text = "Submit";
            this.btnDVDSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDVDSearch.UseVisualStyleBackColor = true;
            this.btnDVDSearch.Click += new System.EventHandler(this.btnSearchDVD_Click);
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.btnClose);
            this.grpInvoice.Controls.Add(this.btnPrint);
            this.grpInvoice.Controls.Add(this.pnlInvoice);
            this.grpInvoice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.grpInvoice.Location = new System.Drawing.Point(389, 86);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(524, 557);
            this.grpInvoice.TabIndex = 97;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "Invoice";
            this.grpInvoice.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(215, 511);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 39);
            this.btnClose.TabIndex = 94;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(375, 511);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(142, 39);
            this.btnPrint.TabIndex = 40;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlInvoice
            // 
            this.pnlInvoice.Controls.Add(this.lblCustInv);
            this.pnlInvoice.Controls.Add(this.lblDateIss);
            this.pnlInvoice.Controls.Add(this.lblRentID);
            this.pnlInvoice.Controls.Add(this.label9);
            this.pnlInvoice.Controls.Add(this.label8);
            this.pnlInvoice.Controls.Add(this.lblRetDate);
            this.pnlInvoice.Controls.Add(this.lblTot);
            this.pnlInvoice.Controls.Add(this.lstInv);
            this.pnlInvoice.Controls.Add(this.label5);
            this.pnlInvoice.Controls.Add(this.label4);
            this.pnlInvoice.Controls.Add(this.label3);
            this.pnlInvoice.Controls.Add(this.label2);
            this.pnlInvoice.Location = new System.Drawing.Point(27, 23);
            this.pnlInvoice.Name = "pnlInvoice";
            this.pnlInvoice.Size = new System.Drawing.Size(471, 469);
            this.pnlInvoice.TabIndex = 93;
            // 
            // lblRetDate
            // 
            this.lblRetDate.AutoSize = true;
            this.lblRetDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRetDate.Location = new System.Drawing.Point(18, 438);
            this.lblRetDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetDate.Name = "lblRetDate";
            this.lblRetDate.Size = new System.Drawing.Size(118, 18);
            this.lblRetDate.TabIndex = 86;
            this.lblRetDate.Text = "Please return by ";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblTot.Location = new System.Drawing.Point(262, 415);
            this.lblTot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(46, 18);
            this.lblTot.TabIndex = 85;
            this.lblTot.Text = "Total";
            // 
            // lstInv
            // 
            this.lstInv.BackColor = System.Drawing.SystemColors.Control;
            this.lstInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lstInv.FormattingEnabled = true;
            this.lstInv.ItemHeight = 18;
            this.lstInv.Location = new System.Drawing.Point(10, 168);
            this.lstInv.Margin = new System.Windows.Forms.Padding(4);
            this.lstInv.Name = "lstInv";
            this.lstInv.Size = new System.Drawing.Size(422, 220);
            this.lstInv.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 72;
            this.label5.Text = "Customer Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(228, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 71;
            this.label4.Text = "Date Issued";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "Rent Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 44);
            this.label2.TabIndex = 69;
            this.label2.Text = "Invoice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(316, 415);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 18);
            this.label8.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(128, 438);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 18);
            this.label9.TabIndex = 88;
            // 
            // lblRentID
            // 
            this.lblRentID.AutoSize = true;
            this.lblRentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentID.Location = new System.Drawing.Point(9, 92);
            this.lblRentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentID.Name = "lblRentID";
            this.lblRentID.Size = new System.Drawing.Size(0, 18);
            this.lblRentID.TabIndex = 89;
            // 
            // lblDateIss
            // 
            this.lblDateIss.AutoSize = true;
            this.lblDateIss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateIss.Location = new System.Drawing.Point(228, 92);
            this.lblDateIss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateIss.Name = "lblDateIss";
            this.lblDateIss.Size = new System.Drawing.Size(0, 18);
            this.lblDateIss.TabIndex = 90;
            // 
            // lblCustInv
            // 
            this.lblCustInv.AutoSize = true;
            this.lblCustInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustInv.Location = new System.Drawing.Point(9, 146);
            this.lblCustInv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustInv.Name = "lblCustInv";
            this.lblCustInv.Size = new System.Drawing.Size(0, 18);
            this.lblCustInv.TabIndex = 91;
            // 
            // frmRentDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 728);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.btnDVDSearch);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.grdDVDSearch);
            this.Controls.Add(this.dvdUpdateLabel);
            this.Controls.Add(this.txtDVDName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.custUpdateLabel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRentDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVD Rental";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDVDSearch)).EndInit();
            this.grpInvoice.ResumeLayout(false);
            this.pnlInvoice.ResumeLayout(false);
            this.pnlInvoice.PerformLayout();
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
        private System.Windows.Forms.DataGridView grdSearch;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDVDName;
        private System.Windows.Forms.Label dvdUpdateLabel;
        private System.Windows.Forms.DataGridView grdDVDSearch;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnDVDSearch;
        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlInvoice;
        private System.Windows.Forms.Label lblRetDate;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.ListBox lstInv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCustInv;
        private System.Windows.Forms.Label lblDateIss;
        private System.Windows.Forms.Label lblRentID;
    }
}