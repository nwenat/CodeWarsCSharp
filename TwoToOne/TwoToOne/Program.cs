using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Longest("dcba", "zyx"));
        }

        public static string Longest(string s1, string s2)
        {
            return new string((s1 + s2).ToList().Distinct().OrderBy(c => c).ToArray());
        }
    }
}
