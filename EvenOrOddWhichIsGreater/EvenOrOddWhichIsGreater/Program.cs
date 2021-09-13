using System;
using System.Linq;

namespace EvenOrOddWhichIsGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd("123"));
        }

        public static string EvenOrOdd(string str)
        {
            int even = str.ToList().ConvertAll(x => int.Parse(x.ToString())).Where(x => x % 2 == 0).Sum();
            int odd = str.ToList().ConvertAll(x => int.Parse(x.ToString())).Where(x => x % 2 != 0).Sum();
            return even == odd ? "Even and Odd are the same" : odd > even ? "Odd is greater than Even" : "Even is greater than Odd";
        }
    }
}
