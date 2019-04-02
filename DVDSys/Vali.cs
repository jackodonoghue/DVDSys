﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DVDSys
{
    class Vali
    {
        public static Boolean valName(String name)
        {
            //Boolean result = true;
            Regex nameCheck = new Regex("^[a-zA-Z ,.'-]*$");

            if (nameCheck.IsMatch(name))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static Boolean valTypeName(String name)
        {
            //Boolean result = true;
            Regex nameCheck = new Regex("^[a-zA-Z 1-9]*$");

            if (nameCheck.IsMatch(name))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static Boolean valPhoneNumber(String number)
        {
            //Boolean result = true;
            Regex numberCheck = new Regex("^[0-9]*$");

            if (numberCheck.IsMatch(number))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        /* //validate input add
             if (fNameTB.Text.Equals(""))
             {
                 MessageBox.Show("First name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 fNameTB.Focus();
                 return;
             }

             if (sNameTB.Text.Equals(""))
             {
                 MessageBox.Show("First name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 sNameTB.Focus();
                 return;
             }

             if (addressTB1.Text.Equals(""))
             {
                 MessageBox.Show("Please enter full address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 addressTB1.Focus();
                 return;
             }

             if (eirTB.Text.Equals(""))
             {
                 MessageBox.Show("Eircode must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 eirTB.Focus();
                 return;
             }

             if (genTB.Text.Equals(""))
             {
                 MessageBox.Show("gender must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 genTB.Focus();
                 return;
             }

             if (phNumTB.Text.Equals(""))
             {
                 MessageBox.Show("Phone number must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 phNumTB.Focus();
                 return;
             }*/


        /*//validate input update
            if (custNameUpdateTB.Text.Equals(""))
            {
                MessageBox.Show("Name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                custNameUpdateTB.Focus();
                return;
            }

            if (fNameTB.Text.Equals(""))
            {
                MessageBox.Show("First name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fNameTB.Focus();
                return;
            }

            if (sNameTB.Text.Equals(""))
            {
                MessageBox.Show("First name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sNameTB.Focus();
                return;
            }

            if (addressTB1.Text.Equals("") || addressTB2.Text.Equals("") || addressTB3.Text.Equals(""))
            {
                MessageBox.Show("Please enter full address", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                addressTB1.Focus();
                return;
            }

            if (eirTB.Text.Equals(""))
            {
                MessageBox.Show("Eircode must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                eirTB.Focus();
                return;
            }

            if (genTB.Text.Equals(""))
            {
                MessageBox.Show("gender must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                genTB.Focus();
                return;
            }

            if (phNumTB.Text.Equals(""))
            {
                MessageBox.Show("Phone number must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phNumTB.Focus();
                return;
            }*/

        /*//validate input remove customer
            if (custNameRemoveTB.Text.Equals(""))
            {
                MessageBox.Show("Name must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                custNameRemoveTB.Focus();
                return;
            }

            if (!accStatusTB.Text.Equals("R"))
            {
                MessageBox.Show("Status must be changed to 'R'", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                accStatusTB.Focus();
                return;
            }  */
    }
}
