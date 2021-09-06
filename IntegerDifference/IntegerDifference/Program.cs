using System;

namespace IntegerDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntDiff(new int[] { 1, 1, 3, 3 }, 0));
        }

        public static int IntDiff(int[] arr, int n)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    
                    if(arr[j] - arr[i] == n || arr[i] - arr[j] == n)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
