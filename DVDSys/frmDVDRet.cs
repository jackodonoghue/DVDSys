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
    public partial class frmDVDRet : Form
    {
        frmHome parent;

        public frmDVDRet()
        {
            InitializeComponent();
        }

        public frmDVDRet(frmHome Parent)
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

        private void frmDVDRet_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //validate input
            if (txtDVDID.Text.Equals(""))
            {
                MessageBox.Show("DVDID must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVDID.Focus();
                return;
            }


            //save data in file (not doing)

            //display confirmation message
            MessageBox.Show("DVD returned!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            txtDVDID.Clear();
            
            txtDVDID.Focus();

        }
    }
}
