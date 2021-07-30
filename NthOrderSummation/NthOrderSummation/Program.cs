using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NthOrderSummation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(S(2, 5));
            Console.WriteLine(S(1, 1));
            Console.WriteLine(S(3, 7));
            Console.WriteLine(S(0, 7));
        }

        public static BigInteger S(BigInteger m, BigInteger n)
        {
            //---------recursion

            //if (m == 0)
            //{
            //    return 1;
            //}
            //else if (m == 1)
            //{
            //    return n;
            //}

            //BigInteger answer = 0;
            //for (int k = 1; k <= n; k++)
            //{
            //    answer += S(m - 1, k);
            //}

            BigInteger[] arr = new BigInteger[(int)m + 1];
            for (int i = 0; i <= m; i++)
            {
                arr[i] = 1;
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    arr[j] += arr[j - 1];
                }
            }

            return arr[(int)m];
        }
    }
}
