namespace DVDSys
{
    partial class frmAddDVDType
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
            this.dvdPriceLabel = new System.Windows.Forms.Label();
            this.dvdTypeLabel = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
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
            this.menuStrip2.Size = new System.Drawing.Size(580, 30);
            this.menuStrip2.TabIndex = 67;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.back_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(45, 24);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.exit_Click);
            // 
            // dvdPriceLabel
            // 
            this.dvdPriceLabel.AutoSize = true;
            this.dvdPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdPriceLabel.Location = new System.Drawing.Point(18, 102);
            this.dvdPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dvdPriceLabel.Name = "dvdPriceLabel";
            this.dvdPriceLabel.Size = new System.Drawing.Size(81, 18);
            this.dvdPriceLabel.TabIndex = 69;
            this.dvdPriceLabel.Text = "Enter Price";
            // 
            // dvdTypeLabel
            // 
            this.dvdTypeLabel.AutoSize = true;
            this.dvdTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dvdTypeLabel.Location = new System.Drawing.Point(18, 55);
            this.dvdTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dvdTypeLabel.Name = "dvdTypeLabel";
            this.dvdTypeLabel.Size = new System.Drawing.Size(118, 18);
            this.dvdTypeLabel.TabIndex = 71;
            this.dvdTypeLabel.Text = "Enter DVD Type ";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtType.Location = new System.Drawing.Point(268, 53);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtType.MaximumSize = new System.Drawing.Size(448, 300);
            this.txtType.MaxLength = 2;
            this.txtType.MinimumSize = new System.Drawing.Size(28, 20);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(80, 24);
            this.txtType.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnReset.Location = new System.Drawing.Point(84, 223);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 32);
            this.btnReset.TabIndex = 60;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSubmit.Location = new System.Drawing.Point(318, 223);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 32);
            this.btnSubmit.TabIndex = 50;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(18, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 75;
            this.label1.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDescription.Location = new System.Drawing.Point(268, 159);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(277, 24);
            this.txtDescription.TabIndex = 30;
            // 
            // nupPrice
            // 
            this.nupPrice.DecimalPlaces = 2;
            this.nupPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nupPrice.Location = new System.Drawing.Point(268, 100);
            this.nupPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nupPrice.Name = "nupPrice";
            this.nupPrice.Size = new System.Drawing.Size(82, 24);
            this.nupPrice.TabIndex = 20;
            this.nupPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmAddDVDType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 288);
            this.Controls.Add(this.nupPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dvdTypeLabel);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.dvdPriceLabel);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(742, 677);
            this.Name = "frmAddDVDType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add DVD Type";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label dvdPriceLabel;
        private System.Windows.Forms.Label dvdTypeLabel;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nupPrice;
    }
}