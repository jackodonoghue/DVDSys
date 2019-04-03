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
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

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
        //Get late dvds change late value
        //
        public static void checkLateRentals()
        {

            
            DataSet DS = new DataSet();
            DataTable dt = new DataTable();
            
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select DVD.DVDID, RentItem.ReturnDate, RentItem.RentID from DVD inner join RentItem on RentItem.DVDID=DVD.DVDID where (DVD.STATUS != 'A' OR DVD.STATUS != 'I') and RentItem.RETURNDATE < '" + DateTime.Today.ToString("dd-MMM-yyyy") + "'";
           
            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(DS, "stk");
            dt = DS.Tables[0];

            connection.Open();

            MessageBox.Show(dt.Rows.Count.ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TimeSpan noDays = DateTime.Today - DateTime.Parse(Convert.ToString(dt.Rows[i][1]));
                
                //define sql query to update dvd to rented
                String sql1 = "UPDATE DVD SET status = '" + noDays.ToString().Substring(0,2) + "'  WHERE DVDID = " + Convert.ToInt32(dt.Rows[i][0]);

                //create oracle command
                OracleCommand com1 = new OracleCommand(sql1, connection);
                int num1 = com1.ExecuteNonQuery();
            }

            //close db
            connection.Close();
        }
    }
}
