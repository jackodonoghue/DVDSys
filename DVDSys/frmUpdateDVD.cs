﻿using System;
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
    public partial class frmUpdateDVD : Form
    {
        frmHome parent;
        private int ID;

        public frmUpdateDVD()
        {
            InitializeComponent();
        }

        public frmUpdateDVD(frmHome Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void frmUpdateDVD_Load(object sender, EventArgs e)
        {
            DVDType type = new DVDType();
            //Get types for drop down 
            DataSet ds = type.GetTypesFromDatabase(); 


            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboType.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        //
        //Search button clicked
        //
        private void btnSearchSubmit_Click(object sender, EventArgs e)
        {
            //validate input
            if (!Validation.ValidateTypeName(txtSearch.Text))
            {
                MessageBox.Show("Title character invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }
            
            else
            {
                //search DVD


                //Search
                DataSet ds = new DataSet();

                String searched = txtSearch.Text;

                grdSearch.DataSource = DVD.getDVDS(ds, searched.ToUpper()).Tables["stk"];
                grdSearch.AllowUserToAddRows = false;

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //reset UI
                txtSearch.Clear();

                txtSearch.Focus();
            }           
        }
        //
        //Fill cells with data from table
        //
        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = grdSearch.Rows[rowIndex];

            ID = int.Parse(row.Cells[0].Value.ToString());
            cboType.Text = (String)row.Cells[1].Value;
            txtTitle.Text = (String)row.Cells[2].Value;
            txtDir.Text = (String)row.Cells[3].Value;
            txtGenre.Text = (String)row.Cells[4].Value;
            dtpRelease.Value = Convert.ToDateTime(row.Cells[5].Value);
        }
        //
        //update dvd button clicked
        //
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //validate input
            if (isValid())
            {

                DVD dvd = new DVD(ID, txtTitle.Text.ToUpper(), cboType.Text.ToUpper(), txtDir.Text.ToUpper(), txtGenre.Text.ToUpper(), dtpRelease.Text.ToUpper(), 'A');

                //save data in file
                if (DVD.getDVDStatus(ID).Equals("A ") || DVD.getDVDStatus(ID).Equals("U "))
                {
                    dvd.updateDVD();
                }
                else
                {
                    MessageBox.Show("DVD could not be updated as DVD is currently unavailable", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                

                //reset UI
                txtTitle.Clear();
                txtDir.Clear();
                txtGenre.Clear();
                //activeTB.Clear();

                txtTitle.Focus();
            }
        }
        //
        //Validate Inputs
        //
        private Boolean isValid()
        {
            //validate input
            if (txtTitle.Text.Equals(""))
            {
                MessageBox.Show("Title must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return false;
            }

            if (txtDir.Text.Equals(""))
            {
                MessageBox.Show("Director must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDir.Focus();
                return false;
            }

            if (txtGenre.Text.Equals(""))
            {
                MessageBox.Show("Genre must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGenre.Focus();
                return false;
            }
            if (!Validation.ValidateTypeName(txtTitle.Text))
            {
                MessageBox.Show("Title contains invalid characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return false;
            }

            if (!Validation.ValidateName(txtDir.Text))
            {
                MessageBox.Show("Director contains invalid characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDir.Focus();
                return false;
            }

            if (!Validation.ValidateTypeName(txtGenre.Text))
            {
                MessageBox.Show("Genre contains invalid characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGenre.Focus();
                return false;
            }

            return true;
        }
        //
        //Reset form button clicked
        //
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            cboType.ResetText();
            txtDir.Clear();
            txtGenre.Clear();
            dtpRelease.ResetText();
            
            txtTitle.Focus();
        }
        //
        //Reset search button clicked
        //
        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.Focus();
        }
    }
}
