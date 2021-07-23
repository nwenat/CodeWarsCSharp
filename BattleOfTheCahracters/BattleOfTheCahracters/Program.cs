using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTheCahracters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Battle("AAA", "Z"));
        }

        public static string Battle(string x, string y)
        {
            int sx = x.Sum(c => (int)c - 64);
            int sy = y.Sum(c => (int)c - 64);

            //foreach (var c in x)
            //{
            //    sx += c - 64;
            //}
            //foreach (var c in y)
            //{
            //    sy += c - 64;
            //}
            
            return sx == sy? "Tie!" : sx > sy ? x : y;
        }
    }
}
