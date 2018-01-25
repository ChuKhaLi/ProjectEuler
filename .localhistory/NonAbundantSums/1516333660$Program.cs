﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonAbundantSums
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=23
         * A perfect number is a number for which the sum of its proper divisors is 
         * exactly equal to the number. For example, the sum of the proper divisors of 
         * 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
         * A number n is called deficient if the sum of its proper divisors is 
         * less than n and it is called abundant if this sum exceeds n.         * 
         * As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest 
         * number that can be written as the sum of two abundant numbers is 24. 
         * By mathematical analysis, it can be shown that all integers greater than 
         * 28123 can be written as the sum of two abundant numbers. However, 
         * this upper limit cannot be reduced any further by analysis even though 
         * it is known that the greatest number that cannot be expressed as the sum of
         * two abundant numbers is less than this limit.
         * Find the sum of all the positive integers which cannot be written as 
         * the sum of two abundant numbers.
         */
        static void Main(string[] args)
        {
        }

        static int ISAbundantNumbers(int number)
        {

            int c = number, sum = 1;
            int temp = 0;
            while (number % 2 == 0)
            {
                temp++;
                number = number / 2;
            }
            if (temp > 0)
                sum *= (int)Math.Pow(2, temp + 1) - 1;

            temp = 0;
            while (number % 3 == 0)
            {
                temp++;
                number = number / 3;
            }
            if (temp > 0)
                sum *= (int)(Math.Pow(3, temp + 1) - 1) / 2;
            // all prime numbers bigger than 5 can be written as
            // p = (6*k+1) or p = (6*k-1)
            double sqrt_n = Math.Sqrt(number);
            for (int i = 5; i <= sqrt_n; i = i + 6)
            {
                temp = 0;
                while (number % i == 0)
                {
                    temp++;
                    number = number / i;
                }
                if (temp > 0)
                    sum *= (int)(Math.Pow(i, temp + 1) - 1) / (i - 1);

                temp = 0;
                while (number % (i + 2) == 0)
                {
                    temp++;
                    number = number / (i + 2);
                }
                if (temp > 0)
                    sum *= (int)(Math.Pow((i + 2), temp + 1) - 1) / (i + 1);
            }

            if (number > 2)
                sum *= (int)(Math.Pow(number, 2) - 1) / (number - 1);

            return sum - c;
        }
    }
}
