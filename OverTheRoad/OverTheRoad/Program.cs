using System;

namespace OverTheRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(overTheRoad(2, 3));
        }

        public static long overTheRoad(long address, long n)
        {
            int[] arr = new int[n];
            int k;
            if (address % 2 == 0)
            {
                k = 1;
            }
            else
            {
                k = 2;
            }
            for (int i = 0; i < n; i++)
            {
                arr[i] = k;
                k += 2;
            }
            return arr[(n - 1) - (address /2)];
        }
    }
}
