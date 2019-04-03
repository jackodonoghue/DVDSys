using System;
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
    }
}
