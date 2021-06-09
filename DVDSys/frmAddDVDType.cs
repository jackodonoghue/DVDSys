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
            Close();
            parent.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //validate input
            if (txtType.Text.Equals(""))
            {
                MessageBox.Show("DVD DVDType must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                return;
            }

            if (nudPrice.Value == 0)
            {
                MessageBox.Show("DVDType Price must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudPrice.Focus();
                return;
            }


            //add to database
            DVDType type = new DVDType(txtType.Text.ToUpper(), txtDescription.Text.ToUpper(), Convert.ToDouble(nudPrice.Value));

            if(!type.AlreadyExists())
            {
                 type.AddType();
                                
                //reset UI
                txtType.Clear();
                nudPrice.Value = 0;
                txtDescription.Clear();

                txtType.Focus();
            }
            else
            {
               txtType.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset UI
            txtType.Clear();
            nudPrice.Value = 0;
            txtDescription.Clear();
        }
    }
}
