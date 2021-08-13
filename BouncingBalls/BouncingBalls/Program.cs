using System;

namespace BouncingBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(bouncingBall(30.0, 0.66, 1.5));
        }

        public static int bouncingBall(double h, double bounce, double window)
        {
            if (h > 0 && window < h && bounce > 0 && bounce < 1)
            {
                int result = 1;
                int interation = 1;
                while (h * Math.Pow(bounce, interation) > window)
                { 
                    interation++;
                    result += 2;
                }
                return result;
            }
            return -1;
        }
    }
}
