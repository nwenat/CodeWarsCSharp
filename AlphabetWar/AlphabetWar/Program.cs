using System;

namespace AlphabetWar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlphabetWar("z"));
        }

        public static string AlphabetWar(string fight)
        {
            int left = 0;
            int right = 0;

            for (int i = 0; i < fight.Length; i++)
            {
                switch (fight[i])
                {
                    case 'w':
                        left += 4;
                        break;
                    case 'p':
                        left += 3;
                        break;
                    case 'b':
                        left += 2;
                        break;
                    case 's':
                        left += 1;
                        break;
                    case 'm':
                        right += 4;
                        break;
                    case 'q':
                        right += 3;
                        break;
                    case 'd':
                        right += 2;
                        break;
                    case 'z':
                        right += 1;
                        break;
                    default:
                        break;
                }
            }
            return left == right ? "Let's fight again!" : left > right ? "Left side wins!": "Right side wins!";
        }
    }
}
