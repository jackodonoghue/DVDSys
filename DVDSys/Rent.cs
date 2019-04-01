using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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
        //Make payment
        //
        public static void makePayment(int rentid, string amount)
        {
            //
            //Get next payment ID
            //
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

            //
            //Make payment
            //

            String day = DateTime.Now.ToString("dd/MM/yyyy");

            //define sql query
            String sql1 = "INSERT INTO payments VALUES(" + nextPayId + ", " + Convert.ToInt32(rentid) + ", " + Convert.ToDouble(amount) + ", " + "TO_DATE('" + day + "', 'DD/MM/YYYY'))";

            //create oracle command
            OracleCommand com1 = new OracleCommand(sql, connection);
            int num = com1.ExecuteNonQuery();

            //close db
            connection.Close();
        }
    }
}
