using System;
using System.Collections.Generic;
using System.Linq;

namespace Question1
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] A = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                A[i] = Convert.ToInt32(args[i]);
            }
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

            Console.WriteLine(minVal);
            return minVal;
        }
    }
}
