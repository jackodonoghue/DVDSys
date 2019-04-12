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
    class DVD
    {
        private int id;
        private String title;
        private String type;
        private String dir;
        private String genre;
        private String relDate;
        private char active;

        public DVD()
        {
            id = 0;
            title = "";
            type = "";
            dir = "";
            genre = "";
            relDate = "";
            active = 'U';
        }

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
        //Set Title
        //
        public void setTitle(String title)
        {
            this.title = title;
        }
        //
        //Get next DVD ID
        //
        public static int getNextDVDID()
        {
            //variable to hold value to be returned
            int nextID = 1;

            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);
            connection.Open();

            //define sql query
            String sql = "select max(DVDID) from DVDS";

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
        //
        //Search DVD
        //
        public static DataSet getDVDS(DataSet ds, string searched)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select * from DVDS WHERE title LIKE '" + searched + "%'";

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
        //Search Active DVD
        //
        public static DataSet getActiveDVDS(DataSet ds, string searched)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select * from DVDS WHERE title LIKE '" + searched + "%' AND STATUS = 'A'";

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
        //Search Rented DVDs
        //
        public static DataSet getRentedDVDS(DataSet ds, string searched)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select * from DVDS WHERE title LIKE '" + searched + "%' AND STATUS != 'A' AND STATUS !='I'";

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
            String sql = "INSERT INTO DVDS VALUES(" + this.id + ", '" + this.type + "', '" + this.title + "', '" + this.dir + "', '" + this.genre + "', TO_DATE('" + this.relDate + "', 'DD/MM/YYYY'), '" + this.active + "')"; 

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            int num = com.ExecuteNonQuery();

            if (num >= 0)
            {
                MessageBox.Show("DVD " + this.title + " added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            String sql = "update DVDS set DVDTYPE = '" + this.type + "', TITLE = '" + this.title + "', DIRECTOR = '" + this.dir + "', GENRE = '" + this.genre + "', RELEASEDATE = TO_DATE('" + this.relDate +"', 'DD/MM/YYYY') WHERE dvdid = " + this.id;


            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);
            com.ExecuteNonQuery();

            if (com.ExecuteNonQuery() >= 0)
            {
                MessageBox.Show("DVD " + this.title + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Updat failed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            String sql = "UPDATE DVDS SET STATUS = 'I' WHERE DVDID = " + id;


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
        //
        //Search DVD by title
        //
        public DataSet getDVDbyTitle(DataSet ds)
        {
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select DVDID from DVDS WHERE title LIKE '" + this.title + "%'";

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(ds, "DVD");

            //close db
            connection.Close();


            return ds;
        }
        //
        //Check DVD Status before update/delete
        //
        public static String getDVDStatus(int dvdid)
        {
            DataSet ds = new DataSet();
            DataTable dt;
            //connect to db
            OracleConnection connection = new OracleConnection(ConnectDB.orDB);

            //define sql query
            String sql = "select status from dvds where DVDID=" + dvdid;

            //create oracle command
            OracleCommand com = new OracleCommand(sql, connection);

            //execute query using datareader
            OracleDataAdapter da = new OracleDataAdapter(com);

            //check value returned - if null return 1, otherwise return datareader value
            da.Fill(ds, "DVD");

            //close db
            connection.Close();

            dt = ds.Tables[0];

            return Convert.ToString(dt.Rows[0][0]);
        }
    }
}
