using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDSys
{
    class Account
    {
        string username;
        string password;
        private ConnectDB databaseConnection = new ConnectDB();

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        //
        //Get next Account id
        //
        public int GetNextAccountID()
        {
            //variable to hold value to be returned
            int nextAccountID = 1;
            
            DataSet result = databaseConnection.PerformQuery("select max(ACCOUNTID) from accountS");

            if (!(result.Tables[0].Rows[0][0] is null))
            {
                nextAccountID = Convert.ToInt32(result.Tables[0].Rows[0][0]) + 1;
            }
            
            return nextAccountID;
        }
        //
        //Add Account
        //
        public void AddAccount()
        {
            int id = GetNextAccountID();

            int numberOfEffectedRows = databaseConnection.PerformNonQuery("INSERT INTO Accounts VALUES(" + id + ", '" + username + "', '" + password + "')");

            if (numberOfEffectedRows >= 0)
            {
                MessageBox.Show("Account created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Account Not Added", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        //Account Login
        //
        public bool IsValidLogin()
        {
            DataTable loginResult = databaseConnection.PerformQuery("select * from Accounts WHERE USERNAME = 'ADMIN' AND PASSWORD = 'ADMIN'").Tables[0];

            if(loginResult.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
