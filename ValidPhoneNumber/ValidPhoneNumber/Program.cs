using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "(123) 456-7890";
            Console.WriteLine(ValidPhoneNumber(test));
        }

        public static bool ValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 14 || phoneNumber[0] != '(' || phoneNumber[4] != ')' || phoneNumber[5] != ' ' || phoneNumber[9] != '-')
            {
                return false;
            }
            return Regex.Replace(phoneNumber, @"[\d]", string.Empty).ToString().Length == 4 ? true: false;
        }
    }
}
