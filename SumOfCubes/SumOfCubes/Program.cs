using System;

namespace SumOfCubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumCubes(3));
        }

        public static long SumCubes(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += (long)Math.Pow(i, 3);
            }
            return sum;
        }
    }
}
