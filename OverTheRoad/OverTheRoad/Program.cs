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
            return 2 * n - address + 1;
        }
    }
}
