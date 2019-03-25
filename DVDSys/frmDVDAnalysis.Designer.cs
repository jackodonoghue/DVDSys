namespace DVDSys
{
    partial class frmDVDAnalysis
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
            this.DVDCountGridView = new System.Windows.Forms.DataGridView();
            this.DVDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVDCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvdNameTB = new System.Windows.Forms.TextBox();
            this.dvdNameLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DVDCountGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DVDCountGridView
            // 
            this.DVDCountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVDCountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DVDID,
            this.Title,
            this.DVDCount});
            this.DVDCountGridView.Location = new System.Drawing.Point(25, 217);
            this.DVDCountGridView.Name = "DVDCountGridView";
            this.DVDCountGridView.Size = new System.Drawing.Size(326, 219);
            this.DVDCountGridView.TabIndex = 37;
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
            // DVDCount
            // 
            this.DVDCount.HeaderText = "DVDCount";
            this.DVDCount.Name = "DVDCount";
            // 
            // dvdNameTB
            // 
            this.dvdNameTB.Location = new System.Drawing.Point(103, 127);
            this.dvdNameTB.Name = "dvdNameTB";
            this.dvdNameTB.Size = new System.Drawing.Size(257, 20);
            this.dvdNameTB.TabIndex = 36;
            // 
            // dvdNameLabel
            // 
            this.dvdNameLabel.AutoSize = true;
            this.dvdNameLabel.Location = new System.Drawing.Point(13, 130);
            this.dvdNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dvdNameLabel.Name = "dvdNameLabel";
            this.dvdNameLabel.Size = new System.Drawing.Size(61, 13);
            this.dvdNameLabel.TabIndex = 35;
            this.dvdNameLabel.Text = "DVD Name";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(276, 173);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 38);
            this.submit.TabIndex = 34;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(103, 76);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(257, 20);
            this.endDateTimePicker.TabIndex = 33;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(13, 82);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 32;
            this.endDateLabel.Text = "End Date";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(103, 29);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(257, 20);
            this.startDateTimePicker.TabIndex = 31;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(13, 35);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 30;
            this.startDateLabel.Text = "Start Date";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(376, 25);
            this.menuStrip1.TabIndex = 29;
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
            // frmDVDAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 457);
            this.Controls.Add(this.DVDCountGridView);
            this.Controls.Add(this.dvdNameTB);
            this.Controls.Add(this.dvdNameLabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmDVDAnalysis";
            this.Text = "DVD Analysis";
            this.Load += new System.EventHandler(this.frmDVDAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVDCountGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DVDCountGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDCount;
        private System.Windows.Forms.TextBox dvdNameTB;
        private System.Windows.Forms.Label dvdNameLabel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}