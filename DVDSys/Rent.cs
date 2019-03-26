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
    }
}
