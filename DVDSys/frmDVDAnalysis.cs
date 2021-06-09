using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDSys
{
    public partial class frmDVDAnalysis : Form
    {
        frmHome parent;
        public frmDVDAnalysis()
        {
            InitializeComponent();
        }

        public frmDVDAnalysis(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDVDAnalysis_Load(object sender, EventArgs e)
        {
            dtpStart.MaxDate = DateTime.Now.AddDays(-1);
            dtpEnd.MaxDate = DateTime.Now;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataTable numberOfEachTypeRentedDuringTimePeriod = new DataTable();
            DVDType type = new DVDType();

            numberOfEachTypeRentedDuringTimePeriod = type.GetRentalsPerType(dtpStart.Text, dtpEnd.Text).Tables[0];

            //Array for each value per month
            int[] amounts = new int[type.GetNumTypes()];

            for (int i = 0; i < numberOfEachTypeRentedDuringTimePeriod.Rows.Count; i++)
            {
                amounts[i] = Convert.ToInt32(numberOfEachTypeRentedDuringTimePeriod.Rows[i][1]);
            }

            //Array for each TypeOfDVD
            string[] types = new string[type.GetNumTypes()];

            DataSet ds = type.GetTypesFromDatabase();

            DataTable dt1 = new DataTable();
            dt1 = ds.Tables[0];

            numberOfEachTypeRentedDuringTimePeriod = type.GetRentalsPerType(dtpStart.Text, dtpEnd.Text).Tables[0];

            for (int i = 0; i < types.Length; i++)
            {
                types[i] = dt1.Rows[i][0].ToString();
            }

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";

            chtData.Series["Series1"]["PointWidth"] = ".5";

            chtData.Series["Series1"]["PixelPointWidth"] = "20";
            chtData.Series[0].Points.DataBindXY(types, amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            
            chtData.Series[0].Label = "#VALY";

            chtData.Titles.Clear();
            chtData.Titles.Add("Types rented over time");
            chtData.ChartAreas[0].AxisX.Title = "DVDType";
            chtData.ChartAreas[0].AxisY.Title = "Number of Times Rented";
            chtData.Series[0].IsVisibleInLegend = false;


            chtData.Visible = true;
        }
    }
}
