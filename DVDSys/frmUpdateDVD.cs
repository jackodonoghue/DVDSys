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
        private int ID;

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

        private void btnSearchSubmit_Click(object sender, EventArgs e)
        {
            //validate input
            if (!Vali.valTypeName(txtSearch.Text))
            {
                MessageBox.Show("Title character invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }
            
            else
            {
                //search DVD


                //Search
                DataSet ds = new DataSet();

                String searched = txtSearch.Text;

                dgvSearch.DataSource = DVD.getDVDS(ds, searched).Tables["stk"];

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //reset UI
                txtSearch.Clear();

                txtSearch.Focus();
            }           
        }

        private void dgvSearch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dgvSearch.Rows[rowIndex];

            ID = int.Parse(row.Cells[0].Value.ToString());
            cboType.Text = (String)row.Cells[1].Value;
            txtTitle.Text = (String)row.Cells[2].Value;
            txtDir.Text = (String)row.Cells[3].Value;
            txtGenre.Text = (String)row.Cells[4].Value;
            dtpRelease.Value = Convert.ToDateTime(row.Cells[5].Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //validate input
            if (isValid())
            {
                //save data in file 
                DVD dvd = new DVD(ID, txtTitle.Text, cboType.Text, txtDir.Text, txtGenre.Text, dtpRelease.Text, 'y');

                MessageBox.Show("dvd " + dtpRelease.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dvd.updateDVD();

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
        //
        //Validate Inputs
        //
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
                return false;
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


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            cboType.ResetText();
            txtDir.Clear();
            txtGenre.Clear();
            dtpRelease.ResetText();
            
            txtTitle.Focus();
        }
    }
}
