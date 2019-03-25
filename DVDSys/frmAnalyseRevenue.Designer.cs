namespace DVDSys
{
    partial class frmAnalyseRevenue
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
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.dvdNameLabel = new System.Windows.Forms.Label();
            this.dvdNameTB = new System.Windows.Forms.TextBox();
            this.RevenueGridView = new System.Windows.Forms.DataGridView();
            this.DVDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(387, 25);
            this.menuStrip1.TabIndex = 20;
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
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(13, 39);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(74, 18);
            this.startDateLabel.TabIndex = 21;
            this.startDateLabel.Text = "Start Date";
            this.startDateLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(103, 33);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(257, 24);
            this.startDateTimePicker.TabIndex = 22;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(103, 80);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(257, 24);
            this.endDateTimePicker.TabIndex = 24;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(13, 86);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(69, 18);
            this.endDateLabel.TabIndex = 23;
            this.endDateLabel.Text = "End Date";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(276, 177);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 38);
            this.submit.TabIndex = 25;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // dvdNameLabel
            // 
            this.dvdNameLabel.AutoSize = true;
            this.dvdNameLabel.Location = new System.Drawing.Point(13, 134);
            this.dvdNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dvdNameLabel.Name = "dvdNameLabel";
            this.dvdNameLabel.Size = new System.Drawing.Size(83, 18);
            this.dvdNameLabel.TabIndex = 26;
            this.dvdNameLabel.Text = "DVD Name";
            // 
            // dvdNameTB
            // 
            this.dvdNameTB.Location = new System.Drawing.Point(103, 131);
            this.dvdNameTB.Name = "dvdNameTB";
            this.dvdNameTB.Size = new System.Drawing.Size(257, 24);
            this.dvdNameTB.TabIndex = 27;
            // 
            // RevenueGridView
            // 
            this.RevenueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RevenueGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DVDID,
            this.Title,
            this.Revenue});
            this.RevenueGridView.Location = new System.Drawing.Point(25, 221);
            this.RevenueGridView.Name = "RevenueGridView";
            this.RevenueGridView.Size = new System.Drawing.Size(326, 219);
            this.RevenueGridView.TabIndex = 28;
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
            // Revenue
            // 
            this.Revenue.HeaderText = "Revenue";
            this.Revenue.Name = "Revenue";
            // 
            // frmAnalyseRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 455);
            this.Controls.Add(this.RevenueGridView);
            this.Controls.Add(this.dvdNameTB);
            this.Controls.Add(this.dvdNameLabel);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnalyseRevenue";
            this.Text = "Analyse Revenue";
            this.Load += new System.EventHandler(this.frmAnalyseRevenue_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label dvdNameLabel;
        private System.Windows.Forms.TextBox dvdNameTB;
        private System.Windows.Forms.DataGridView RevenueGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
    }
}