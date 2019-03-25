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
    public partial class frmUpdateDVDType : Form
    {
        frmHome parent;

        public frmUpdateDVDType()
        {
            InitializeComponent();
        }

        public frmUpdateDVDType(frmHome Parent)
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
        private void dvdPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void dvdNameUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }

        private void custUpdateResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUpdateDVDType_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //validate input
            if (txtType.Text.Equals(""))
            {
                MessageBox.Show("DVD Type must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                return;
            }

            if (txtPrice.Text.Equals(""))
            {
                MessageBox.Show("First name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }


            //save data in file (not doing)

            //display confirmation message
            MessageBox.Show("DVD Type " + txtType.Text + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtType.Clear();
            txtPrice.Clear();

            txtType.Focus();

        }
    }
}
