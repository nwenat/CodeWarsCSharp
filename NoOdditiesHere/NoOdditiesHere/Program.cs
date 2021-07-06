using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOdditiesHere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NoOdds(new int[] { 1, 2, 3, 4, 5 }));
        }

        public static int[] NoOdds(int[] values)
        {
            int x = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if(values[i] % 2 == 0)
                {
                    x++;
                }
            }

            int[] answer = new int[x];
            x = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    answer[x] = values[i];
                    x++;
                }
            }

            return answer;
        }
    }
}
