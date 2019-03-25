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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnAddDVD = new System.Windows.Forms.Button();
            this.txtDVDID = new System.Windows.Forms.TextBox();
            this.dvdLabel1 = new System.Windows.Forms.Label();
            this.dgvRentalDetails = new System.Windows.Forms.DataGridView();
            this.DVDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalDetails)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(167, 266);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 28);
            this.btnReset.TabIndex = 67;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(248, 266);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(71, 28);
            this.btnConfirm.TabIndex = 66;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.submit_Click);
            // 
            // btnAddDVD
            // 
            this.btnAddDVD.Location = new System.Drawing.Point(248, 72);
            this.btnAddDVD.Name = "btnAddDVD";
            this.btnAddDVD.Size = new System.Drawing.Size(75, 23);
            this.btnAddDVD.TabIndex = 65;
            this.btnAddDVD.Text = "Add More";
            this.btnAddDVD.UseVisualStyleBackColor = true;
            // 
            // txtDVDID
            // 
            this.txtDVDID.Location = new System.Drawing.Point(144, 46);
            this.txtDVDID.Name = "txtDVDID";
            this.txtDVDID.Size = new System.Drawing.Size(179, 20);
            this.txtDVDID.TabIndex = 64;
            // 
            // dvdLabel1
            // 
            this.dvdLabel1.AutoSize = true;
            this.dvdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdLabel1.Location = new System.Drawing.Point(20, 45);
            this.dvdLabel1.Name = "dvdLabel1";
            this.dvdLabel1.Size = new System.Drawing.Size(53, 18);
            this.dvdLabel1.TabIndex = 63;
            this.dvdLabel1.Text = "DVDID";
            // 
            // dgvRentalDetails
            // 
            this.dgvRentalDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DVDID,
            this.Title,
            this.Status,
            this.ReturnDate});
            this.dgvRentalDetails.Location = new System.Drawing.Point(23, 116);
            this.dgvRentalDetails.Name = "dgvRentalDetails";
            this.dgvRentalDetails.Size = new System.Drawing.Size(300, 144);
            this.dgvRentalDetails.TabIndex = 68;
            // 
            // DVDID
            // 
            this.DVDID.HeaderText = "DVDID";
            this.DVDID.Name = "DVDID";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(344, 25);
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
            // frmDVDRet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 470);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvRentalDetails);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAddDVD);
            this.Controls.Add(this.txtDVDID);
            this.Controls.Add(this.dvdLabel1);
            this.Name = "frmDVDRet";
            this.Text = "Return DVD";
            this.Load += new System.EventHandler(this.frmDVDRet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalDetails)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnAddDVD;
        private System.Windows.Forms.TextBox txtDVDID;
        private System.Windows.Forms.Label dvdLabel1;
        private System.Windows.Forms.DataGridView dgvRentalDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}