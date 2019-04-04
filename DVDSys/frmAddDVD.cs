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
    public partial class frmAddDVD : Form
    {
        frmHome parent;

        private DVD dvd;

        public frmAddDVD()
        {
            InitializeComponent();
        }

        public frmAddDVD(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAddDVD_Load(object sender, EventArgs e)
        {
            btnID.Text = DVD.getNextDVDID().ToString("000");
            
            //Get types for drop down 
            DataSet ds = new DataSet();

            Type.getTypes(ds);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                cboType.Items.Add(dt.Rows[i][0].ToString());
            }
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

        private Boolean isValid()
        {
            //validate input
            if (txtTitle.Text.Equals(""))
            {
                MessageBox.Show("Title must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return false;
            }

            if (txtDir.Text.Equals(""))
            {
                MessageBox.Show("Director must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDir.Focus();
                return false;
            }

            if (txtGenre.Text.Equals(""))
            {
                MessageBox.Show("Genre must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGenre.Focus();
                return false ;
            }
            if (!Vali.valTypeName(txtTitle.Text))
            {
                MessageBox.Show("Title contains invalid characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return false;
            }

            if (!Vali.valName(txtDir.Text))
            {
                MessageBox.Show("Director contains invalid characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDir.Focus();
                return false;
            }

            if (!Vali.valTypeName(txtGenre.Text))
            {
                MessageBox.Show("Genre contains invalid characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGenre.Focus();
                return false;
            }

            return true;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //Validate Input
            if (isValid())
            {
                //save data in file
                char active;
                if(cboActive.Text == "yes")
                {
                    active = 'Y';
                }
                else
                {
                    active = 'N';
                }

                dvd = new DVD(Convert.ToInt32(btnID.Text), txtTitle.Text.ToUpper(), cboType.Text.ToUpper(), txtDir.Text.ToUpper(), txtGenre.Text.ToUpper(), dtpRelease.Text.ToUpper(), active);

                    dvd.addDVD();

                    //reset UI
                    txtTitle.Clear();
                    txtDir.Clear();
                    txtGenre.Clear();
                    cboActive.ResetText();

                    txtTitle.Focus();                
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            cboType.ResetText();
            txtDir.Clear();
            txtGenre.Clear();
            dtpRelease.ResetText();
            cboActive.ResetText();

            txtTitle.Focus();
        }       
    }
}
