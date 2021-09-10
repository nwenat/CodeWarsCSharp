using System;
using System.Linq;

namespace ArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 });
        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            return a.Where(x => !b.Contains(x)).ToArray();
        }
    }
}
