namespace DVDSys
{
    partial class frmUpdateDVDType
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
            this.btnResetPrice = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dvdTypeLabel = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dvdPriceLabel = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetPrice
            // 
            this.btnResetPrice.Location = new System.Drawing.Point(42, 297);
            this.btnResetPrice.Name = "btnResetPrice";
            this.btnResetPrice.Size = new System.Drawing.Size(95, 23);
            this.btnResetPrice.TabIndex = 80;
            this.btnResetPrice.Text = "Reset";
            this.btnResetPrice.UseVisualStyleBackColor = true;
            this.btnResetPrice.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(198, 297);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 23);
            this.btnSubmit.TabIndex = 79;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.submit_Click);
            // 
            // dvdTypeLabel
            // 
            this.dvdTypeLabel.AutoSize = true;
            this.dvdTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdTypeLabel.Location = new System.Drawing.Point(11, 29);
            this.dvdTypeLabel.Name = "dvdTypeLabel";
            this.dvdTypeLabel.Size = new System.Drawing.Size(118, 18);
            this.dvdTypeLabel.TabIndex = 78;
            this.dvdTypeLabel.Text = "Enter DVD Type ";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(178, 27);
            this.txtType.MaxLength = 2;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(56, 20);
            this.txtType.TabIndex = 77;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(412, 24);
            this.menuStrip2.TabIndex = 74;
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
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(62, 62);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 82;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(218, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 81;
            this.btnSearch.Text = "Submit";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.updateSubmit_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(62, 91);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(289, 136);
            this.dgvSearch.TabIndex = 83;
            this.dgvSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custUpdateResults_CellDoubleClickContentClick);
            // 
            // nupPrice
            // 
            this.nupPrice.DecimalPlaces = 2;
            this.nupPrice.Location = new System.Drawing.Point(179, 233);
            this.nupPrice.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            131072});
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(55, 20);
            this.nupPrice.TabIndex = 87;
            this.nupPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 86;
            this.label1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(179, 271);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(186, 20);
            this.txtDescription.TabIndex = 85;
            // 
            // dvdPriceLabel
            // 
            this.dvdPriceLabel.AutoSize = true;
            this.dvdPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdPriceLabel.Location = new System.Drawing.Point(12, 235);
            this.dvdPriceLabel.Name = "dvdPriceLabel";
            this.dvdPriceLabel.Size = new System.Drawing.Size(81, 18);
            this.dvdPriceLabel.TabIndex = 84;
            this.dvdPriceLabel.Text = "Enter Price";
            // 
            // frmUpdateDVDType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 339);
            this.Controls.Add(this.nupPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dvdPriceLabel);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnResetPrice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dvdTypeLabel);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmUpdateDVDType";
            this.Text = "Update DVD Type";
            this.Load += new System.EventHandler(this.frmUpdateDVDType_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetPrice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label dvdTypeLabel;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.NumericUpDown nupPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label dvdPriceLabel;
    }
}