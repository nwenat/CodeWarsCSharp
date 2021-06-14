using System;
using System.Text.RegularExpressions;

namespace ReversingAProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Decode("1234567890gf"));
            //Console.WriteLine(Decode("1273409kuqhkoynvvknsdwljantzkpnmfgf"));
            Console.WriteLine(Decode("5057aan"));
            Console.WriteLine("uogbucwnddunktsjfanzlurnyxmx");
        }

        public static String Decode(String r)
        {
            int x = Regex.Match(r, "[a-z]").Index;
            int j = Int32.Parse(r.Substring(0, x));
            string code = r.Substring(x, r.Length - x);

            string result = "";

            foreach (char c in code)
            {
                int a = (int)c - 97;

                char? b = null;
                for (int i = 0; i < 26; i++)
                {
                    if (i * j % 26 == a)
                    {
                        b = (char)(i + 97);
                        result += b;
                        break;
                    }
                    if (i == 25 && b.Equals(null))
                    {
                        return "Impossible to decode";
                    }
                }
            }
            return result;
        }
    }
}
