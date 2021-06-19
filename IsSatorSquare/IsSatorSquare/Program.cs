using System;

namespace IsSatorSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSatorSquare(new char[4, 4] {{'K', 'N', 'I', 'T'},
                                       {'N', 'O', 'R', 'I'},
                                       {'I', 'R', '0', 'N'},  
                                       {'T', 'I', 'N', 'K'}}));
        }

        public static bool IsSatorSquare(char[,] tablet)
        {
            int n = (Int32)Math.Sqrt(tablet.Length) - 1;
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if((tablet[i, j] != tablet[j, i]) 
                        || (tablet[n - i, n - j] != tablet[n-j, n-i])
                        || (tablet[i, j] != tablet[n - j, n - i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
