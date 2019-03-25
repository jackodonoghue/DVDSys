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
    public partial class frmUpdateDVDType : Form
    {
        frmHome parent;

        private String type;

        public frmUpdateDVDType()
        {
            InitializeComponent();
        }

        public frmUpdateDVDType(frmHome Parent)
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

        private void custUpdateResults_CellDoubleClickContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
           
            DataGridViewRow row = dgvSearch.Rows[rowIndex];

            type = row.Cells[0].Value.ToString();
            nupPrice.Value = Convert.ToDecimal(row.Cells[2].Value);
            txtDescription.Text = row.Cells[1].Value.ToString();
        }

        private void frmUpdateDVDType_Load(object sender, EventArgs e)
        {
            //Fill DataGridView
            DataSet ds = new DataSet();

            dgvSearch.DataSource = Type.getTypes(ds).Tables["stk"];
        }

        private void submit_Click(object sender, EventArgs e)
        {
            //Save to DB
            String desc = txtDescription.Text;
            double price = Convert.ToDouble(nupPrice.Value);

            Type up = new Type(type, desc, price);


            up.updateType();

            //reset UI
            txtType.Clear();
            nupPrice.ResetText();
            txtDescription.Clear();

            txtType.Focus();

        }

        private void updateSubmit_Click(object sender, EventArgs e)
        {
            //Validate search
            if (!Vali.valTypeName(txtType.Text))
            {
                MessageBox.Show("Searched invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Clear();
                txtType.Focus();
                return;
            }
            else
            {
                //Search
                DataSet ds = new DataSet();

                String searched = txtType.Text;

                dgvSearch.DataSource = Type.getSearchTypes(ds, searched).Tables["stk"];

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //reset UI
                txtType.Clear();           

                txtType.Focus();
            }    

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset UI
            txtType.Clear();
            nupPrice.Value = 0;
            txtDescription.Clear();
        }
    }
}
