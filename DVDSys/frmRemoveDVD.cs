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
    public partial class frmRemoveDVD : Form
    {
        frmHome parent;
        public frmRemoveDVD()
        {
            InitializeComponent();
        }

        public frmRemoveDVD(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRemoveDVD_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //validate input
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("DVD Name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            if (!txtStatus.Text.Equals("R"))
            {
                MessageBox.Show("Status must be changed to 'R'", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStatus.Focus();
                return;
            }


            //save data in file (not doing)

            //display confirmation message
            MessageBox.Show("DVD removed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSearch.Clear();
            txtStatus.Clear();

            txtSearch.Focus();

        }
    }
}
