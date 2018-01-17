﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighlyDivisibleTriangularNumber
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=12
         * The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
         * 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
         * Let us list the factors of the first seven triangle numbers:
         * 1: 1
         * 3: 1,3
         * 6: 1,2,3,6
         * 10: 1,2,5,10
         * 15: 1,3,5,15
         * 21: 1,3,7,21
         * 28: 1,2,4,7,14,28
         * We can see that 28 is the first triangle number to have over five divisors.
         * What is the value of the first triangle number to have over 
         * five hundred divisors?
         */
        static void Main(string[] args)
        {
            int divisors = 0, i=1;
            Console.WriteLine(NumberOfDivisors(15));
            do
            {
                divisors = NumberOfDivisors(TriangleNumbers(i));
                Console.WriteLine(i + " divisors: " + divisors);
                i++;
            } while (divisors <= 500);
            Console.WriteLine(i + " divisors: " + NumberOfDivisors(TriangleNumbers(i)));
            Console.ReadLine();
        }

        static int TriangleNumbers(int number)
        {
            return number * (number + 1) / 2;
        }
        static int NumberOfDivisors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
                if (number % i == 0) count++;
            return count;
        }
    }
}
