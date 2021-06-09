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
    class DVDType
    {
        //instance variables
        private string TypeOfDVD; 
        private string Description;
        private double Price;

        private ConnectDB databaseConnection = new ConnectDB();

        //no arg constructor
        public DVDType()
        {
            TypeOfDVD = "NA";
            Description = "";
            Price = 0.00;
        }

        //constructor
        public DVDType(string type, string description, double price)
        {
            TypeOfDVD = type;
            Description = description;
            Price = price;
        }
        //
        //add DVDType to types table
        //
        public void AddType()
        {
            int numberOfRowsAdded = databaseConnection.PerformNonQuery("insert into TYPES VALUES('" + TypeOfDVD + "', '" + Description + "', " + Price + ")");

            if (numberOfRowsAdded >= 0)
            {
                MessageBox.Show("DVDType " + TypeOfDVD + " added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Unsuccesful", "Unsuccess!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //
        //Get all types from database
        //
        public DataSet GetTypesFromDatabase()
        {                       
            return databaseConnection.PerformQuery("select * from Types");
        }
        //
        //Retrieve types from database with a corresponding search term
        //
        public DataSet getSearchTypes(DataSet dataSet, string searchTerm)
        {

            //define sql query
            string sql = "select * from Types WHERE DVDType LIKE '" + searchTerm + "%'";


            return databaseConnection.PerformQuery("select * from Types WHERE DVDType LIKE '" + searchTerm + "%'"); 
        }
        //
        //Update Types
        //
        public void UpdateType()
        {
            int numberOfUpdatedRows = databaseConnection.PerformNonQuery("UPDATE Types SET Description = '" + Description + "', PricePerNight = " + Price + " WHERE DVDType = '" + TypeOfDVD + "'");

            if (numberOfUpdatedRows >= 0)
            {
                MessageBox.Show("DVDType " + TypeOfDVD + " updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //
        //Get TypeOfDVD data for chart
        //
        public DataSet GetRentalsPerType(string start, string end)
        {
            return databaseConnection.PerformQuery("SELECT DVDs.DVDTYPE, COUNT(*) AS COUNT FROM RENTITEMs INNER JOIN DVDs ON RENTITEMs.DVDID=DVDs.DVDID WHERE RENTDATE BETWEEN TO_DATE('" + start + "', 'DD/MM/YYYY') AND TO_DATE('" + end + "', 'DD/MM/YYYY') GROUP BY DVDs.DVDTYPE");
        }
        //
        //Get number of types that have dvds available to rent 
        //
        public int GetNumTypes()
        {            
            DataSet types = databaseConnection.PerformQuery("select COUNT(UNIQUE(DVDTYPE)) from DVDs where STATUS != 'I'");

            return Convert.ToInt32(types.Tables[0].Rows[0][0]);
        }
        //
        // Check if TypeOfDVD already exists
        //
        public bool AlreadyExists()
        {
            bool res = false;
            DataSet typesSearched = databaseConnection.PerformQuery("SELECT * FROM TYPEs WHERE DVDTYPE = TO_CHAR('" + this.TypeOfDVD + "')");

            if (typesSearched.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("DVDType already exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                res = true;
            }

            return res;
        }
    }
}
