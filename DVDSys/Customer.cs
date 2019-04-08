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
        private int custid;
        private String fName;
        private String lName;
        private String address;
        private String dob;
        private char gender;
        private String phoneNum;
        private char accStatus;

        // no arg constructor
        public Customer()
        {
            custid = 0;
            fName = "";
            lName = "";
            dob = "";
            address = "";
            gender = 'n';
            phoneNum = "";
            accStatus = 'I';
        }

        //arg constructor
        public Customer(int cid, String fN, String lN, String dofb, String add, char gen, String pN, char acc)
        {
            custid = cid;
            fName = fN;
            lName = lN;
            dob = dofb;
            address = add;
            gender = gen;
            phoneNum = pN;
            accStatus = acc;
        }

        //Set Customer Attributes
        public void setCustomerID(int id)
        {
            this.custid = id;
        }

        public void setFName(String fN)
        {
            this.fName = fN;
        }

        public void setLName(String lN)
        {
            this.lName = lN;
        }

        public void setDOB(String dob)
        {
            this.dob = dob;
        }

        public void setAddress(String add)
        {
            this.address = add;
        }

        internal void setPhoneNumber(int v)
        {
            throw new NotImplementedException();
        }

        public void setPhoneNumber(String pN)
        {
            this.phoneNum = pN;
        }

        public void setAccountStatus(char status)
        {
            this.accStatus = status;
        }

        public void setGender(char gen)
        {
            this.gender = gen;
        }

        //Get Customer Attributes
        public int getCustomerID()
        {
            return this.custid;
        }

        public String getFName()
        {
            return this.fName;
        }

        public String getlName()
        {
            return this.lName;
        }

        public String getDOB()
        {
            return this.dob;
        }

        public String getPhoneNumber()
        {
            return this.phoneNum;
        }

        public char getAccountStatus()
        {
            return this.accStatus;
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
            String sql = "INSERT INTO Customers VALUES(" + this.custid + ", '" + this.fName + "', '" + this.lName + "', TO_DATE('" + this.dob + "', 'DD/MM/YYYY'), '" + this.address +
                "', '" + this.gender + "', '" + this.phoneNum + "', 'A')";



            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

            if (num >= 0)
            {
                MessageBox.Show("Customer " + this.getFName() + " added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            String sql = "UPDATE Customers SET FName = '" + this.fName + "', SName = '" + this.lName + "', DATEOFBIRTH = TO_DATE('" + this.dob +
                "', 'DD/MM/YYYY'), Address = '" + this.address + "', Gender = '" + this.gender + "', Phone = '" + this.phoneNum + "', Active = 'A' WHERE CustID = " + this.custid;


            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            com.ExecuteNonQuery();

            if (com.ExecuteNonQuery() >= 0)
            {
                MessageBox.Show("Customer " + getFName() + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            String sql = "SELECT * FROM CUSTOMERS WHERE PHONE = " + this.phoneNum + " AND ACTIVE!='I' AND CUSTID!=" + this.custid;

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

