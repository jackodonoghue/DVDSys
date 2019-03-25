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
    public partial class frmUpdateDVD : Form
    {
        frmHome parent;

        public frmUpdateDVD()
        {
            InitializeComponent();
        }

        public frmUpdateDVD(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        private void frmUpdateDVD_Load(object sender, EventArgs e)
        {

        }

        private void submitName_Click(object sender, EventArgs e)
        {
            //validate input
            if (txtSearch.Text.Equals(""))
            {
                MessageBox.Show("Title must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

           
            //save data in file (not doing)

            //display confirmation message
            MessageBox.Show("DVD " + txtTitle.Text + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtSearch.Clear();

            txtSearch.Focus();

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //validate input
            /*if (txtTitle.Text.Equals(""))
            {
                MessageBox.Show("Title must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }

            if (txtDir.Text.Equals(""))
            {
                MessageBox.Show("Director must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDir.Focus();
                return;
            }

            if (txtGenre.Text.Equals(""))
            {
                MessageBox.Show("Genre must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGenre.Focus();
                return;
            }

            if (activeTB.Text.Equals(""))
            {
                MessageBox.Show("Active must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activeTB.Focus();
                return;
            }*/

            //save data in file (not doing)

            //display confirmation message
            MessageBox.Show("DVD " + txtTitle.Text + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtTitle.Clear();
            txtDir.Clear();
            txtGenre.Clear();
            //activeTB.Clear();

            txtTitle.Focus();

        }
    }
}
