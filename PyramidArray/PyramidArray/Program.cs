using System;

namespace PyramidArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pyramid(2));
        }

        public static int[][] Pyramid(int n)
        {
            int[][] output = new int[n][];

            for (int i = 0; i < n; i++)
            {
                output[i] = new int[i+1];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    output[i][j] = 1;
                }
            }

            return output;
        }
    }
}
