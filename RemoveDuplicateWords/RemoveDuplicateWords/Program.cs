using System;
using System.Linq;

namespace RemoveDuplicateWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveDuplicateWords("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta"));
        }

        public static string RemoveDuplicateWords(string s)
        {
            return String.Join(" ", s.Split(' ', StringSplitOptions.None).Distinct());
        }
    }
}
