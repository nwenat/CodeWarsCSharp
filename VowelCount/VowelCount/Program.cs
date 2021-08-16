using System;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("abracadabra"));
        }

        public static int GetVowelCount(string str)
        {
            string s = str.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
            return str.Length - s.Length;
        }
    }
}
