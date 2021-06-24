using System;

namespace StringEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("samurai", "ai"));
        }

        public static bool Solution(string str, string ending)
        {

            return str.EndsWith(ending) ? true : false;

            //if (str.EndsWith(ending))
            //{
            //    return true;
            //} else
            //{
            //    return false;
            //}
        }
    }
}
