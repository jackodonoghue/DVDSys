﻿using System;
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
    public partial class frmUpdateCustomer : Form
    {
        frmHome parent;

        private int CustID;
        private String CustIDString;



        public frmUpdateCustomer()
        {
            InitializeComponent();
        }

        public frmUpdateCustomer(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void back__Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void updateSubmit_Click(object sender, EventArgs e)
        {
            //Validate search
            if (!Validation.ValidateName(txtSearch.Text))
            {
                MessageBox.Show("Searched name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }
                        
            //Search
            DataSet ds = new DataSet();

            String searched = txtSearch.Text;

            grdSearch.DataSource = Customer.getCustomers(ds, searched.ToUpper()).Tables["stk"];
            grdSearch.AllowUserToAddRows = false;

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }       
            
            //reset UI
            txtSearch.Clear();
            txtFName.Clear();
            txtSName.Clear();
            txtAddress.Clear();
            chkMale.Checked = false;
            chkFemale.Checked = false;
            txtPhone.Clear();

            txtSearch.Focus();

        }

        //Fill Customer Update Fields with selected Customer
        private void custUpdateResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            
            DataGridViewRow row = grdSearch.Rows[rowIndex];
            
            CustIDString = row.Cells[0].Value.ToString();
            CustID = int.Parse(CustIDString);
            txtFName.Text = (String)row.Cells[1].Value;
            txtSName.Text = (String)row.Cells[2].Value;            
            dtpDOB.Value = Convert.ToDateTime(row.Cells[3].Value);
            txtAddress.Text = (String)row.Cells[4].Value;
            txtPhone.Text = (String)row.Cells[6].Value;

        }
     
        //Check Boxes
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


        //Reset the UI
        private void resetUI(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtFName.Clear();
            txtSName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
        }

        //Submit Clicked
        private void custSubmit_Click(object sender, EventArgs e)
        {
            // validate data
            if (txtFName.Text.Equals(""))
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

            if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Address must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }

            if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone number must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (!Validation.ValidateName(txtFName.Text))
            {
                MessageBox.Show("First Name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }

            if (!Validation.ValidateName(txtSName.Text))
            {
                MessageBox.Show("Last Name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSName.Focus();
                return;
            }

            if (!(Validation.ValidatePhoneNumber(txtPhone.Text)) || txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone number invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (!Validation.ValidateName(txtAddress.Text))
            {
                MessageBox.Show("Address invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }
           
            if (!chkMale.Checked && !chkFemale.Checked)
            {
                MessageBox.Show("Gender must be selected", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Customer up = new Customer();

            up.setCustomerID(CustID);
            up.setFirstName(txtFName.Text.ToUpper());
            up.setLastName(txtSName.Text.ToUpper());
            up.setDOB(dtpDOB.Text.ToUpper());
            up.setAddress(txtAddress.Text.ToUpper());

            if (chkMale.Checked)
                up.setGender('M');
            else
                up.setGender('F');

            up.setPhoneNumber(txtPhone.Text);

            if(!up.alreadyExists())
            {
                up.updateCustomer();

                txtSearch.Clear();
                txtFName.Clear();
                txtSName.Clear();
                txtAddress.Clear();
                txtPhone.Clear();
            }         
        }
    }
}
