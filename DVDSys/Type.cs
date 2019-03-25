using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
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
        public void addCustomer()
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
    }
}
