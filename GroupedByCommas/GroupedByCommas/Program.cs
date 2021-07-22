using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupedByCommas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GroupByCommas(123456));
        }

        public static string GroupByCommas(int n)
        {
            string a = "";
            int m = 0;
            for (int i = n.ToString().Length - 1; i >= 0 ; i--)
            {
                a = n.ToString()[i] + a;
                m++;
                if (m % 3 == 0 && i != 0)
                {
                    a = "," + a;
                }
            }
            return a;
        }
    }
}
