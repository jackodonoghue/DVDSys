using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DVDSys
{
    public partial class frmLogin : Form
    {
        frmHome parent;
        public static Boolean loggedIn = false;

        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(frmHome Parent)
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

        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hUsername = ComputeHash(txtUsername.Text, new SHA256CryptoServiceProvider());

            string hPassword = ComputeHash(txtPassword.Text, new SHA256CryptoServiceProvider());

            //Account acc = new Account(hUsername, hPassword);
            //acc.addAccount();
            //This table should contain two columns - Username and password.
            //The Username and Password would have been collected by hte "Register User" function and put throught the ComputeHash() algorithm before saving.

            if (Account.getLogin(hUsername, hPassword))
            {                
                    loggedIn = true;
                    parent.showMenu(hUsername);
                    this.Hide();
                    Payment.checkLateRentals();
            }
            else
            {
                MessageBox.Show("Login information incorrect", "Error!" ,MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
