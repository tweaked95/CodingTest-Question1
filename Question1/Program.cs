using System;
using System.Collections.Generic;
using System.Linq;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { -1, 2, 5, -6, 10, 1, 3, 2, -6, -4 };

            Console.WriteLine(Solution(array));
        }

        public static int Solution(int[] A)
        {

            List<int> filteredList = A.Where(a => a >= 0).OrderBy(a => a).ToList();

            int minVal = 1;

            if (filteredList.Count == 0)
            {
                return minVal;
            }

            foreach (int item in filteredList)
            {
                if (minVal < item)
                {
                    break;
                }
                minVal = item + 1;
            }

            return minVal;
        }
    }
}
