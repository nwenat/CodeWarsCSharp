using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SumOfInegersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfIntegersInString("C4t5 are 4m4z1ng."));
        }

        public static int SumOfIntegersInString(string s)
        {
            string[] numbers = Regex.Split(s, @"\D+");
            return numbers.Where(x => x != "").Sum(a => Int32.Parse(a));

            //int sum = 0;
            //int sum2 = 0;

            //foreach (var item in numbers)
            //{
            //    if (Int32.TryParse(item, out sum2))
            //    {
            //        sum += Int32.Parse(item);
            //    }
            //}
            //return sum;
        }
    }
}
