using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsLeapYear(1984));
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                return  (year % 100 == 0 && year % 400 != 0) ? false: true;
            }
            return false;
        }
    }
}
