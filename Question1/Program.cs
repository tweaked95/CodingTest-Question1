using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int N = r.Next(0, 100);
            int[] A = new int[N];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(-1000, 1000);
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }

            Console.WriteLine("\n");
            Array.Sort(A);

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.WriteLine("\n");

            List<int> filtered = A.Where(a => a >= 0).ToList();

            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }
    }
}
