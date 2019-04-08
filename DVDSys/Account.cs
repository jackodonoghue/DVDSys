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
        String user;
        String pass;

        public Account(String u, String p)
        {
            this.user = u;
            this.pass = p;
        }

        //
        //Get next Account id
        //
        public static int getNextAccID()
        {
            //variable to hold value to be returned
            int nextAccId = 1;

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "select max(ACCOUNTID) from accountS";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataReader dr = com.ExecuteReader();

            //check value returned - if null return 1, otherwise return datareader value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextAccId = 1;
            }

            else
            {
                nextAccId = Convert.ToInt32(dr.GetValue(0)) + 1;
            }


            //close db
            connection.Close();


            return nextAccId;

        }
        //
        //Add Account
        //
        public void addAccount()
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            int id = getNextAccID();

            //define sql query
            String sql = "INSERT INTO Accounts VALUES(" + id + ", '" + this.user + "', '" + this.pass + "')";



            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

            if (num >= 0)
            {
                MessageBox.Show("Account created", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Account Not Added", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //close db
            connection.Close();
        }
        //
        //Account Login
        //
        public static Boolean getLogin(String user, String pass)
        {
            Boolean loginAllowed = false;
            DataSet DS = new DataSet();
            DataTable dt = new DataTable();

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select * from Accounts WHERE USERNAME = '" + user + "' AND PASSWORD = '" + pass + "'";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(DS, "stk");

            //close db
            connection.Close();

            dt = DS.Tables[0];

            if(dt.Rows.Count == 0)
            {
                loginAllowed = false;
            }
            else
            {
                loginAllowed = true;
            }


            return loginAllowed;

        }
    }
}
