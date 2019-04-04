namespace DVDSys
{
    partial class frmAddCustomer
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
            this.fNameLabel = new System.Windows.Forms.Label();
            this.sNameLabel = new System.Windows.Forms.Label();
            this.dOBLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.genLabel = new System.Windows.Forms.Label();
            this.phNumLabel = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.btnCustID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fNameLabel.Location = new System.Drawing.Point(93, 102);
            this.fNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(81, 18);
            this.fNameLabel.TabIndex = 1;
            this.fNameLabel.Text = "First Name";
            // 
            // sNameLabel
            // 
            this.sNameLabel.AutoSize = true;
            this.sNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sNameLabel.Location = new System.Drawing.Point(93, 144);
            this.sNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sNameLabel.Name = "sNameLabel";
            this.sNameLabel.Size = new System.Drawing.Size(68, 18);
            this.sNameLabel.TabIndex = 2;
            this.sNameLabel.Text = "Surname";
            // 
            // dOBLabel
            // 
            this.dOBLabel.AutoSize = true;
            this.dOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dOBLabel.Location = new System.Drawing.Point(96, 192);
            this.dOBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dOBLabel.Name = "dOBLabel";
            this.dOBLabel.Size = new System.Drawing.Size(90, 18);
            this.dOBLabel.TabIndex = 3;
            this.dOBLabel.Text = "Date of Birth";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.addressLabel.Location = new System.Drawing.Point(96, 231);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 18);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // genLabel
            // 
            this.genLabel.AutoSize = true;
            this.genLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.genLabel.Location = new System.Drawing.Point(93, 313);
            this.genLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genLabel.Name = "genLabel";
            this.genLabel.Size = new System.Drawing.Size(57, 18);
            this.genLabel.TabIndex = 6;
            this.genLabel.Text = "Gender";
            // 
            // phNumLabel
            // 
            this.phNumLabel.AutoSize = true;
            this.phNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.phNumLabel.Location = new System.Drawing.Point(93, 354);
            this.phNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phNumLabel.Name = "phNumLabel";
            this.phNumLabel.Size = new System.Drawing.Size(108, 18);
            this.phNumLabel.TabIndex = 7;
            this.phNumLabel.Text = "Phone Number";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFName.Location = new System.Drawing.Point(312, 98);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(224, 24);
            this.txtFName.TabIndex = 8;
            // 
            // txtSName
            // 
            this.txtSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSName.Location = new System.Drawing.Point(312, 140);
            this.txtSName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(224, 24);
            this.txtSName.TabIndex = 9;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "";
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(312, 186);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(224, 24);
            this.dtpDOB.TabIndex = 10;
            this.dtpDOB.Value = new System.DateTime(2019, 2, 13, 0, 0, 0, 0);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAddress1.Location = new System.Drawing.Point(312, 227);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(224, 24);
            this.txtAddress1.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPhone.Location = new System.Drawing.Point(312, 350);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(224, 24);
            this.txtPhone.TabIndex = 17;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSubmit.Location = new System.Drawing.Point(358, 392);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 43);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.submit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.Location = new System.Drawing.Point(130, 392);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 43);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(651, 30);
            this.menuStrip1.TabIndex = 19;
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAddress2.Location = new System.Drawing.Point(312, 269);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(224, 24);
            this.txtAddress2.TabIndex = 14;
            // 
            // btnCustID
            // 
            this.btnCustID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCustID.Enabled = false;
            this.btnCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCustID.Location = new System.Drawing.Point(312, 57);
            this.btnCustID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustID.MaxLength = 3;
            this.btnCustID.Name = "btnCustID";
            this.btnCustID.Size = new System.Drawing.Size(58, 24);
            this.btnCustID.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(93, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Customer ID";
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Checked = true;
            this.chkMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkMale.Location = new System.Drawing.Point(309, 312);
            this.chkMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(59, 22);
            this.chkMale.TabIndex = 15;
            this.chkMale.Text = "Male";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.Click += new System.EventHandler(this.maleCB_Clicked);
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.chkFemale.Location = new System.Drawing.Point(453, 310);
            this.chkFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(76, 22);
            this.chkFemale.TabIndex = 16;
            this.chkFemale.Text = "Female";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.Click += new System.EventHandler(this.femaleCB_Clicked);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 460);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.btnCustID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.phNumLabel);
            this.Controls.Add(this.genLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.dOBLabel);
            this.Controls.Add(this.sNameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(667, 400);
            this.Name = "frmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label sNameLabel;
        private System.Windows.Forms.Label dOBLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label genLabel;
        private System.Windows.Forms.Label phNumLabel;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox btnCustID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.CheckBox chkFemale;
    }
}

