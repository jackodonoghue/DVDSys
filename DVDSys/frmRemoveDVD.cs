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

        private int ID;
        private string title;

        public frmRemoveDVD()
        {
            InitializeComponent();
        }

        public frmRemoveDVD(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearchSubmit_Click(object sender, EventArgs e)
        {
            //validate input
            if (!Vali.valTypeName(txtSearch.Text))
            {
                MessageBox.Show("Title character invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            else
            {
                //Search
                DataSet ds = new DataSet();

                String searched = txtSearch.Text;

                dgvSearch.DataSource = DVD.getActiveDVDS(ds, searched.ToUpper()).Tables["stk"];

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //reset UI
                txtSearch.Clear();

                txtSearch.Focus();
            }
        }

        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dgvSearch.Rows[rowIndex];

            ID = int.Parse(row.Cells[0].Value.ToString());
            title = (String)row.Cells[2].Value;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //validate input
            if (!Vali.valTypeName(txtSearch.Text))
            {
                MessageBox.Show("Invalid character in DVD Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + title, "Delete DVD", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    String status = DVD.getDVDStatus(ID);

                    //save data in file
                    if(status.Equals("A "))
                    {
                        DVD.removeDVD(ID, title);
                    }
                    else
                    {
                        MessageBox.Show("DVD could not be removed as DVD is currently unavailable", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    

                    //reset UI
                    txtSearch.Clear();

                    txtSearch.Focus();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }                
            }
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            //reset UI
            txtSearch.Clear();

            txtSearch.Focus();
        }
    }
}
