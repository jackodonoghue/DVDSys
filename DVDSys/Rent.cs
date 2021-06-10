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
    class Rental
    {
        private int rentID;
        private int otherID;
        private ConnectDB databaseConnection = new ConnectDB();
        //Constructor
        public Rental(int rentID, int otherID)
        {
            this.rentID = rentID;
            this.otherID = otherID;
        }
        //
        //Get Next Rental ID
        //
        public int GetNextRentID()
        {
            //variable to hold value to be returned
            int nextRentId = 1;

            DataSet result = databaseConnection.PerformQuery("select max(RentID) from Rentals");

            if (!(result.Tables[0].Rows[0][0] is null))
            {
                nextRentId = Convert.ToInt32(result.Tables[0].Rows[0][0]) + 1;
            }

            return nextRentId;

        }
        //
        //Add Customer to rental
        //
        public bool AddRental()
        {
            int numberOfEffectedRows = databaseConnection.PerformNonQuery("INSERT INTO Rentals VALUES(" + rentID + ", " + otherID + ")");
            
            return numberOfEffectedRows >= 0;
        }
        //
        //Add DVD to RentalItems
        //
        public void AddRentalItem()
        {
            string start = DateTime.Now.ToString("dd/MM/yyyy");
            string end = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy");

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.connectionString);
            connection.Open();

            //define sql query
            String sql = "INSERT INTO RentItems VALUES(" + rentID + ", " + otherID + ", " + "TO_DATE('" + start + "', 'DD/MM/YYYY')" 
                + ", " + "TO_DATE('" + end + "', 'DD/MM/YYYY')" + ")";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

            //define sql query to update dvd to rented
            String sql1 = "UPDATE DVDs SET status = 'R'  WHERE DVDID = " + otherID;

            //create oracle command
            OracleCommand com1 = new OracleCommand(sql1, connection);
            int num1 = com1.ExecuteNonQuery();

            //close db
            connection.Close();
        }
        //
        //Get Price of DVD
        //
        public static double getPrice(String type)
        {
            //variable to hold value to be returned
            double price;

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.connectionString);
            connection.Open();

            //define sql query
            String sql = "select PRICEPERNIGHT from TYPEs where DVDTYPE = '" + type + "'";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataReader dr = com.ExecuteReader();

            //check value returned - if null return 1, otherwise return datareader value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                price = -1;
            }

            else
            {
                price = Convert.ToDouble(dr.GetValue(0));
            }


            //close db
            connection.Close();


            return price;
        }
        //
        //Return Rented DVD
        //
        public static void returnDVD(int dvdid)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.connectionString);
            connection.Open();

            //define sql query
            String sql = "UPDATE DVDs SET STATUS = 'A' WHERE DVDID = " + dvdid;


            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            com.ExecuteNonQuery();

            if (com.ExecuteNonQuery() >= 0)
            {
                MessageBox.Show("DVD " + dvdid + " returned", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error, DVD " + dvdid +" not returned!\nPlease try again", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //close db
            connection.Close();
        }
        //
        //Get Current Rentals for a specific customer
        //
        public static DataSet getCurrentRentals(int CustID)
        {
            DataSet ds = new DataSet();

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.connectionString);

            //define sql query
            String sql = "Select DVDS.Status, DVDS.DVDID, RENTITEMS.RENTID from DVDS INNER JOIN RENTITEMS ON RENTITEMS.DVDID=DVDS.DVDID "
                + "where Status != 'I' AND Status != 'A' AND RENTID = (SELECT MAX(RENTID) FROM RENTALS WHERE CUSTID=" + CustID + ")";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(ds);

            //close db
            connection.Close();

            return ds;
        }
    }
}
