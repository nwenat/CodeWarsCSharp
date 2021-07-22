using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareDigits(9119));
        }

        public static int SquareDigits(int n)
        {
            string nn = n.ToString();
            string a = "";
            int j = 0;
            for (int i = 0; i < nn.Length; i++)
            {
                j = (int)Math.Pow(Double.Parse(nn[i].ToString()), 2);
                a += j;
            }
            return Int32.Parse(a);
        }
    }
}
