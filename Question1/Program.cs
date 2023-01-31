using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Question1
{
    class Program
    {
        static int Main(string[] args)
        {
            Random r = new Random();
            int N = r.Next(0, 100);
            int[] A = new int[30];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(-20, 20);
            }

            List<int> filteredList = A.Where(a => a >= 0).Distinct().OrderBy(a=>a).ToList();

            foreach (var item in filteredList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            int minVal = 1;

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
