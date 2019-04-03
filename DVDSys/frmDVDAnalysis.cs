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
            this.Close();
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
            DataTable dt = new DataTable();

            dt = Type.getRentalPerType(dt, dtpStart.Text, dtpEnd.Text);

            //Array for each typeToString("dd/M/yyyy", CultureInfo.InvariantCulture)
            string[] types = new string[Type.getNumTypes()];

            //Array for each value per month
            int[] amounts = new int[Type.getNumTypes()];

            for (int i = 0; i < amounts.Length - 1; i++)
            {
                amounts[i] = Convert.ToInt32(dt.Rows[i][1]);
            }

            for (int i = 0; i < types.Length; i++)
            {
                types[i] = dt.Rows[i][0].ToString();
            }

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";

            chtData.Series["Series1"]["PointWidth"] = ".5";

            chtData.Series["Series1"]["PixelPointWidth"] = "20";
            chtData.Series[0].Points.DataBindXY(types, amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            
            chtData.Series[0].Label = "#VALY";

            chtData.Titles.Add("Yearly Revenue");
            chtData.ChartAreas[0].AxisX.Title = "Type";
            chtData.ChartAreas[0].AxisY.Title = "Number of Times Rented";
            chtData.Series[0].IsVisibleInLegend = false;


            chtData.Visible = true;
        }
    }
}
