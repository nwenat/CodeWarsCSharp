using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrays_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortMe(new[] { "one", "two", "three" }));
        }

        public static string[] SortMe(string[] names)
        {
            Array.Sort(names);
            return names;
        }
    }
}
