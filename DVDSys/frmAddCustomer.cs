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
    public partial class frmAddCustomer : Form
    {
        private Customer newCustomer = new Customer();
        private int nextCustID = Customer.getNextCustID();

        frmHome parent;

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        public frmAddCustomer(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            txtCustID.Text = Customer.getNextCustID().ToString("000");
            dtpDOB.MaxDate = (DateTime.Today.AddYears(-18));
            
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
        //
        //Submit button clicked
        //
        private void submit_Click(object sender, EventArgs e)
        {
            // validate data
            if(txtFName.Text.Equals(""))
            {
                MessageBox.Show("First Name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }

            if (txtSName.Text.Equals(""))
            {
                MessageBox.Show("Last Name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSName.Focus();
                return;
            }

            if (txtAddress1.Text.Equals(""))
            {
                MessageBox.Show("Address line 1 must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress1.Focus();
                return;
            }

            if (txtAddress2.Text.Equals(""))
            {
                MessageBox.Show("Address line 2 must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress2.Focus();
                return;
            }

            if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone number must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if(!Vali.valName(txtFName.Text))
            {
                MessageBox.Show("First Name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }

            if (!Vali.valName(txtSName.Text))
            {
                MessageBox.Show("Last Name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSName.Focus();
                return;
            }

            if (!(Vali.valPhoneNumber(txtPhone.Text)) || txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone number invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (!Vali.valName(txtAddress1.Text))
            {
                MessageBox.Show("Address invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress1.Focus();
                return;
            }

            if (!Vali.valName(txtAddress2.Text))
            {
                MessageBox.Show("Address invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress2.Focus();
                return;
            }

            if(!chkMale.Checked && !chkFemale.Checked)
            {
                MessageBox.Show("Gender must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //save in DB
            newCustomer.setCustomerID(nextCustID);
            newCustomer.setFName(txtFName.Text.ToUpper());
            newCustomer.setLName(txtSName.Text.ToUpper());
            newCustomer.setDOB(dtpDOB.Text);
            newCustomer.setAddress(txtAddress1.Text.ToUpper() + ", " + txtAddress2.Text.ToUpper());
            if (chkMale.Checked)
                newCustomer.setGender('M');
            else
                newCustomer.setGender('F');
            
            newCustomer.setPhoneNumber(txtPhone.Text.ToUpper());
            newCustomer.setAccountStatus('A');

            if(!newCustomer.alreadyExists())
                newCustomer.addCustomer();

            //reset UI
            txtCustID.Text = Customer.getNextCustID().ToString("000");
            txtFName.Clear();
            txtSName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            chkMale.Checked = false;
            chkMale.Checked = false;
            txtPhone.Clear();

            txtFName.Focus();
             
        }
        //
        //Check if Check Box is Clicked
        //
        private void maleCB_Clicked(object sender, EventArgs e)
        {
            chkMale.Checked = true;

            chkFemale.Checked = false;
        }

        private void femaleCB_Clicked(object sender, EventArgs e)
        {
            chkFemale.Checked = true;

            chkMale.Checked = false;
        }
        //
        //Reset UI
        //
        private void Reset_Click(object sender, EventArgs e)
        {            
            txtFName.Clear();
            txtSName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            chkMale.Checked = false;
            chkMale.Checked = false;
            txtPhone.Clear();

            txtFName.Focus();
        }
    }

}

