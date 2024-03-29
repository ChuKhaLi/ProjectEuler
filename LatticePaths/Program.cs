﻿using System;

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
            ulong result = Coefficient(20 + 20, 20);
            Console.WriteLine("Result is: " + result);
            Console.ReadKey();
        }

        static ulong Coefficient(int n, int k)
        {
            if (n <= 0 | k <= 0 | k > n) return 0;
            if (k > n - k) { k = n - k; }
            ulong result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= Convert.ToUInt64(n--);
                result /= Convert.ToUInt64(i);
            }
            return result;
        }
    }
}
