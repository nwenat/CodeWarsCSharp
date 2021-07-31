using System;

namespace SpeedControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gps(15, new double[] { 0.0, 0.19, 0.5, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.25 }));
        }

        public static int Gps(int s, double[] x)
        {
            int result = 0;
            for (int i = 1; i < x.Length; i++)
            {
                int v = (int)(3600 * (x[i] - x[i - 1]) / s);
                result = v > result ? v : result;
            }
            return result;
        }
    }
}
