using System;

namespace SplitInParts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SplitInParts("supercalifragilisticexpialidocious", 3));
        }

        public static string SplitInParts(string s, int partLength)
        {
            int j = 0;
            string answer = s;
            for (int i = 1; i <= s.Length / partLength; i++)
            {
                answer = answer.Insert(partLength * i + j, " ");
                j++;
            }
            return answer.Trim();
        }
    }
}
