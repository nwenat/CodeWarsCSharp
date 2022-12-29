using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanMeans
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Geo_Mean(new int[] { 1, 2 }, 3));
        }

        public static double Geo_Mean(int[] nums, double arith_mean)
        {
            double number = arith_mean * (nums.Length + 1);
            foreach (int num in nums)
            {
                number -= num;
            }

            double answer = number;

            foreach (int num in nums)
            {
                answer *= num;
            }

            return (double)Math.Pow(answer, ((double)1 / (nums.Length + 1)));
        }
    }
}
