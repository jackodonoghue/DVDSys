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
    public partial class frmDVDRet : Form
    {
        frmHome parent;

        public frmDVDRet()
        {
            InitializeComponent();
        }

        public frmDVDRet(frmHome Parent)
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
        //
        //Search DVD
        //
        private void btnSearch_Click(object sender, EventArgs e)
        {        
            //Validate search
            if (!Validation.ValidateTypeName(txtSearch.Text))
            {
                MessageBox.Show("DVD name invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Focus();
                return;
            }

            //Search
            DataSet ds = new DataSet();

            grdSearch.DataSource = DVD.getRentedDVDS(ds, txtSearch.Text.ToUpper()).Tables["stk"];
            grdSearch.AllowUserToAddRows = false;
                
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No results found, please try again", "No Results!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        // Reset Button Clicked -- Reset UI
        //
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            lstCart.Items.Clear();
        }
        //
        //Selected DVD to return
        //
        private void dgvSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean alreadyEntered = false;

            for (int i = 0; i < lstCart.Items.Count; i++)
            {
                if (Convert.ToInt32(grdSearch.Rows[grdSearch.CurrentCell.RowIndex].Cells[0].Value) == Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 1)))
                {
                    MessageBox.Show("DVD already in cart!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    alreadyEntered = true;
                    break;
                }
            }

            if (!alreadyEntered)
            {
                int rowIndex = e.RowIndex;

                DataGridViewRow row = grdSearch.Rows[rowIndex];

                lstCart.Items.Add(row.Cells[0].Value.ToString() + " " + (String)row.Cells[2].Value);
            }                      
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstCart.Items.Count; i++)
            {
                Rental.returnDVD(Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 1)));
            }
        }
    }
}

