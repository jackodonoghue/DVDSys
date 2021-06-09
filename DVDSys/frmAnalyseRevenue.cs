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
    public partial class frmAnalyseRevenue : Form
    {
        frmHome parent;
        public frmAnalyseRevenue()
        {
            InitializeComponent();
        }
        public frmAnalyseRevenue(frmHome Parent)
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

        private void frmAnalyseRevenue_Load(object sender, EventArgs e)
        {
            loadYears();
        }
        //
        //Load years to chart 
        //
        public void loadYears()
        {
            int year = Convert.ToInt32(String.Format("{0:yyyy}", DateTime.Today));

            for(int i=0;i<=3;i++)
            { 
                cboYear.Items.Add(year - i);
            }
        }
        //
        //Display chart
        //
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

             Payment.getRevenue(dt, cboYear.SelectedItem.ToString().Substring(2,2));

            //Array for each month
            string[] months = new string[12];

            //Array for each value per month
            decimal[] amounts = new decimal[12];

            for(int i = 0; i < dt.Rows.Count; i++) {
                amounts[Convert.ToInt32(dt.Rows[i][1]) - 1] = Convert.ToDecimal(dt.Rows[i][0]);
            }

            for (int i = 0; i < 12; i++)
            {
                months[i] = Payment.getMonthForAnalysis(i + 1);
            }

            //Chart Style
            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "Revenue in €";

            chtData.Series["Series1"]["PointWidth"] = ".5";

            chtData.Series["Series1"]["PixelPointWidth"] = "20";
            chtData.Series[0].Points.DataBindXY(months, amounts);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";
            
            chtData.Series[0].Label = "#VALY";

            chtData.Titles.Clear();
            chtData.Titles.Add("Yearly Revenue");
            chtData.ChartAreas[0].AxisX.Title = "MONTH";
            chtData.ChartAreas[0].AxisY.Title = "Revenue in €'s";
            chtData.Series[0].IsVisibleInLegend = true;


            chtData.Visible = true;
        }
    }
}
