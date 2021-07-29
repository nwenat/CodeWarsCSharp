using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumLengthDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mxdiflg(new string[] { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" }, 
                new string[] { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" }));

        }

        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length == 0 || a2.Length == 0)
            {
                return -1;
            }

            int ans1 = Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length));
            int ans2 = Math.Abs(a2.Max(x => x.Length) - a1.Min(x => x.Length));

            return ans1 > ans2 ? ans1: ans2;
        }
    }
}
