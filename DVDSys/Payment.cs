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
    class Payment
    {
        public static DataTable getRevenue(DataTable dt, String yr)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.connectionString);

            //define sql query
            String sql = "SELECT SUM(Amount), TO_CHAR(Payment_Date,'MM') AS MONTH FROM Payments WHERE Payment_Date LIKE '%" + yr + "' GROUP BY TO_CHAR(Payment_Date,'MM') ORDER BY TO_CHAR(Payment_Date,'MM')";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(dt);

            //close db
            connection.Close();


            return dt;
        }
        //
        //Get Month from month number
        //
        public static String getMonthForAnalysis(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";

                    }
                case 2:
                    {
                        return "FEB";

                    }
                case 3:
                    {
                        return "MAR";

                    }
                case 4:
                    {
                        return "APR";

                    }
                case 5:
                    {
                        return "MAY";

                    }
                case 6:
                    {
                        return "JUN";

                    }
                case 7:
                    {
                        return "JUL";

                    }
                case 8:
                    {
                        return "AUG";

                    }
                case 9:
                    {
                        return "SEP";

                    }
                case 10:
                    {
                        return "OCT";

                    }
                case 11:
                    {
                        return "NOV";

                    }
                case 12:
                    {
                        return "DEC";

                    }
                default: return "OTH";

            }
        }
        //
        //Get next payment ID
        //
        public static int getNextPaymentID()
        {
            //variable to hold value to be returned
            int nextPayId = 1;

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.connectionString);
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
            OracleConnection connection = new OracleConnection(ConnectDB.connectionString);
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
        //Get late dvds change late value on program load
        //
        public static void checkLateRentals()
        {

            
            DataSet DS = new DataSet();
            DataTable dt = new DataTable();
            
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.connectionString);

            //define sql query -- returns all rented DVDs
            String sql = "select DVDS.DVDID, RentItems.ReturnDate, RentItems.RentID from DVDs inner join RentItems on RentItems.DVDID=DVDs.DVDID where (DVDs.STATUS != 'A' AND DVDs.STATUS != 'I') "
                + "and RentItems.RETURNDATE < '" + DateTime.Today.ToString("dd-MMM-yyyy") + "'";
           
            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(DS, "stk");
            dt = DS.Tables[0];

            connection.Open();
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TimeSpan noDays = DateTime.Today - DateTime.Parse(Convert.ToString(dt.Rows[i][1]));
                
                //define sql query to update dvd to rented
                String sql1 = "UPDATE DVDS SET status = '" + noDays.ToString().Substring(0,1) + "'  WHERE DVDID = " + Convert.ToInt32(dt.Rows[i][0]);

                //create oracle command
                OracleCommand com1 = new OracleCommand(sql1, connection);
                int num1 = com1.ExecuteNonQuery();
            }

            //close db
            connection.Close();
        }
        //
        //Get Late Return charges
        //
        public static DataSet getLateRental(DataSet ds, int CustID)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.connectionString);

            //define sql query
            String sql = "Select DVDS.Status, DVDS.DVDID, RENTITEMS.RENTID from DVDS INNER JOIN RENTITEMS ON RENTITEMS.DVDID=DVDS.DVDID " 
                + "where Status != 'I' AND Status != 'A' AND Status != 'R' AND RENTID = (SELECT MAX(RENTID) FROM RENTALS WHERE CUSTID=" + CustID + ")";

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
