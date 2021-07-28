using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprayingTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Task("Wednesday", 10, 2));
        }

        public static string Task(string w, int n, int c)
        {
            string name = "";
            switch (w)
            {
                case "Monday":
                    name = "James";
                    break;
                case "Tuesday":
                    name = "John";
                    break;
                case "Wednesday":
                    name = "Robert";
                    break;
                case "Thursday":
                    name = "Michael";
                    break;
                case "Friday":
                    name = "William";
                    break;
            }
            return "It is " + w + " today, " + name + ", you have to work, you must spray " + n + " trees and you need " + n * c + " dollars to buy liquid";
        }
    }
}
