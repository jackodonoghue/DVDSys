namespace DVDSys
{
    partial class frmAddDVD
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.phNumLabel = new System.Windows.Forms.Label();
            this.relLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.dirLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboActive = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.back_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.Location = new System.Drawing.Point(85, 266);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 30);
            this.btnReset.TabIndex = 950;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSubmit.Location = new System.Drawing.Point(237, 266);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 30);
            this.btnSubmit.TabIndex = 900;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.submit_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtGenre.Location = new System.Drawing.Point(211, 160);
            this.txtGenre.MaxLength = 15;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(151, 24);
            this.txtGenre.TabIndex = 40;
            // 
            // txtDir
            // 
            this.txtDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDir.Location = new System.Drawing.Point(211, 130);
            this.txtDir.MaxLength = 20;
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(151, 24);
            this.txtDir.TabIndex = 30;
            // 
            // dtpRelease
            // 
            this.dtpRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRelease.Location = new System.Drawing.Point(211, 190);
            this.dtpRelease.MaxDate = new System.DateTime(2019, 3, 25, 0, 0, 0, 0);
            this.dtpRelease.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(98, 24);
            this.dtpRelease.TabIndex = 50;
            this.dtpRelease.Value = new System.DateTime(2019, 3, 25, 0, 0, 0, 0);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTitle.Location = new System.Drawing.Point(211, 68);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(151, 24);
            this.txtTitle.TabIndex = 10;
            // 
            // phNumLabel
            // 
            this.phNumLabel.AutoSize = true;
            this.phNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.phNumLabel.Location = new System.Drawing.Point(67, 223);
            this.phNumLabel.Name = "phNumLabel";
            this.phNumLabel.Size = new System.Drawing.Size(47, 18);
            this.phNumLabel.TabIndex = 25;
            this.phNumLabel.Text = "Active";
            // 
            // relLabel
            // 
            this.relLabel.AutoSize = true;
            this.relLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.relLabel.Location = new System.Drawing.Point(65, 195);
            this.relLabel.Name = "relLabel";
            this.relLabel.Size = new System.Drawing.Size(97, 18);
            this.relLabel.TabIndex = 24;
            this.relLabel.Text = "Release Date";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.genreLabel.Location = new System.Drawing.Point(65, 163);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(49, 18);
            this.genreLabel.TabIndex = 23;
            this.genreLabel.Text = "Genre";
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dirLabel.Location = new System.Drawing.Point(65, 133);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(61, 18);
            this.dirLabel.TabIndex = 22;
            this.dirLabel.Text = "Director";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.typeLabel.Location = new System.Drawing.Point(65, 101);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(75, 18);
            this.typeLabel.TabIndex = 20;
            this.typeLabel.Text = "DVD Type";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.titleLabel.Location = new System.Drawing.Point(65, 71);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 18);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "Title";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboType.FormattingEnabled = true;
            this.cboType.IntegralHeight = false;
            this.cboType.Location = new System.Drawing.Point(211, 98);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(53, 26);
            this.cboType.TabIndex = 20;
            // 
            // cboActive
            // 
            this.cboActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboActive.FormattingEnabled = true;
            this.cboActive.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cboActive.Location = new System.Drawing.Point(211, 220);
            this.cboActive.Name = "cboActive";
            this.cboActive.Size = new System.Drawing.Size(53, 26);
            this.cboActive.TabIndex = 60;
            // 
            // txtID
            // 
            this.txtID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtID.Location = new System.Drawing.Point(211, 38);
            this.txtID.MaxLength = 3;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(40, 24);
            this.txtID.TabIndex = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "DVD ID";
            // 
            // frmAddDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 320);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboActive);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.phNumLabel);
            this.Controls.Add(this.relLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.dirLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmAddDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add DVD";
            this.Load += new System.EventHandler(this.frmAddDVD_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label phNumLabel;
        private System.Windows.Forms.Label relLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboActive;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}