using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDSys
{
    class ConnectDB
    { 
        public const string connectionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = XE))); User ID = C##T00194275; Password=brqey3s5;";

        public int PerformNonQuery(string statement)
        {
            int rowsInserted;

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(statement, connection))
                {
                    rowsInserted = command.ExecuteNonQuery();
                }

                connection.Close();
            }

            return rowsInserted;
        }

        public DataSet PerformQuery(string statement)
        {
            DataSet dataSet = new DataSet();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(statement, connection))
                {
                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter(command))
                    {
                        dataAdapter.Fill(dataSet, "stk");
                    }
                }

                connection.Close();
            }

            return dataSet;
        }
    }
    

}
