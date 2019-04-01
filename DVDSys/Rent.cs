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
    class Rent
    {
        private int rentID;
        private int otherID;
        //Constructor
        public Rent(int rentID, int otherID)
        {
            this.rentID = rentID;
            this.otherID = otherID;
        }
        //
        //Get Next Rent ID
        //
        public static int getNextRentID()
        {
            //variable to hold value to be returned
            int nextRentId = 1;

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "select max(RentID) from Rental";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataReader dr = com.ExecuteReader();

            //check value returned - if null return 1, otherwise return datareader value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextRentId = 1;
            }

            else
            {
                nextRentId = Convert.ToInt32(dr.GetValue(0)) + 1;
            }


            //close db
            connection.Close();


            return nextRentId;

        }
        //
        //Add Customer to rental
        //
        public void addRental()
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "INSERT INTO Rental VALUES(" + this.rentID + ", " + this.otherID + ")";
            
            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

            //close db
            connection.Close();
        }
        //
        //Add DVD to RentalItems
        //
        public void addRentalItem()
        {
            String start = DateTime.Now.ToString("dd/MM/yyyy");
            String end = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy");
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "INSERT INTO RentItem VALUES(" + this.rentID + ", " + this.otherID + ", " + "TO_DATE('" + start + "', 'DD/MM/YYYY')" 
                + ", " + "TO_DATE('" + end + "', 'DD/MM/YYYY')" + ")";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

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
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "select PRICEPERNIGHT from TYPE where DVDTYPE = '" + type + "'";

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
        //Get next payment ID
        //
        public static int getNextPaymentID()
        {
            //variable to hold value to be returned
            int nextPayId = 1;

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "select max(PAYMENTID) from PAYMENTS";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataReader dr = com.ExecuteReader();

            //check value returned - if null return 1, otherwise return datareader value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextPayId = 1;
            }

            else
            {
                nextPayId = Convert.ToInt32(dr.GetValue(0)) + 1;
            }


            //close db
            connection.Close();

            return nextPayId;

        }
        //
        //Make payment
        //
        public static void makePayment(int rentid, string amount)
        {

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            String day = DateTime.Now.ToString("dd/MM/yyyy");

            //define sql query
            String sql = "INSERT INTO payments VALUES(" + getNextPaymentID() + ", " + Convert.ToInt32(rentid) + ", " + Convert.ToDouble(amount) + ", " + "TO_DATE('" + day + "', 'DD/MM/YYYY'))";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

            //close db
            connection.Close();
        }
        //
        //Search for rented DVDs
        //
        public static DataSet getRentedDVDs(int custid)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select RentID from Rental WHERE custid = " + custid + "";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(ds, "stk");

            if (ds.Equals(null))
            {
                MessageBox.Show(dr.GetValue(0).ToString(), "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                nextID = Convert.ToInt32(dr.GetValue(0)) + 1;
            }


            //close db
            connection.Close();


            return ds;
        }
        //
        //Check for late return
        //
        public static int lateReturn(int rentid)
        {
            //get dvds from the rental
            //compare ret dates of rentals to actual return date, if greater than 0 return number of days
            //variable to hold value to be returned
            int nextPayId = 1;

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "select count(*) from RentItem where rentid = " + rentid;
           
            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataReader dr = com.ExecuteReader();

            //check value returned - if null return 1, otherwise return datareader value
            dr.Read();

            MessageBox.Show(dr.GetValue(0).ToString(), "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
            if (dr.IsDBNull(0))
            {
                nextPayId = 1;
            }

            else
            {
                nextPayId = Convert.ToInt32(dr.GetValue(0)) + 1;
            }
            

            //close db
            connection.Close();

            return 0;

        }
    }
}
