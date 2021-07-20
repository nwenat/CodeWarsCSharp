using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheDivisorsOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divisors(54));
        }

        public static int Divisors(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    answer++;
                }
            }
            return answer;
        }
    }
}
