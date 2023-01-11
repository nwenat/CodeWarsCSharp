using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("yoda doesn't speak like this"));

        }

        public static string ReverseWords(string str)
        {
            var list = str.Split(' ').ToList();

            list.Reverse();
            return String.Join(" ", list);

            //string answer = "";
            //foreach (var item in list)
            //{
            //    answer = item + " " + answer;
            //}

            //return answer.Trim();
        }
    }
}
