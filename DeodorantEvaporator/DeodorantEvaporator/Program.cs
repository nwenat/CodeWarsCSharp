using System;

namespace DeodorantEvaporator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(evaporator(10, 10, 10));
        }

        public static int evaporator(double content, double evap_per_day, double threshold)
        {
            int days = 0;
            while (content * Math.Pow((100 - evap_per_day) / 100, days) > content * threshold / 100)
            {
                days++;
            }
            return days;
        }
    }
}
