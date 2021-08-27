using System;

namespace HelpTheBookseller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(stockSummary(new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" }, new String[] { "A", "B" }));
        }

        public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
        {
            string output = "";

            if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0)
            {
                return output;
            }
            
            int sum = 0;

            for (int i = 0; i < lstOf1stLetter.Length; i++)
            {
                foreach (var item in lstOfArt)
                {
                    if (item.StartsWith(lstOf1stLetter[i]))
                    {
                        sum += Int16.Parse(item.Substring(item.IndexOf(" ")));
                    }
                }
                output += $"({lstOf1stLetter[i]} : {sum}) - ";
                sum = 0;
            }
            output = output.Substring(0, output.Length - 3);
            return output;
        }
    }
}
