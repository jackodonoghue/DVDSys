using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace DVDSys
{
    class Customer
    {
        //instance variables
        private int customerID;
        private String firstName;
        private String lastName;
        private String address;
        private String dateOfBirth;
        private char gender;
        private String phoneNumber;
        private char accountStatus;

        // no arg constructor
        public Customer()
        {
            this.customerID = 0;
            this.firstName = "";
            this.lastName = "";
            this.dateOfBirth = "";
            this.address = "";
            this.gender = 'n';
            this.phoneNumber = "";
            this.accountStatus = 'I';
        }

        //arg constructor
        public Customer(int customerID, String firstName, String lastName, String dateOfBirth, String address, char gender, String phoneNumber, char accountStatus)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.accountStatus = accountStatus;
        }

        //Set Customer Attributes
        public void setCustomerID(int id)
        {
            this.customerID = id;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public void setDOB(String dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public void setAccountStatus(char status)
        {
            this.accountStatus = status;
        }

        public void setPhoneNumber(String phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void setGender(char gender)
        {
            this.gender = gender;
        }

        //Get Customer Attributes
        public int getCustomerID()
        {
            return this.customerID;
        }

        public String getFirstName()
        {
            return this.firstName;
        }

        public String getLastName()
        {
            return this.lastName;
        }

        public String getDOB()
        {
            return this.dateOfBirth;
        }

        public String getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public char getAccountStatus()
        {
            return this.accountStatus;
        }

        public char getGender()
        {
            return this.gender;
        }

        public String getAddress()
        {
            return this.address;
        }
        //
        //Get next Customer
        //
        public static int getNextCustID()
        {
            //variable to hold value to be returned
            int nextCustId = 1;

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "select max(CustID) from Customers";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataReader dr = com.ExecuteReader();

            //check value returned - if null return 1, otherwise return datareader value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextCustId = 1;
            }

            else
            {
                nextCustId = Convert.ToInt32(dr.GetValue(0)) + 1;
            }


            //close db
            connection.Close();


            return nextCustId;

        }
        //
        //Add Customer
        //
        public void addCustomer()
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "INSERT INTO Customers VALUES(" + this.customerID + ", '" + this.firstName + "', '" + this.lastName + "', TO_DATE('" + this.dateOfBirth + "', 'DD/MM/YYYY'), '" + this.address +
                "', '" + this.gender + "', '" + this.phoneNumber + "', 'A')";



            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

            if (num >= 0)
            {
                MessageBox.Show("Customer " + this.getFirstName() + " added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Customer Not Added", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //close db
            connection.Close();
        }
        //
        //Get searched Customer
        //
        public static DataSet getCustomers(DataSet DS, String searchTerm)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select * from Customers WHERE FNAME LIKE '" + searchTerm + "%' OR SNAME LIKE '" + searchTerm + "%'";

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
        //
        //Get searched Customer
        //
        public static DataSet getActiveCustomers(DataSet DS, String searchTerm)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select * from Customers WHERE (FNAME LIKE '" + searchTerm + "%' OR SNAME LIKE '" + searchTerm + "%') AND ACTIVE = 'A' ";

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
        //
        //Update Customer
        //
        public void updateCustomer()
        {

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "UPDATE Customers SET FName = '" + this.firstName + "', SName = '" + this.lastName + "', DATEOFBIRTH = TO_DATE('" + this.dateOfBirth +
                "', 'DD/MM/YYYY'), Address = '" + this.address + "', Gender = '" + this.gender + "', Phone = '" + this.phoneNumber + "', Active = 'A' WHERE CustID = " + this.customerID;


            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            com.ExecuteNonQuery();

            if (com.ExecuteNonQuery() >= 0)
            {
                MessageBox.Show("Customer " + getFirstName() + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Customer Not Updated", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //close db
            connection.Close();
        }
        //
        // Remove Customer
        //
        public static void removeCustomer(int id)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "UPDATE Customers SET Active = 'I' WHERE CustID = " + id;


            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            com.ExecuteNonQuery();

            if (com.ExecuteNonQuery() >= 0)
            {
                MessageBox.Show("Customer " + id + " account removed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Account not removed", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //close db
            connection.Close();
        }
        //
        // Check if customer already exists
        //
        public Boolean alreadyExists()
        {
            DataSet ds = new DataSet();
            Boolean res = false;

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "SELECT * FROM CUSTOMERS WHERE PHONE = " + this.phoneNumber + " AND ACTIVE!='I' AND CUSTID!=" + this.customerID;

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(ds, "DVD");

            //close db
            connection.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Customer already exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                res = true;
            }

            //close db
            connection.Close();            
            
            return res;
        }
    }
}

