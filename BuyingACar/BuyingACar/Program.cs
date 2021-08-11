using System;

namespace BuyingACar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(nbMonths(2000, 8000, 1000, 1.5));
        }

        public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            int months = 0;
            double balance = startPriceOld - startPriceNew;
            double newCar = startPriceNew;
            double oldCar = startPriceOld;

            while (balance < 0)
            {
                percentLossByMonth += months % 2 == 1 ? 0.5 : 0;
                months++;
                newCar = newCar * (1 - (percentLossByMonth / 100));
                oldCar = oldCar * (1 - (percentLossByMonth / 100));
                balance = oldCar - newCar + savingPerMonth * months;
            }
            return new int[] {months, (int)Math.Round(balance)};
        }
    }
}
