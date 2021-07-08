using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfRectanglesInAGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfRectangles(4, 4));
        }
        public static int NumberOfRectangles(int m, int n)
        {
            int answer = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    answer += (m - i + 1) * (n - j + 1);
                }
            }
            return answer;
        }
    }
}
