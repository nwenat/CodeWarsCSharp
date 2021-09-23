using System;

namespace WhichSectionDidYouScrollTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSectionId(1699, new int[] { 300, 200, 400, 600, 100 }));
        }

        public static int GetSectionId(int n, int[] a)
        {
            int sectionNumber = 0;
            int distance = -1;
            for (int i = 0; i < a.Length; i++)
            {
                distance += a[i];
                if (n <= distance)
                {
                    return sectionNumber;
                }
                sectionNumber++;
            }
            return -1;
        }
    }
}
