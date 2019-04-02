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
    public partial class frmRemoveCustomer : Form
    {
        frmHome parent;

        String custidString;
        int custid;
        String name;

        public frmRemoveCustomer()
        {
            InitializeComponent();
        }

        public frmRemoveCustomer(frmHome Parent)
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

        private void searchSubmit_Click(object sender, EventArgs e)
        {
            //Validate search
            if (!Vali.valName(txtName.Text))
            {
                MessageBox.Show("Invalid name", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
                txtName.Focus();
                return;
            }

            //Get search results
            DataSet ds = new DataSet();

            String searched = txtName.Text;

            dgvSearchResults.DataSource = Customer.getCustomers(ds, searched).Tables["stk"];

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
                txtName.Focus();
                return;
            }

            //reset UI
            txtName.Clear();
            txtName.Focus();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //remove account

            var confirmResult = MessageBox.Show("Are you sure to delete customer " + name +"?", "Confirm Delete!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Customer.removeCustomer(custid);
            }
            else
            {
                // If 'No', do something here.
            }


            //reset UI
            txtName.Clear();    

            txtName.Focus();

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            
        }

        private void dataSetGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            
            DataGridViewRow row = dgvSearchResults.Rows[rowIndex];

            custidString = row.Cells[0].Value.ToString();
            custid = int.Parse(custidString);

            name = (String)row.Cells[1].Value +  " " + (String)row.Cells[2].Value; ;
        }

        private void frmRemoveCustomer_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
