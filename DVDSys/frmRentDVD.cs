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
    public partial class frmRentDVD : Form
    {
        frmHome parent;

        Customer customer;
        private double price = 0.00;
        //
        //Initialize Form
        //
        public frmRentDVD(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        //
        //Go Back to Home
        //
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        //
        //Quit DVDSys
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //Search Customer
        //
        private void submitCustomer_Click(object sender, EventArgs e)
        {
            //Validate search
            if (!Vali.valName(txtSearch.Text))
            {
                MessageBox.Show("Searched name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //Search
            DataSet ds = new DataSet();


            dgvSearch.DataSource = Customer.getActiveCustomers(ds, txtSearch.Text.ToUpper()).Tables["stk"];
            dgvSearch.AllowUserToAddRows = false;

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
        //Search DVD
        //
        private void btnSearchDVD_Click(object sender, EventArgs e)
        {
            //Validate search
            if (!Vali.valTypeName(txtDVDName.Text))
            {
                MessageBox.Show("DVD name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //Search
            searchDVDs();
        }
        //
        //Select DVD
        //       
        private void dgvDVDSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean alreadyEntered = true;

            for (int i = 0; i < lstCart.Items.Count; i++)
            {
                if (Convert.ToInt32(dgvDVDSearch.Rows[dgvDVDSearch.CurrentCell.RowIndex].Cells[0].Value) == Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 3)))
                {
                    MessageBox.Show("DVD already in cart!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    alreadyEntered = false;
                    break;
                }
            }

            if (alreadyEntered)
            {
                //put dvd details into cart
                lstCart.Items.Add(String.Format("{0:000}", dgvDVDSearch.Rows[dgvDVDSearch.CurrentCell.RowIndex].Cells[0].Value) + " " + dgvDVDSearch.Rows[dgvDVDSearch.CurrentCell.RowIndex].Cells[2].Value.ToString() + " | " + dgvDVDSearch.Rows[dgvDVDSearch.CurrentCell.RowIndex].Cells[1].Value.ToString());

                //Add price to total
                price += Rent.getPrice(dgvDVDSearch.Rows[dgvDVDSearch.CurrentCell.RowIndex].Cells[1].Value.ToString());

                lblTotal.Text = "\u20AC" + price.ToString("0.00");
            }
        }
        //
        //Remove item from cart
        //
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex >= 0)
            {
                price -= Rent.getPrice(lstCart.SelectedItem.ToString().Substring(lstCart.SelectedItem.ToString().Length - 2, 2));


                lstCart.Items.RemoveAt(lstCart.SelectedIndex);

                lblTotal.Text = "\u20AC" + price.ToString("0.00");
                
                if(lstCart.Items.Count != 0)
                    lstCart.SelectedIndex = 0;
            }
        }
        //
        //Confirm clicked
        //
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // check that a customer has been selected

            if (lblCustName.Text.Equals(""))
            {
                MessageBox.Show("Customer Must be Selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }            
            else
            {
                DataSet ds = new DataSet();
                
                ds = Payment.getLateRental(ds, customer.getCustomerID());
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count <= 0)
                {
                    //check that at least 1 DVD is selected
                    if (lstCart.Items.Count == 0)
                    {
                        MessageBox.Show("At leaast 1 DVD Must be Selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDVDName.Focus();
                        return;
                    }
                    else
                    {
                        int rentID = Rent.getNextRentID();
                        Rent rent = new Rent(rentID, customer.getCustomerID());

                        rent.addRental();

                        for (int i = 0; i < lstCart.Items.Count; i++)
                        {
                            rent = new Rent(rentID, Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 3)));

                            rent.addRentalItem();
                        }

                        MessageBox.Show("Rental Complete!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //PAYMENT
                        Payment.makePayment(rentID, lblTotal.Text.Substring(1));

                        price = 0.0;
                        lblTotal.Text = "\u20AC" + price.ToString("0.00");

                        //Reset UI
                        clearUI();
                    }                    
                }
                else
                {
                    decimal charge = 0; 

                    for(int i = 0; i < dt.Rows.Count; i ++)
                    {
                        charge += (Convert.ToDecimal(dt.Rows[i][0]) * 3);
                    }

                    var confirmResult = MessageBox.Show("Customer owes \u20AC" + charge.ToString("0.00") + " for overdue DVDs. Pay now?", "Overdue Rental!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Payment.makePayment(Convert.ToInt32(dt.Rows[i][2]), charge.ToString("0.00"));
                            Rent.returnDVD(Convert.ToInt32(dt.Rows[i][1]));
                        }                        

                        MessageBox.Show("Customer can now rent DVD", "DVD Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        price += Convert.ToDouble(charge);
                        lblTotal.Text = "\u20AC" + price.ToString("0.00");
                        searchDVDs();
                    }
                    else
                    {
                        MessageBox.Show("Customer must pay charges before reting DVD", "Overdue Rental!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }           
            
        }
        //
        // Reset Button Clicked -- Reset UI
        //
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearUI();
        }
        //
        //Clear UI
        //
        public void clearUI()
        {
            txtSearch.Clear();
            txtDVDName.Clear();
            lstCart.Items.Clear();
            dgvDVDSearch.DataSource = null;
            dgvSearch.DataSource = null;
            lblCustName.Text = "";
            price = 0.0;
            txtSearch.Focus();
            lblTotal.Text = "\u20AC" + price.ToString("0.00");
        }
        //
        //Fill DVD data grid view
        //
        public DataSet searchDVDs()
        {
            DataSet ds = new DataSet();

            dgvDVDSearch.DataSource = DVD.getActiveDVDS(ds, txtDVDName.Text.ToUpper()).Tables["stk"];
            dgvDVDSearch.AllowUserToAddRows = false;

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //Hide cells with rented and inactive status
            foreach(DataGridViewRow row in dgvDVDSearch.Rows)
            {
                if (!row.Cells[6].Value.ToString().Equals("A "))
                {                   
                    CurrencyManager currencyManager1 = (CurrencyManager)dgvDVDSearch.BindingContext[dgvDVDSearch.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                    
                }
            }

            return ds;
        }
    }
}
