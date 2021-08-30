using System;

namespace PointInAUnitCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PointInCircle(1, 0));
        }

        public static bool PointInCircle(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) < 1; ;
        }
    }
}
