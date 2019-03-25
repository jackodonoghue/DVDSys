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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            btnCustID.Text = Customer.getNextCustID().ToString("000");
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

            if(!Customer.valName(txtFName.Text))
            {
                MessageBox.Show("First Name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFName.Focus();
                return;
            }

            if (!Customer.valName(txtSName.Text))
            {
                MessageBox.Show("Last Name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSName.Focus();
                return;
            }

            if (!(Customer.valNumber(txtPhone.Text)) || txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone number invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (!Customer.valName(txtAddress1.Text))
            {
                MessageBox.Show("First Name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress1.Focus();
                return;
            }

            if (!Customer.valName(txtAddress2.Text))
            {
                MessageBox.Show("First Name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            newCustomer.setFName(txtFName.Text);
            newCustomer.setLName(txtSName.Text);
            newCustomer.setDOB(dtpDOB.Text);
            newCustomer.setAddress(txtAddress1.Text + ", " + txtAddress2.Text);
            if (chkMale.Checked)
                newCustomer.setGender('M');
            else
                newCustomer.setGender('F');
            
            newCustomer.setPhoneNumber(txtPhone.Text);
            newCustomer.setAccountStatus('A');

            newCustomer.addCustomer();

            //display confirmation message


            //reset UI
            btnCustID.Text = Customer.getNextCustID().ToString("000");
            txtFName.Clear();
            txtSName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            chkMale.Checked = false;
            chkMale.Checked = false;
            txtPhone.Clear();

            txtFName.Focus();
             
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

        private void Reset_Click(object sender, EventArgs e)
        {
            //reset UI
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

