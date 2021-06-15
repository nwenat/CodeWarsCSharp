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
            //Console.WriteLine(Decode("5057aan"));
            Console.WriteLine(Decode("105860ymmgegeeiwaigsqkcaeguicc"));
            Console.WriteLine("uogbucwnddunktsjfanzlurnyxmx");
        }

        public static String Decode(String r)
        {
            int x = Regex.Match(r, "[a-z]").Index;
            int j = Int32.Parse(r.Substring(0, x));
            string code = r.Substring(x, r.Length - x);

            for (char i = 'a'; i <= 'z'; i++)
            {
                int a = (int)i - 97;

                for (int h = 0; h < 26; h++)
                {
                    if (h * j % 26 == a)
                    {
                        break;
                    }
                    if (h == 25)
                    {
                        return "Impossible to decode";
                    }
                }
            }

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
                }
            }
            return result;
        }
    }
}
