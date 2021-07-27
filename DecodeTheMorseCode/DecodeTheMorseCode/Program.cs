using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeTheMorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Decode(".... . -.--   ...---...   .--- ..- -.. ."));
        }

        public static string Decode(string morseCode)
        {
            string decode = "";
            string decode2 = "";
            string[] words = morseCode.Split(new string[] {"   "}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                string[] letters = word.Split(' ');
                foreach (var letter in letters)
                {
                    if (letter == "...---...") 
                    {
                        decode += "SOS";
                    }

                    else if (_toMorse.ContainsKey(letter))
                    { 
                        decode += _toMorse[letter];
                    }
                }
                decode += " ";

            }
            return decode.Trim();
        }

        private static Dictionary<string, char> _toMorse = new Dictionary<string, char>()
        {
          {"/", ' '},
          {".-", 'A'},
          {"-...", 'B'},
          {"-.-.", 'C'},
          {"-..", 'D'},
          {".", 'E'},
          {"..-.", 'F'},
          {"--.", 'G'},
          {"....", 'H'},
          {"..", 'I'},
          {".---", 'J'},
          {"-.-", 'K'},
          {".-..", 'L'},
          {"--", 'M'},
          {"-.", 'N'},
          {"---", 'O'},
          {".--.", 'P'},
          {"--.-", 'Q'},
          {".-.", 'R'},
          {"...", 'S'},
          {"-", 'T'},
          {"..-", 'U'},
          {"...-", 'V'},
          {".--", 'W'},
          {"-..-", 'X'},
          {"-.--", 'Y'},
          {"--..", 'Z'},
          {".----", '1'},
          {"..---", '2'},
          {"...--", '3'},
          {"....-", '4'},
          {".....", '5'},
          {"-....", '6'},
          {"--...", '7'},
          {"---..", '8'},
          {"----.", '9'},
          {"-----", '0'},
          {".-.-.-", '.'},
          {"-.-.--", '!'},
        };
    }
}
