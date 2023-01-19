using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatStr(3, "tak"));

        }

        public static string RepeatStr(int n, string s)
        {
            string answer = "";
            for (int i = 0; i < n; i++)
            {
                answer += s;
            }
            return answer;
        }
    }
}
