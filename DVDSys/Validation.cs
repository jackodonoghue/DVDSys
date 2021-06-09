using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DVDSys
{
    class Validation
    {
        public static bool ValidateName(string name)
        {
            Regex nameCheck = new Regex("^[a-zA-Z ,.'-]*$");

            return nameCheck.IsMatch(name);
        }

        public static bool ValidateTypeName(string type)
        {
            Regex typeCheck = new Regex("^[a-zA-Z 1-9]*$");

            return typeCheck.IsMatch(type);
        }

        public static bool ValidatePhoneNumber(string number)
        {
            Regex numberCheck = new Regex("^[0-9]*$");

            return numberCheck.IsMatch(number);
        }
    }
}
