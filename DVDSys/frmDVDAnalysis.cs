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

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            Type.getRentalPerType(dt, dtpStart.Text, dtpEnd.Text);

            //Array for each month
            string[] months = new string[12];

            //Array for each value per month
            decimal[] amounts = new decimal[12];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                amounts[Convert.ToInt32(dt.Rows[i][1]) - 1] = Convert.ToDecimal(dt.Rows[i][0]);
            }

            for (int i = 0; i < 12; i++)
            {
                months[i] = Payment.getMonthForAnalysis(i + 1);
            }

            /*chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Income in €";

            chtData.Series["Series1"]["PointWidth"] = ".5";

            chtData.Series["Series1"]["PixelPointWidth"] = "20";
            chtData.Series[0].Points.DataBindXY(months, amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            //chtData.Series[0].Points[0] = "XXX";
            chtData.Series[0].Label = "#VALY";

            chtData.Titles.Add("Yearly Revenue");
            // chtData.ChartAreas[0].AxisX.LabelStyle. = 5;
            chtData.ChartAreas[0].AxisX.Title = "MONTH";
            chtData.ChartAreas[0].AxisY.Title = "€'s";
            chtData.Series[0].IsVisibleInLegend = false;


            chtData.Visible = true;*/
        }
    }
}
