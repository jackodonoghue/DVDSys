﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDSys
{
    class DVD
    {
        private int id;
        private String title;
        private String type;
        private String dir;
        private String genre;
        private String relDate;
        private char active;

        public DVD(int id, String title, String type, String dir, String genre, String relDate, char active)
        {
            this.id = id;
            this.title = title;
            this.type = type;
            this.dir = dir;
            this.genre = genre;
            this.relDate = relDate;
            this.active = active;
        }
        //
        //Get next DVD ID
        //
        public static int getNextCustID()
        {
            //variable to hold value to be returned
            int nextID = 1;

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "select max(DVDID) from DVD";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataReader dr = com.ExecuteReader();

            //check value returned - if null return 1, otherwise return datareader value
            dr.Read();

            if (dr.IsDBNull(0))
            {
                nextID = 1;
            }

            else
            {
                nextID = Convert.ToInt32(dr.GetValue(0)) + 1;
            }


            //close db
            connection.Close();


            return nextID;

        }

        public static DataSet getDVDS(DataSet ds, string searched)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select * from DVD WHERE title LIKE '" + searched + "%'";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(ds, "stk");

            //close db
            connection.Close();


            return ds;
        }

        //
        //Add DVD
        //
        public void addDVD()
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "INSERT INTO DVD VALUES(" + this.id + ", '" + this.type + "', '" + this.title + "', '" + this.dir + "', '" + this.genre + "', TO_DATE('" + this.relDate + "', 'DD/MM/YYYY'), '" + this.active + "')"; 

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

            if (num >= 0)
            {
                MessageBox.Show("DVD " + this.id + " added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Unsuccesful", "Unsuccess!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //close db
            connection.Close();
        }
        //
        //Update DVD
        //
        public void updateDVD()
        {

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "update DVD set DVDTYPE = '" + this.type + "', TITLE = '" + this.title + "', DIRECTOR = '" + this.dir + "', GENRE = '" + this.genre + "', RELEASEDATE = TO_DATE('" + this.relDate +"', 'DD/MM/YYYY') WHERE dvdid = " + this.id;


            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            com.ExecuteNonQuery();

            if (com.ExecuteNonQuery() >= 0)
            {
                MessageBox.Show("Customer " + this.id + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Fail", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //close db
            connection.Close();
        }
        //
        //Remove DVD
        //
        public static void removeDVD(int id, String title)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "UPDATE DVD SET Active = 'I' WHERE DVDID = " + id;


            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            com.ExecuteNonQuery();

            if (com.ExecuteNonQuery() >= 0)
            {
                MessageBox.Show(title + "  removed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Account not removed", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //close db
            connection.Close();
        }
    }
}