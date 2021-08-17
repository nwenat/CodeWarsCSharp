using System;

namespace TheFeastOfManyBeasts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Feast("great blue heron", "garlic naan"));
        }

        public static bool Feast(string beast, string dish)
        {
            return dish.StartsWith(beast[0]) && dish.EndsWith(beast[beast.Length-1]);
        }
    }
}
