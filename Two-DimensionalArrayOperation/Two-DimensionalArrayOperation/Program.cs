using System;

namespace Two_DimensionalArrayOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Result(new int[,] { { 7, 1, 5, 8 }, { 2, 1, 4, 9 }, { 3, 2, 4, 7 } }));
        }

        public static int Result(int[,] array)
        {
            int n = array.GetLength(0);
            int sum = 0;
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < array.Length / n ; j++)
                {
                    sum += array[i, j];
                }
                Console.WriteLine(sum);
                result *= sum;
                sum = 0;
            }
            return result;
        }
    }
}
