using System;

namespace Heron_sFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(heron(3, 4, 5));
        }

        public static double heron(double a, double b, double c)
        {
            double s = (a + b + c) / 2;

            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
