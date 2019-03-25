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
    public partial class frmRentDVD : Form
    {
        frmHome parent;
        public frmRentDVD()
        {
            InitializeComponent();
        }
        public frmRentDVD(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        private void frmRentDVD_Load(object sender, EventArgs e)
        {

        }        

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //validate input
            if (txtRent.Text.Equals(""))
            {
                MessageBox.Show("DVDID must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRent.Focus();
                return;
            }

            if (txtRent.Text.Equals(""))
            {
                MessageBox.Show("DVDID must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRent.Focus();
                return;
            }


            //save data in file (not doing)

            //display confirmation message
            MessageBox.Show("DVD Rented!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtDvd.Clear();

            txtDvd.Focus();

        }
    }
}
