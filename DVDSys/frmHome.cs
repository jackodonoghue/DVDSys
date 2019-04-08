using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDSys
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            this.menuStripHome.Visible = false;           
        }

        public void showMenu(String hUsername)
        {
            if (frmLogin.loggedIn == false)
            {
                this.menuStripHome.Visible = false;
            }
            else
            {
                this.menuStripHome.Visible = true;
                if (!hUsername.Equals("8C-69-76-E5-B5-41-04-15-BD-E9-08-BD-4D-EE-15-DF-B1-67-A9-C8-73-FC-4B-B8-A8-1F-6F-2A-B4-48-A9-18"))
                {
                    menuStripHome.Items[3].Visible = false;
                }
                    btnLogin.Visible = false;
            }
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCustomer nextForm = new frmAddCustomer(this);
            nextForm.Show();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCustomer nextForm = new frmUpdateCustomer(this);
            nextForm.Show();
        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveCustomer nextForm = new frmRemoveCustomer(this);
            nextForm.Show();
        }

        private void addDVDTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddDVDType nextForm = new frmAddDVDType(this);
            nextForm.Show();
        }

        private void updateDVDTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateDVDType nextForm = new frmUpdateDVDType(this);
            nextForm.Show();
        }

        private void addDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddDVD nextForm = new frmAddDVD(this);
            nextForm.Show();
        }

        private void updateDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateDVD nextForm = new frmUpdateDVD(this);
            nextForm.Show();
        }

        private void remDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveDVD nextForm = new frmRemoveDVD(this);
            nextForm.Show();
        }

        private void rentDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRentDVD nextForm = new frmRentDVD(this);
            nextForm.Show();
        }

        private void returnDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDVDRet nextForm = new frmDVDRet(this);
            nextForm.Show();
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAnalyseRevenue nextForm = new frmAnalyseRevenue(this);
            nextForm.Show();
        }

        private void dvdAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDVDAnalysis nextForm = new frmDVDAnalysis(this);
            nextForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin nextForm = new frmLogin(this);
            nextForm.Show();
        }
    }
}
