using System;

namespace SortTheOdd
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (int i in SortArray(new int[] { 3, 7, 2, 8, 5, 4 }))
            {
                Console.WriteLine(i);
            }

        }

        public static int[] SortArray(int[] array)
        {
            int k=0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    k++;
                }
            }

            int[] oddArray = new int[k];
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddArray[m] = i;
                    m++;
                }
            }

            int s = k;
            int temp = 0;
            do 
            {
                for (int j = 0; j < k-1; j++)
                {
                    if (array[oddArray[j]] > array[oddArray[j+1]])
                    {
                        temp = array[oddArray[j]];
                        array[oddArray[j]] = array[oddArray[j + 1]];
                        array[oddArray[j + 1]] = temp;
                    }
                }
                s--;
            }
            while (s > 1);

            return array;
        }
    }
}
