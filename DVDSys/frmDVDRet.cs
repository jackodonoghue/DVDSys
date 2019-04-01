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
        private Customer customer;

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
        //
        //Search Customer
        //
        private void submitCustomer_Click(object sender, EventArgs e)
        {
            //Validate search
            if (!Customer.valName(txtSearch.Text))
            {
                MessageBox.Show("Searched name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //Search
            DataSet ds = new DataSet();


            dgvSearch.DataSource = Customer.getCustomers(ds, txtSearch.Text.ToUpper()).Tables["stk"];

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //Select Customer
        //
        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dgvSearch.Rows[rowIndex];

            customer = new Customer();

            customer.setCustomerID(int.Parse(row.Cells[0].Value.ToString()));

            lblCustName.Text = (String)row.Cells[1].Value + " " + (String)row.Cells[2].Value;
        }
        //
        //Get rented DVDs
        //
        private void getRented(object sender, EventArgs e)
        {

            //Search
            DataSet ds = new DataSet();


            dgvSearch.DataSource = Customer.getCustomers(ds, txtSearch.Text.ToUpper()).Tables["stk"];

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //Select DVD
        //       
        private void dgvDVDSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean alreadyEntered = true;

            for (int i = 0; i < lstCart.Items.Count; i++)
            {
                if (Convert.ToInt32(dgvDVDrented.Rows[dgvDVDrented.CurrentCell.RowIndex].Cells[0].Value) == Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 3)))
                {
                    MessageBox.Show("DVD already in cart!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    alreadyEntered = false;
                    break;
                }
            }

            if (alreadyEntered)
            {
                //put dvd details into cart
                lstCart.Items.Add(String.Format("{0:000}", dgvDVDrented.Rows[dgvDVDrented.CurrentCell.RowIndex].Cells[0].Value) + " " + dgvDVDrented.Rows[dgvDVDrented.CurrentCell.RowIndex].Cells[2].Value.ToString());

                //Add price to total
               // price += Rent.getPrice(dgvDVDSearch.Rows[dgvDVDSearch.CurrentCell.RowIndex].Cells[1].Value.ToString());

              //  lblTotal.Text = "\u20AC" + price.ToString("0.00");
            }
        }
        //
        //Remove item from cart
        //
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex >= 0)
            {
                lstCart.Items.RemoveAt(lstCart.SelectedIndex);
            }
        }
        //
        //Confirm clicked
        //
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int rentID = Rent.getNextRentID();
            Rent rent = new Rent(rentID, customer.getCustomerID());

            rent.addRental();

            for (int i = 0; i < lstCart.Items.Count; i++)
            {
                rent = new Rent(rentID, Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 3)));

                rent.addRentalItem();
            }

            MessageBox.Show("Rental Complete!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //PAYMENT
            Rent.makePayment(rentID, lblTotal.Text.Substring(1));
        }
        //
        // Reset Button Clicked -- Reset UI
        //
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            lstCart.Items.Clear();
            lblCustName.Text = "";
        }
    }
}
