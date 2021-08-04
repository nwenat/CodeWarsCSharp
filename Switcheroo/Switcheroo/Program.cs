using System;

namespace Switcheroo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Switcheroo("aaabcccbaaa"));
        }

        public static string Switcheroo(string x)
        {
            x = x.Replace('a', 'z').Replace('b', 'a').Replace('z', 'b');
            return x;
        }
    }
}
