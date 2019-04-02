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
    class Type
    {
        //instance variables
        private String type;
        private String description;
        private double price;

        //no arg constructor
        public Type()
        {
            this.type = "NA";
            this.description = "";
            this.price = 0.00;
        }

        //constructor
        public Type(String type, String desc, double price)
        {
            this.type = type;
            this.description = desc;
            this.price = price;
        }

        //get and set
        public String getType()
        {
            return this.type;
        }

        public String getDescription()
        {
            return this.description;
        }

        public double getPrice()
        {
            return this.price;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public void setDescription(String desc)
        {
            this.description = desc;
        }

        public void setPrice (double price)
        {
            this.price = price;
        }

        //add customer
        public void addType()
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "insert into TYPE VALUES('" + this.type + "', '" + this.description +"', " + this.price +")";
            


            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

            if (num >= 0)
            {
                MessageBox.Show("Customer " + this.getType() + " added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Unsuccesful", "Unsuccess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //close db
            connection.Close();
        }

        public static DataSet getTypes(DataSet DS)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select * from Type";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(DS, "stk");

            //close db
            connection.Close();


            return DS;

        }

        public static DataSet getSearchTypes(DataSet DS, String searchTerm)
        {
            
                //connect to db
                OracleConnection connection = new OracleConnection(ConnectDB.orDB);

                //define sql query
                String sql = "select * from Type WHERE DVDType LIKE '" + searchTerm + "%'";

                //create oracle command
                OracleCommand com = new OracleCommand(sql, connection);

                //execute query using datareader
                OracleDataAdapter da = new OracleDataAdapter(com);

                //check value returned - if null return 1, otherwise return datareader value
                da.Fill(DS, "stk");

                //close db
                connection.Close();


                return DS;
        }

        public void updateType()
        {

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "UPDATE Type SET Description = '" + this.description + "', PricePerNight = " + this.price + " WHERE DVDType = '" + this.type + "'";


            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            com.ExecuteNonQuery();

            if (com.ExecuteNonQuery() >= 0)
            {
                MessageBox.Show("Type " + getType() + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //close db
            connection.Close();
        }
        //
        //Get type data for chart
        //
        public static DataTable getRentalPerType(DataTable dt, String start, String end)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "SELECT DVD.DVDTYPE, COUNT(*) AS COUNT FROM RENTITEM INNER JOIN DVD ON RENTITEM.DVDID=DVD.DVDID WHERE RENTDATE BETWEEN TO_DATE('" + start + "', 'DD/MM/YYYY') AND TO_DATE('" + end + "', 'DD/MM/YYYY') GROUP BY DVD.DVDTYPE";

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

    }
}
