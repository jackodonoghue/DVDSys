namespace DVDSys
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDVDTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDVDTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripHome
            // 
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.dVDToolStripMenuItem,
            this.rentalToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripHome.Size = new System.Drawing.Size(1265, 25);
            this.menuStripHome.TabIndex = 46;
            this.menuStripHome.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.updateCustomerToolStripMenuItem,
            this.removeCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // updateCustomerToolStripMenuItem
            // 
            this.updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            this.updateCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.updateCustomerToolStripMenuItem.Text = "Update Customer";
            this.updateCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateCustomerToolStripMenuItem_Click);
            // 
            // removeCustomerToolStripMenuItem
            // 
            this.removeCustomerToolStripMenuItem.Name = "removeCustomerToolStripMenuItem";
            this.removeCustomerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.removeCustomerToolStripMenuItem.Text = "Remove Customer";
            this.removeCustomerToolStripMenuItem.Click += new System.EventHandler(this.removeCustomerToolStripMenuItem_Click);
            // 
            // dVDToolStripMenuItem
            // 
            this.dVDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDVDTypeToolStripMenuItem,
            this.updateDVDTypeToolStripMenuItem,
            this.addDVDToolStripMenuItem,
            this.updateDVDToolStripMenuItem,
            this.removeDVDToolStripMenuItem});
            this.dVDToolStripMenuItem.Name = "dVDToolStripMenuItem";
            this.dVDToolStripMenuItem.Size = new System.Drawing.Size(42, 19);
            this.dVDToolStripMenuItem.Text = "DVD";
            // 
            // addDVDTypeToolStripMenuItem
            // 
            this.addDVDTypeToolStripMenuItem.Name = "addDVDTypeToolStripMenuItem";
            this.addDVDTypeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addDVDTypeToolStripMenuItem.Text = "Add DVD Type";
            this.addDVDTypeToolStripMenuItem.Click += new System.EventHandler(this.addDVDTypeToolStripMenuItem_Click);
            // 
            // updateDVDTypeToolStripMenuItem
            // 
            this.updateDVDTypeToolStripMenuItem.Name = "updateDVDTypeToolStripMenuItem";
            this.updateDVDTypeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.updateDVDTypeToolStripMenuItem.Text = "Update DVD Type";
            this.updateDVDTypeToolStripMenuItem.Click += new System.EventHandler(this.updateDVDTypeToolStripMenuItem_Click);
            // 
            // addDVDToolStripMenuItem
            // 
            this.addDVDToolStripMenuItem.Name = "addDVDToolStripMenuItem";
            this.addDVDToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addDVDToolStripMenuItem.Text = "Add DVD";
            this.addDVDToolStripMenuItem.Click += new System.EventHandler(this.addDVDToolStripMenuItem_Click);
            // 
            // updateDVDToolStripMenuItem
            // 
            this.updateDVDToolStripMenuItem.Name = "updateDVDToolStripMenuItem";
            this.updateDVDToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.updateDVDToolStripMenuItem.Text = "Update DVD";
            this.updateDVDToolStripMenuItem.Click += new System.EventHandler(this.updateDVDToolStripMenuItem_Click);
            // 
            // removeDVDToolStripMenuItem
            // 
            this.removeDVDToolStripMenuItem.Name = "removeDVDToolStripMenuItem";
            this.removeDVDToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.removeDVDToolStripMenuItem.Text = "Remove DVD";
            this.removeDVDToolStripMenuItem.Click += new System.EventHandler(this.remDVDToolStripMenuItem_Click);
            // 
            // rentalToolStripMenuItem
            // 
            this.rentalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rentDVDToolStripMenuItem,
            this.returnDVDToolStripMenuItem});
            this.rentalToolStripMenuItem.Name = "rentalToolStripMenuItem";
            this.rentalToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.rentalToolStripMenuItem.Text = "Rental";
            // 
            // rentDVDToolStripMenuItem
            // 
            this.rentDVDToolStripMenuItem.Name = "rentDVDToolStripMenuItem";
            this.rentDVDToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.rentDVDToolStripMenuItem.Text = "Rent DVD";
            this.rentDVDToolStripMenuItem.Click += new System.EventHandler(this.rentDVDToolStripMenuItem_Click);
            // 
            // returnDVDToolStripMenuItem
            // 
            this.returnDVDToolStripMenuItem.Name = "returnDVDToolStripMenuItem";
            this.returnDVDToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.returnDVDToolStripMenuItem.Text = "Return DVD";
            this.returnDVDToolStripMenuItem.Click += new System.EventHandler(this.returnDVDToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueAnalysisToolStripMenuItem,
            this.rentalAnalysisToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 19);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // revenueAnalysisToolStripMenuItem
            // 
            this.revenueAnalysisToolStripMenuItem.Name = "revenueAnalysisToolStripMenuItem";
            this.revenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.revenueAnalysisToolStripMenuItem.Text = "Revenue Analysis";
            this.revenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // rentalAnalysisToolStripMenuItem
            // 
            this.rentalAnalysisToolStripMenuItem.Name = "rentalAnalysisToolStripMenuItem";
            this.rentalAnalysisToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.rentalAnalysisToolStripMenuItem.Text = "Rental Analysis";
            this.rentalAnalysisToolStripMenuItem.Click += new System.EventHandler(this.dvdAnalysisToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // picHome
            // 
            this.picHome.Image = ((System.Drawing.Image)(resources.GetObject("picHome.Image")));
            this.picHome.Location = new System.Drawing.Point(0, 29);
            this.picHome.Margin = new System.Windows.Forms.Padding(4);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(2182, 993);
            this.picHome.TabIndex = 47;
            this.picHome.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.btnLogin.Location = new System.Drawing.Point(547, 600);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 61);
            this.btnLogin.TabIndex = 48;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 720);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.menuStripHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDVDTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDVDTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentalAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Button btnLogin;
    }
}