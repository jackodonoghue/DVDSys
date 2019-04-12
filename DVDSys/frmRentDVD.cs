using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private int rentID;
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


            grdSearch.DataSource = Customer.getActiveCustomers(ds, txtSearch.Text.ToUpper()).Tables["stk"];
            grdSearch.AllowUserToAddRows = false;

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

            DataGridViewRow row = grdSearch.Rows[rowIndex];

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
                if (Convert.ToInt32(grdDVDSearch.Rows[grdDVDSearch.CurrentCell.RowIndex].Cells[0].Value) == Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 3)))
                {
                    MessageBox.Show("DVD already in cart!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    alreadyEntered = false;
                    break;
                }
            }

            if (alreadyEntered)
            {
                //put dvd details into cart
                lstCart.Items.Add(String.Format("{0:000}", grdDVDSearch.Rows[grdDVDSearch.CurrentCell.RowIndex].Cells[0].Value) + " " + grdDVDSearch.Rows[grdDVDSearch.CurrentCell.RowIndex].Cells[2].Value.ToString() + " | " + grdDVDSearch.Rows[grdDVDSearch.CurrentCell.RowIndex].Cells[1].Value.ToString());

                //Add price to total
                price += Rent.getPrice(grdDVDSearch.Rows[grdDVDSearch.CurrentCell.RowIndex].Cells[1].Value.ToString());

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
               // MessageBox.Show(dt.Rows[0][0].ToString());

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
                        rentID = Rent.getNextRentID();
                        Rent rent = new Rent(rentID, customer.getCustomerID());

                        rent.addRental();

                        for (int i = 0; i < lstCart.Items.Count; i++)
                        {
                            MessageBox.Show(lstCart.Items[0].ToString().Substring(0, 3));

                            if(int.TryParse(lstCart.Items[i].ToString().Substring(0, 1), out int n))
                            {
                                rent = new Rent(rentID, Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 3)));

                                rent.addRentalItem();

                            }
                        }

                        MessageBox.Show("Rental Complete!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //PAYMENT
                        Payment.makePayment(rentID, lblTotal.Text.Substring(1));

                        getInvoice();

                        //Reset UI
                        price = 0.0;
                        lblTotal.Text = "\u20AC" + price.ToString("0.00");
                                                
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
                            Rent.returnDVD(Convert.ToInt32(dt.Rows[i][1]));
                        }

                        //Add payments to payments file with rentid of overdue rental
                        Payment.makePayment(Convert.ToInt32(dt.Rows[0][2]), charge.ToString("0.00"));

                        price += Convert.ToDouble(charge);
                        lblTotal.Text = "\u20AC" + price.ToString("0.00");
                        searchDVDs();

                        //Add price of overdue to listbox
                        lstCart.Items.Add("Overdue rentals paid\t" + charge.ToString("0.00"));

                        MessageBox.Show("Customer can now rent DVD", "DVD Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                    }
                    else
                    {
                        MessageBox.Show("Customer must pay charges before renting DVD", "Overdue Rental!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            grdDVDSearch.DataSource = null;
            grdSearch.DataSource = null;
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

            grdDVDSearch.DataSource = DVD.getActiveDVDS(ds, txtDVDName.Text.ToUpper()).Tables["stk"];
            grdDVDSearch.AllowUserToAddRows = false;

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //Hide cells with rented and inactive status
            foreach(DataGridViewRow row in grdDVDSearch.Rows)
            {
                if (!row.Cells[6].Value.ToString().Equals("A "))
                {                   
                    CurrencyManager currencyManager1 = (CurrencyManager)grdDVDSearch.BindingContext[grdDVDSearch.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                    
                }
            }

            return ds;
        }
        //
        //Create Invoice
        //
        private void getInvoice()
        {
            lblRentID.Text = rentID.ToString();
            lblDateIss.Text = DateTime.Today.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            lblCustInv.Text = lblCustName.Text;
            lblTot.Text += " \u20AC" + price.ToString("0.00");
            lblRetDate.Text += DateTime.Today.AddDays(3.0).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            for(int i = 0; i < lstCart.Items.Count; i++)
            {
                lstInv.Items.Add(lstCart.Items[i].ToString());
            }

            grpInvoice.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grpInvoice.Visible = false;
        }
        //
        //Print invoice
        //
        private void doc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(pnlInvoice.Width, pnlInvoice.Height, pnlInvoice.CreateGraphics());
            pnlInvoice.DrawToBitmap(bmp, new Rectangle(0, 0, pnlInvoice.Width, pnlInvoice.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(doc_PrintPage);
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = doc;
            DialogResult result = ppd.ShowDialog();

            if (result == DialogResult.OK)
            {
                doc.Print();
            }
        }

    }
}
