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
    public partial class frmAddDVDType : Form
    {

        frmHome parent;

        public frmAddDVDType()
        {
            InitializeComponent();
        }


        public frmAddDVDType(frmHome Parent)
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

        private void submit_Click(object sender, EventArgs e)
        {
            //validate input
           /* if (txtType.Text.Equals(""))
            {
                MessageBox.Show("DVD Type must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                return;
            }

            if (txtPrice.Text.Equals(""))
            {
                MessageBox.Show("DVD Price must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }*/


            //add to database
            Type type = new Type(txtType.Text, txtDescription.Text, Convert.ToDouble(nupPrice.Value));

            type.addCustomer();

            //display confirmation message
            MessageBox.Show("DVD Type " + txtType.Text + " Added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtType.Clear();
            nupPrice.Value = 0;
            txtDescription.Clear();

            txtType.Focus();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset UI
            txtType.Clear();
            nupPrice.Value = 0;
            txtDescription.Clear();
        }
    }
}
