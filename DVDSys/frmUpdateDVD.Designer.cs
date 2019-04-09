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
            this.btnSearchReset = new System.Windows.Forms.Button();
            this.btnSearchSubmit = new System.Windows.Forms.Button();
            this.dvdUpdateLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grdSearch = new System.Windows.Forms.DataGridView();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.relLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.dirLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(674, 30);
            this.menuStrip2.TabIndex = 60;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 24);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnSearchReset
            // 
            this.btnSearchReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearchReset.Location = new System.Drawing.Point(110, 100);
            this.btnSearchReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchReset.Name = "btnSearchReset";
            this.btnSearchReset.Size = new System.Drawing.Size(142, 32);
            this.btnSearchReset.TabIndex = 44;
            this.btnSearchReset.Text = "Reset";
            this.btnSearchReset.UseVisualStyleBackColor = true;
            this.btnSearchReset.Click += new System.EventHandler(this.btnSearchReset_Click);
            // 
            // btnSearchSubmit
            // 
            this.btnSearchSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearchSubmit.Location = new System.Drawing.Point(344, 100);
            this.btnSearchSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchSubmit.Name = "btnSearchSubmit";
            this.btnSearchSubmit.Size = new System.Drawing.Size(142, 32);
            this.btnSearchSubmit.TabIndex = 43;
            this.btnSearchSubmit.Text = "Submit";
            this.btnSearchSubmit.UseVisualStyleBackColor = true;
            this.btnSearchSubmit.Click += new System.EventHandler(this.btnSearchSubmit_Click);
            // 
            // dvdUpdateLabel
            // 
            this.dvdUpdateLabel.AutoSize = true;
            this.dvdUpdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdUpdateLabel.Location = new System.Drawing.Point(72, 46);
            this.dvdUpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dvdUpdateLabel.Name = "dvdUpdateLabel";
            this.dvdUpdateLabel.Size = new System.Drawing.Size(126, 18);
            this.dvdUpdateLabel.TabIndex = 42;
            this.dvdUpdateLabel.Text = "Enter DVD Name ";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearch.Location = new System.Drawing.Point(322, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 24);
            this.txtSearch.TabIndex = 41;
            // 
            // grdSearch
            // 
            this.grdSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearch.Location = new System.Drawing.Point(69, 152);
            this.grdSearch.Margin = new System.Windows.Forms.Padding(4);
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(532, 244);
            this.grdSearch.TabIndex = 77;
            this.grdSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearch_CellClick);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(322, 458);
            this.cboType.Margin = new System.Windows.Forms.Padding(4);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(78, 26);
            this.cboType.TabIndex = 953;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.Location = new System.Drawing.Point(118, 627);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 32);
            this.btnReset.TabIndex = 964;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnUpdate.Location = new System.Drawing.Point(346, 627);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 32);
            this.btnUpdate.TabIndex = 963;
            this.btnUpdate.Text = "Submit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtGenre.Location = new System.Drawing.Point(322, 543);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenre.MaxLength = 15;
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(224, 24);
            this.txtGenre.TabIndex = 960;
            // 
            // txtDir
            // 
            this.txtDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDir.Location = new System.Drawing.Point(322, 507);
            this.txtDir.Margin = new System.Windows.Forms.Padding(4);
            this.txtDir.MaxLength = 20;
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(224, 24);
            this.txtDir.TabIndex = 959;
            // 
            // dtpRelease
            // 
            this.dtpRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRelease.Location = new System.Drawing.Point(322, 579);
            this.dtpRelease.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRelease.MaxDate = new System.DateTime(2019, 3, 25, 0, 0, 0, 0);
            this.dtpRelease.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(145, 24);
            this.dtpRelease.TabIndex = 961;
            this.dtpRelease.Value = new System.DateTime(2019, 3, 25, 0, 0, 0, 0);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTitle.Location = new System.Drawing.Point(322, 404);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(224, 24);
            this.txtTitle.TabIndex = 951;
            // 
            // relLabel
            // 
            this.relLabel.AutoSize = true;
            this.relLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.relLabel.Location = new System.Drawing.Point(104, 582);
            this.relLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.relLabel.Name = "relLabel";
            this.relLabel.Size = new System.Drawing.Size(97, 18);
            this.relLabel.TabIndex = 957;
            this.relLabel.Text = "Release Date";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.genreLabel.Location = new System.Drawing.Point(104, 541);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(49, 18);
            this.genreLabel.TabIndex = 956;
            this.genreLabel.Text = "Genre";
            // 
            // dirLabel
            // 
            this.dirLabel.AutoSize = true;
            this.dirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dirLabel.Location = new System.Drawing.Point(104, 505);
            this.dirLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dirLabel.Name = "dirLabel";
            this.dirLabel.Size = new System.Drawing.Size(61, 18);
            this.dirLabel.TabIndex = 955;
            this.dirLabel.Text = "Director";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.typeLabel.Location = new System.Drawing.Point(104, 464);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(75, 18);
            this.typeLabel.TabIndex = 954;
            this.typeLabel.Text = "DVD Type";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.titleLabel.Location = new System.Drawing.Point(104, 404);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(35, 18);
            this.titleLabel.TabIndex = 952;
            this.titleLabel.Text = "Title";
            // 
            // frmUpdateDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 676);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.relLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.dirLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.btnSearchReset);
            this.Controls.Add(this.btnSearchSubmit);
            this.Controls.Add(this.dvdUpdateLabel);
            this.Controls.Add(this.txtSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update DVD";
            this.Load += new System.EventHandler(this.frmUpdateDVD_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnSearchReset;
        private System.Windows.Forms.Button btnSearchSubmit;
        private System.Windows.Forms.Label dvdUpdateLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView grdSearch;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label relLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label dirLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}