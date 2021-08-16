using System;

namespace VasyaClerk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tickets(new int[] { 25, 100 }));
        }

        public static string Tickets(int[] peopleInLine)
        {
            int i25 = 0;
            int i50 = 0;
            //int i100 = 0;

            for (int i = 0; i < peopleInLine.Length; i++)
            {
                switch (peopleInLine[i])
                {
                    case 25:
                        i25++;
                        break;
                    case 50:
                        i50++;
                        if (i25 > 0)
                        {
                            i25--;
                        }
                        else
                        {
                            return "NO";
                        }
                        break;
                    case 100:
                        //i100++;
                        if (i25 > 0 && i50 > 0)
                        {
                            i25--;
                            i50--;
                        }
                        else if (i25 > 2)
                        {
                            i25 -= 3;
                        }
                        else
                        {
                            return "NO";
                        }
                        break;
                }
            }

            return "YES";
        }
    }
}
