using System;
using System.Text.RegularExpressions;

namespace FIXMEReplaceAllDotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceDots("one.two.three"));
        }

        public static string ReplaceDots(string str)
        {
            return new Regex("\\.").Replace(str, "-");
        }
    }
}
