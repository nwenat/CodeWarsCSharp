using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallUpwards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxBall(15));
        }

        public static int MaxBall(int v0)
        {
            int t2 = 1;
            double h1 = 0;
            double h2 = 0;

            do
            {
                h2 = v0 * (1000.0 / 3600.0) * t2 * 0.1 - (0.5 * 9.81 * t2 * t2 * 0.1 * 0.1);
                if (h2 < h1)
                {
                    return t2 - 1;
                }
                else
                {
                    h1 = h2;
                    t2++;
                }
            } while (h2 == h1);

            return -1;
        }
    }
}
