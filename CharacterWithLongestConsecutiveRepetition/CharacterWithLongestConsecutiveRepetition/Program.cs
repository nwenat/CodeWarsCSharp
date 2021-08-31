using System;

namespace CharacterWithLongestConsecutiveRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestRepetition("aaaabbaa"));
        }

        public static Tuple<char?, int> LongestRepetition(string input)
        {
            char? character = null;
            int length = 0;

            while(input.Length > 0)
            {
                char c = input[0];
                int l = 0;
                do
                {
                    input = input.Remove(0, 1);
                    l++;
                } while (input.StartsWith(c));

                if(l > length)
                {
                    character = c;
                    length = l;
                }
            }
            return new Tuple<char?, int>(character, length);
        }
    }
}
