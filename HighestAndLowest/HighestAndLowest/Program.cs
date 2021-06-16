using System;
using System.Linq;

namespace HighestAndLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }

        public static string HighAndLow(string numbers)
        {
            int min = Int32.Parse(numbers.Substring(0, numbers.IndexOf(" ")));
            int max = Int32.Parse(numbers.Substring(0, numbers.IndexOf(" ")));
            int i;
            string[] arr = numbers.Split(" ");
            foreach (string s in arr)
            {
                i = Int32.Parse(s);
                if (i < min)
                {
                    min = i;
                }
                else if(i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine(max + " " + min);
            return max + " " + min;
        }
    }
}
