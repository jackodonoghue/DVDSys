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
            if (txtType.Text.Equals(""))
            {
                MessageBox.Show("DVD Type must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                return;
            }

            if (nudPrice.Value == 0)
            {
                MessageBox.Show("Type Price must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudPrice.Focus();
                return;
            }


            //add to database
            Type type = new Type(txtType.Text.ToUpper(), txtDescription.Text.ToUpper(), Convert.ToDouble(nudPrice.Value));

            if(!type.alreadyExists())
            {
                 type.addType();
                                
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
