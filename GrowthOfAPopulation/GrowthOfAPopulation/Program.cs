using System;

namespace GrowthOfAPopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NbYear(1500, 5, 100, 5000));
        }

        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int years = 0;
            int population = p0;
            do
            {
                years++;
                population = (int)(population * (1 + percent/100) + aug);
            }
            while (population < p);
            return years;
        }
    }
}
