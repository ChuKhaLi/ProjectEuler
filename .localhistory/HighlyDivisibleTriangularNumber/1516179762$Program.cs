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
            int divisors = 0, i = 1;
            do
            {
                int triangle = TriangleNumbers(i);
                divisors = NumberOfDivisors(triangle);
                if (divisors > 500) break;
                i++;
            } while (true);
            int triangle1 = TriangleNumbers(i);
            Console.WriteLine("The first triangle number to have over "+
                "five hundred divisors: " + triangle1);
            Console.ReadLine();
        }

        static int TriangleNumbers(int number)
        {
            return number * (number + 1) / 2;
        }
        static int NumberOfDivisors(int number)
        {
            int count = 1;
            List<int> powerOfPrimeFactor = new List<int>();
            int temp = 0;
            while (number % 2 == 0)
            {
                temp++;
                number = number / 2;
            }
            powerOfPrimeFactor.Add(temp);

            temp = 0;
            while (number % 3 == 0)
            {
                temp++;
                number = number / 3;
            }
            powerOfPrimeFactor.Add(temp);
            double sqrt_n = Math.Sqrt(number);
            for (int i = 5; i <= sqrt_n; i = i + 6)
            {
                temp = 0;
                while (number % i == 0)
                {
                    temp++;
                    number = number / i;
                }
                powerOfPrimeFactor.Add(temp);

                temp = 0;
                while (number % (i + 2) == 0)
                {
                    temp++;
                    number = number / (i + 2);
                }
                powerOfPrimeFactor.Add(temp);
            }
            if (number > 2)
                powerOfPrimeFactor.Add(1);
            foreach (var power in powerOfPrimeFactor)
                count *= (power + 1);
            return count;
        }
    }
}
