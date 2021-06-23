using System;
using System.Linq;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OddOrEven(new int[] {1}));
        }

        public static string OddOrEven(int[] array)
        {
            
            //if (array.Length == 0)
            //{
            //    return "even";
            //}
            //int sum = array.Aggregate((a, b) => a + b);

            return array.Sum() % 2 == 0 ? "even" : "odd";
        }
    }
}
