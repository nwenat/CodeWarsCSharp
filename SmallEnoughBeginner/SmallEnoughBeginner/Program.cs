using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallEnoughBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallEnough(new int[] { 66, 101 }, 200));
        }

        public static bool SmallEnough(int[] a, int limit)
        {
            //for (int i = 0; i < a.Length; i++)
            //{
            //    if (a[i] > limit)
            //    {
            //        return false;
            //    }
            //}
            //return true;

            return a.Max() > limit ? false : true;
        }
    }
}
