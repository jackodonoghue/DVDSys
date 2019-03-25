namespace DVDSys
{
    partial class frmRemoveDVD
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
            this.dvdStatusLabel = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnResetStatus = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dvdRemoveResults = new System.Windows.Forms.DataGridView();
            this.DVDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVDType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dvdRemoveLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvdRemoveResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dvdStatusLabel
            // 
            this.dvdStatusLabel.AutoSize = true;
            this.dvdStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdStatusLabel.Location = new System.Drawing.Point(79, 318);
            this.dvdStatusLabel.Name = "dvdStatusLabel";
            this.dvdStatusLabel.Size = new System.Drawing.Size(85, 18);
            this.dvdStatusLabel.TabIndex = 51;
            this.dvdStatusLabel.Text = "DVD Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(249, 319);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(47, 20);
            this.txtStatus.TabIndex = 50;
            // 
            // btnResetStatus
            // 
            this.btnResetStatus.Location = new System.Drawing.Point(66, 392);
            this.btnResetStatus.Name = "btnResetStatus";
            this.btnResetStatus.Size = new System.Drawing.Size(95, 23);
            this.btnResetStatus.TabIndex = 49;
            this.btnResetStatus.Text = "Reset";
            this.btnResetStatus.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(216, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 41);
            this.btnSubmit.TabIndex = 48;
            this.btnSubmit.Text = "Confirm DVD Removal";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(418, 24);
            this.menuStrip2.TabIndex = 66;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.back_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.exit_Click);
            // 
            // dvdRemoveResults
            // 
            this.dvdRemoveResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvdRemoveResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DVDID,
            this.Title,
            this.DVDType,
            this.Director,
            this.Genre,
            this.ReleaseDate,
            this.Active});
            this.dvdRemoveResults.Location = new System.Drawing.Point(12, 108);
            this.dvdRemoveResults.Name = "dvdRemoveResults";
            this.dvdRemoveResults.Size = new System.Drawing.Size(389, 177);
            this.dvdRemoveResults.TabIndex = 65;
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
            this.btnReset.Location = new System.Drawing.Point(60, 79);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 23);
            this.btnReset.TabIndex = 64;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(216, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Submit";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dvdRemoveLabel
            // 
            this.dvdRemoveLabel.AutoSize = true;
            this.dvdRemoveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdRemoveLabel.Location = new System.Drawing.Point(35, 40);
            this.dvdRemoveLabel.Name = "dvdRemoveLabel";
            this.dvdRemoveLabel.Size = new System.Drawing.Size(126, 18);
            this.dvdRemoveLabel.TabIndex = 62;
            this.dvdRemoveLabel.Text = "Enter DVD Name ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(202, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 20);
            this.txtSearch.TabIndex = 61;
            // 
            // frmRemoveDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 454);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dvdRemoveResults);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dvdRemoveLabel);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dvdStatusLabel);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnResetStatus);
            this.Controls.Add(this.btnSubmit);
            this.Name = "frmRemoveDVD";
            this.Text = "Remove DVD";
            this.Load += new System.EventHandler(this.frmRemoveDVD_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvdRemoveResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dvdStatusLabel;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnResetStatus;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridView dvdRemoveResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label dvdRemoveLabel;
        private System.Windows.Forms.TextBox txtSearch;
    }
}