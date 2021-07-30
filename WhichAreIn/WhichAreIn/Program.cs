using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichAreIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(inArray(new string[] { "arp", "live", "strong" }, new string[] { "lively", "alive", "harp", "sharp", "armstrong" }));
        }

        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> r = new List<string>();

            foreach (var s in array1)
            {
                foreach (var s2 in array2)
                {
                    if (s2.Contains(s))
                    {
                        r.Add(s);
                    }
                }
            }

            return r.Distinct().OrderBy(s => s).ToArray();
        }
    }
}
