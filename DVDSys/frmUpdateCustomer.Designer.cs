namespace DVDSys
{
    partial class frmUpdateCustomer
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.custUpdateLabel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.phNumLabel = new System.Windows.Forms.Label();
            this.genLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dOBLabel = new System.Windows.Forms.Label();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataSet1 = new System.Data.DataSet();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grdSearch = new System.Windows.Forms.DataGridView();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearch.Location = new System.Drawing.Point(207, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 24);
            this.txtSearch.TabIndex = 2;
            // 
            // custUpdateLabel
            // 
            this.custUpdateLabel.AutoSize = true;
            this.custUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custUpdateLabel.Location = new System.Drawing.Point(40, 53);
            this.custUpdateLabel.Name = "custUpdateLabel";
            this.custUpdateLabel.Size = new System.Drawing.Size(161, 18);
            this.custUpdateLabel.TabIndex = 3;
            this.custUpdateLabel.Text = "Enter Customer Name ";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearch.Location = new System.Drawing.Point(159, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 33);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Submit";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.updateSubmit_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPhone.Location = new System.Drawing.Point(198, 548);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(151, 24);
            this.txtPhone.TabIndex = 36;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAddress.Location = new System.Drawing.Point(198, 462);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(151, 24);
            this.txtAddress.TabIndex = 31;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(198, 415);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(151, 24);
            this.dtpDOB.TabIndex = 30;
            // 
            // txtSName
            // 
            this.txtSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSName.Location = new System.Drawing.Point(198, 370);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(151, 24);
            this.txtSName.TabIndex = 29;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFName.Location = new System.Drawing.Point(198, 329);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(151, 24);
            this.txtFName.TabIndex = 28;
            // 
            // phNumLabel
            // 
            this.phNumLabel.AutoSize = true;
            this.phNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.phNumLabel.Location = new System.Drawing.Point(52, 550);
            this.phNumLabel.Name = "phNumLabel";
            this.phNumLabel.Size = new System.Drawing.Size(108, 18);
            this.phNumLabel.TabIndex = 27;
            this.phNumLabel.Text = "Phone Number";
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.genLabel.Location = new System.Drawing.Point(52, 502);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(57, 18);
            this.genLabel.TabIndex = 26;
            this.genLabel.Text = "Gender";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addressLabel.Location = new System.Drawing.Point(52, 461);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 18);
            this.addressLabel.TabIndex = 24;
            this.addressLabel.Text = "Address";
            // 
            // dOBLabel
            // 
            this.dOBLabel.AutoSize = true;
            this.dOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dOBLabel.Location = new System.Drawing.Point(52, 417);
            this.dOBLabel.Name = "dOBLabel";
            this.dOBLabel.Size = new System.Drawing.Size(90, 18);
            this.dOBLabel.TabIndex = 23;
            this.dOBLabel.Text = "Date of Birth";
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sNameLabel.Location = new System.Drawing.Point(52, 372);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(68, 18);
            this.sNameLabel.TabIndex = 22;
            this.sNameLabel.Text = "Surname";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fNameLabel.Location = new System.Drawing.Point(52, 329);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(81, 18);
            this.fNameLabel.TabIndex = 21;
            this.fNameLabel.Text = "First Name";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.Location = new System.Drawing.Point(69, 602);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 33);
            this.btnReset.TabIndex = 38;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.resetUI);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnUpdate.Location = new System.Drawing.Point(221, 602);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 33);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.custSubmit_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(434, 28);
            this.menuStrip2.TabIndex = 40;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.back__Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 24);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.exit_Click);
            // 
            // grdSearch
            // 
            this.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearch.Location = new System.Drawing.Point(43, 141);
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(355, 176);
            this.grdSearch.TabIndex = 41;
            this.grdSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custUpdateResults_CellClick);
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkMale.Location = new System.Drawing.Point(198, 505);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(59, 22);
            this.chkMale.TabIndex = 32;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.Click += new System.EventHandler(this.maleCB_Clicked);
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkFemale.Location = new System.Drawing.Point(313, 503);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(76, 22);
            this.chkFemale.TabIndex = 34;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.Click += new System.EventHandler(this.femaleCB_Clicked);
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 647);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.phNumLabel);
            this.Controls.Add(this.genLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dOBLabel);
            this.Controls.Add(this.sNameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.custUpdateLabel);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmUpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label custUpdateLabel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label phNumLabel;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dOBLabel;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView grdSearch;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.CheckBox chkFemale;
    }
}