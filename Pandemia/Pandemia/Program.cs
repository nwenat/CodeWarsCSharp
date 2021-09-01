using System;

namespace Pandemia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(infected("01000000X000X011X0X"));
        }

        public static double infected(string s)
        {
            int total = 0;
            int infected = 0;
            foreach (string continent in s.Split('X'))
            {
                total += continent.Length;
                infected += continent.Contains('1') ? continent.Length : 0;
            }
            return total == 0 ? 0 : 100.0 * infected / total;
        }
    }
}
