using System;
using System.Collections.Generic;

namespace AllInclusive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainAllRots("", new List<string>() { "bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs" }));
        }
        public static Boolean ContainAllRots(string strng, List<string> arr)
        {
            if (strng == "")
            {
                return true;
            }
            string test = strng;
            for (int i = 0; i <= strng.Length; i++)
            {
                test = strng.Substring(i, strng.Length - i) + strng.Substring(0, i);
                if (!arr.Contains(test))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
