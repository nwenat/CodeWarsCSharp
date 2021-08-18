using System;
using System.Linq;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortNumbers(new int[] { 1, 2, 3, 10, 5 }).ToList().ForEach(n => Console.WriteLine(n));
            SortNumbers(null).ToList().ForEach(n => Console.WriteLine(n));
        }

        public static int[] SortNumbers(int[] nums)
        {
            if (nums == null)
            {
                return new int[] { };
            }
            int n = nums.Length;
            while (n > 1)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    int temp;
                    if (nums[i] > nums[i + 1])
                    {
                        temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                }
                n--;
            }
            return nums;

            //Array.Sort(nums);

            //return nums != null ? nums : Array.Empty<int>();

        }
    }
}
