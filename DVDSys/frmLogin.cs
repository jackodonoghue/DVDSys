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
            Close();
            parent.Visible = true;
        }

        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hashedUsername = ComputeHash(txtUsername.Text, new SHA256CryptoServiceProvider());

            string hashedPassword = ComputeHash(txtPassword.Text, new SHA256CryptoServiceProvider());



            Account account = new Account(hashedUsername, hashedPassword);
            
            if (account.IsValidLogin())
            {                
                    loggedIn = true;
                    parent.showMenu(hashedUsername);
                    Hide();
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
