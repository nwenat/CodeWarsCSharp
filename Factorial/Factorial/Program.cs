using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException();
            }
            int answer = 1;

            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }

            return answer;
        }
    }
}
