using System;

namespace CountByX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountBy(2, 5));
        }

        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n];
            for (int i = 0; i < n; i++)
            {
                z[i] = x * (i + 1);
                Console.WriteLine(z[i]);
            }

            return z;
        }
    }
}
