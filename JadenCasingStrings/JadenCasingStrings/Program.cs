using System;
using System.Linq;

namespace JadenCasingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));
        }

        public static string ToJadenCase(string phrase)
        {
            return String.Join(' ', phrase.Split(' ', StringSplitOptions.None).ToList().ConvertAll(x => String.Concat(x[0].ToString().ToUpper(), x.Substring(1))));
        }

    }
}
