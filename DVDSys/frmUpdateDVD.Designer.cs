namespace DVDSys
{
    partial class frmUpdateDVD
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
            this.custUpdateResults = new System.Windows.Forms.DataGridView();
            this.DVDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVDType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dvdUpdateLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.relLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.dirLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.btnResetDeatails = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custUpdateResults)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(449, 24);
            this.menuStrip2.TabIndex = 60;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // custUpdateResults
            // 
            this.custUpdateResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custUpdateResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DVDID,
            this.Title,
            this.DVDType,
            this.Director,
            this.Genre,
            this.ReleaseDate,
            this.Active});
            this.custUpdateResults.Location = new System.Drawing.Point(30, 124);
            this.custUpdateResults.Name = "custUpdateResults";
            this.custUpdateResults.Size = new System.Drawing.Size(389, 177);
            this.custUpdateResults.TabIndex = 59;
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
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.Name = "ReleaseDate";
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(78, 83);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 23);
            this.btnReset.TabIndex = 44;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(234, 83);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 23);
            this.btnSubmit.TabIndex = 43;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.submitName_Click);
            // 
            // dvdUpdateLabel
            // 
            this.dvdUpdateLabel.AutoSize = true;
            this.dvdUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdUpdateLabel.Location = new System.Drawing.Point(53, 44);
            this.dvdUpdateLabel.Name = "dvdUpdateLabel";
            this.dvdUpdateLabel.Size = new System.Drawing.Size(126, 18);
            this.dvdUpdateLabel.TabIndex = 42;
            this.dvdUpdateLabel.Text = "Enter DVD Name ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(220, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 20);
            this.txtSearch.TabIndex = 41;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "CL",
            "KD",
            "NR"});
            this.cboType.Location = new System.Drawing.Point(220, 368);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(151, 21);
            this.cboType.TabIndex = 74;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(220, 429);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(151, 20);
            this.txtGenre.TabIndex = 70;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(220, 403);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(151, 20);
            this.txtDir.TabIndex = 69;
            // 
            // dtpRelease
            // 
            this.dtpRelease.Location = new System.Drawing.Point(220, 455);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(194, 20);
            this.dtpRelease.TabIndex = 68;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(220, 329);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(151, 20);
            this.txtTitle.TabIndex = 67;
            // 
            // relLabel
            // 
            this.relLabel.AutoSize = true;
            this.relLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.relLabel.Location = new System.Drawing.Point(74, 457);
            this.relLabel.Name = "relLabel";
            this.relLabel.Size = new System.Drawing.Size(97, 18);
            this.relLabel.TabIndex = 65;
            this.relLabel.Text = "Release Date";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.genreLabel.Location = new System.Drawing.Point(74, 428);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(49, 18);
            this.genreLabel.TabIndex = 64;
            this.genreLabel.Text = "Genre";
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dirLabel.Location = new System.Drawing.Point(74, 402);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(61, 18);
            this.dirLabel.TabIndex = 63;
            this.dirLabel.Text = "Director";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.typeLabel.Location = new System.Drawing.Point(74, 372);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(75, 18);
            this.typeLabel.TabIndex = 62;
            this.typeLabel.Text = "DVD Type";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.titleLabel.Location = new System.Drawing.Point(74, 329);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 18);
            this.titleLabel.TabIndex = 61;
            this.titleLabel.Text = "Title";
            // 
            // btnResetDeatails
            // 
            this.btnResetDeatails.Location = new System.Drawing.Point(82, 501);
            this.btnResetDeatails.Name = "btnResetDeatails";
            this.btnResetDeatails.Size = new System.Drawing.Size(95, 23);
            this.btnResetDeatails.TabIndex = 76;
            this.btnResetDeatails.Text = "Reset";
            this.btnResetDeatails.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(234, 501);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 23);
            this.btnUpdate.TabIndex = 75;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.submit_Click);
            // 
            // frmUpdateDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 536);
            this.Controls.Add(this.btnResetDeatails);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.relLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.dirLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.custUpdateResults);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dvdUpdateLabel);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmUpdateDVD";
            this.Text = "Update DVD";
            this.Load += new System.EventHandler(this.frmUpdateDVD_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custUpdateResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView custUpdateResults;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label dvdUpdateLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label relLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button btnResetDeatails;
        private System.Windows.Forms.Button btnUpdate;
    }
}