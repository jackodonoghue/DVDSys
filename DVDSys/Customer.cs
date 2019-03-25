﻿using System;
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
            String sql = "select max(CustID) from Customer";

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
            String sql = "INSERT INTO Customer VALUES(" + this.custid + ", '" + this.fName + "', '" + this.lName + "', TO_DATE('" + this.dob + "', 'DD/MM/YYYY'), '" + this.address +
                "', '" + this.gender + "', '" + this.phoneNum + "', 'A')";



            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

            if (num >= 0)
            {
                MessageBox.Show("Customer " + this.getCustomerID() + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Unsuccesful", "Unsuccess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            String sql = "select * from Customer WHERE FNAME LIKE '" + searchTerm + "%' OR SNAME LIKE '" + searchTerm + "%'";

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
            String sql = "UPDATE Customer SET FName = '" + this.fName + "', SName = '" + this.lName + "', DATEOFBIRTH = TO_DATE('" + this.dob +
                "', 'DD/MM/YYYY'), Address = '" + this.address + "', Gender = '" + this.gender + "', Phone = '" + this.phoneNum + "' WHERE CustID = " + this.custid;


            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            com.ExecuteNonQuery();

            if (com.ExecuteNonQuery() >= 0)
            {
                MessageBox.Show("Customer " + getCustomerID() + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("hello", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            String sql = "UPDATE Customer SET Active = 'I' WHERE CustID = " + id;


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

        public static Boolean valName(String name)
        {
            //Boolean result = true;
            Regex nameCheck = new Regex("^[a-zA-Z ,.'-]*$");

            if (nameCheck.IsMatch(name))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static Boolean valNumber(String number)
        {
            //Boolean result = true;
            Regex numberCheck = new Regex("^[0-9]*$");

            if (numberCheck.IsMatch(number))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}

