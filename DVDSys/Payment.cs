using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
