using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ScalingSquaredStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Scale("Kj\nSH", 3, 2));
            Console.WriteLine("-----");
            Console.WriteLine(Scale("", 3, 2));

        }

        public static string Scale(string strng, int k, int n)
        {
            if (strng == "")
            {
                return "";
            }

            string ans = "";
            foreach (var c in strng)
            {
                for (int i = 0; i < k; i++)
                {
                    ans += c;
                }
                
            }
            string pattern = "\\n+";
            string replecemnt = "\n";
            Regex rgx = new Regex(pattern);
            ans = rgx.Replace(ans, replecemnt);

            string answer = "";
            foreach (var line in ans.Split('\n'))
            {
                for (int i = 0; i < n; i++)
                {
                    answer += line + "\n";
                }
            }
            answer = answer.Substring(0, answer.Length - 1);
            return answer;
        }
    }
}
