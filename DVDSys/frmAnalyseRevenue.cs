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
    public partial class frmAnalyseRevenue : Form
    {
        frmHome parent;
        public frmAnalyseRevenue()
        {
            InitializeComponent();
        }
        public frmAnalyseRevenue(frmHome Parent)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAnalyseRevenue_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //validate input
            if (dvdNameTB.Text.Equals(""))
            {
                MessageBox.Show("DVD Name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dvdNameTB.Focus();
                return;
            }


             //reset UI
            dvdNameTB.Clear();
            
            dvdNameTB.Focus();

        }
    }
}
