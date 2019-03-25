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
            this.dvdLabel1 = new System.Windows.Forms.Label();
            this.txtDvd = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDVDBtn = new System.Windows.Forms.Button();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custDetails = new System.Windows.Forms.DataGridView();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eircode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDetails = new System.Windows.Forms.DataGridView();
            this.DVDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVDType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dvdLabel1
            // 
            this.dvdLabel1.AutoSize = true;
            this.dvdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdLabel1.Location = new System.Drawing.Point(12, 255);
            this.dvdLabel1.Name = "dvdLabel1";
            this.dvdLabel1.Size = new System.Drawing.Size(53, 18);
            this.dvdLabel1.TabIndex = 0;
            this.dvdLabel1.Text = "DVDID";
            // 
            // txtDvd
            // 
            this.txtDvd.Location = new System.Drawing.Point(136, 256);
            this.txtDvd.Name = "txtDvd";
            this.txtDvd.Size = new System.Drawing.Size(179, 20);
            this.txtDvd.TabIndex = 1;
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
            // addDVDBtn
            // 
            this.addDVDBtn.Location = new System.Drawing.Point(240, 282);
            this.addDVDBtn.Name = "addDVDBtn";
            this.addDVDBtn.Size = new System.Drawing.Size(75, 23);
            this.addDVDBtn.TabIndex = 31;
            this.addDVDBtn.Text = "Add More";
            this.addDVDBtn.UseVisualStyleBackColor = true;
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(136, 26);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(179, 20);
            this.txtRent.TabIndex = 33;
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.custNameLabel.Location = new System.Drawing.Point(12, 25);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(118, 18);
            this.custNameLabel.TabIndex = 32;
            this.custNameLabel.Text = "Customer Name";
            // 
            // custDetails
            // 
            this.custDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustID,
            this.FirstName,
            this.Surname,
            this.DateOfBirth,
            this.Address,
            this.Eircode,
            this.Gender,
            this.PhoneNumber});
            this.custDetails.Location = new System.Drawing.Point(12, 52);
            this.custDetails.Name = "custDetails";
            this.custDetails.Size = new System.Drawing.Size(846, 177);
            this.custDetails.TabIndex = 40;
            // 
            // CustID
            // 
            this.CustID.HeaderText = "CustID";
            this.CustID.Name = "CustID";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.Name = "DateOfBirth";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Eircode
            // 
            this.Eircode.HeaderText = "Eircode";
            this.Eircode.Name = "Eircode";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "PhoneNumber";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // rentalDetails
            // 
            this.rentalDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DVDID,
            this.Title,
            this.DVDType,
            this.Director,
            this.Genre,
            this.Price,
            this.ReturnDate,
            this.Status});
            this.rentalDetails.Location = new System.Drawing.Point(15, 322);
            this.rentalDetails.Name = "rentalDetails";
            this.rentalDetails.Size = new System.Drawing.Size(841, 144);
            this.rentalDetails.TabIndex = 60;
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
            // DVDType
            // 
            this.DVDType.HeaderText = "DVDType";
            this.DVDType.Name = "DVDType";
            // 
            // Director
            // 
            this.Director.HeaderText = "Director";
            this.Director.Name = "Director";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(734, 491);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 61;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.submit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(653, 491);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 62;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // frmRentDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 526);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rentalDetails);
            this.Controls.Add(this.custDetails);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.custNameLabel);
            this.Controls.Add(this.addDVDBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtDvd);
            this.Controls.Add(this.dvdLabel1);
            this.Name = "frmRentDVD";
            this.Text = "DVD Rental";
            this.Load += new System.EventHandler(this.frmRentDVD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dvdLabel1;
        private System.Windows.Forms.TextBox txtDvd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button addDVDBtn;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.DataGridView custDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eircode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridView rentalDetails;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}