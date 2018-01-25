﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatticePaths
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=15
         * Starting in the top left corner of a 2×2 grid, and only being able to 
         * move to the right and down, there are exactly 6 routes 
         * to the bottom right corner.
         * How many such routes are there through a 20×20 grid?
         */
        static void Main(string[] args)
        {
            string replie = "y";
            int n = 1, k = 1;
            do
            {
                Console.WriteLine("Enter n: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter k: ");
                k = Convert.ToInt32(Console.ReadLine());
                long result = Coefficient(n, k);
                Console.WriteLine(n + " choose " + k + " is: " + result);
                Console.WriteLine("Do you want to continue? y/n");
                replie = Console.ReadLine();
            } while (replie.Equals("y", StringComparison.CurrentCultureIgnoreCase));
            Console.ReadKey();
        }

        static long Coefficient(int n, int k)
        {
            if (n <= 0 | k <= 0 | k > n) return 0;
            long kFac = 1, nFac = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i <= k) kFac *= i;
                if (i > (n - k)) nFac *= i;
            }
            return nFac / kFac;
        }
    }
}