using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookingForABenefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NewAvg(new double[] {14, 30, 5, 7, 9, 11, 15}, 30));
        }

        public static long NewAvg(double[] arr, double navg)
        {
            long x = Convert.ToInt64(Math.Ceiling(navg * (arr.Length + 1) - arr.Sum()));
            return x >= 0 ? x : throw new ArgumentException();
        }
    }
}
