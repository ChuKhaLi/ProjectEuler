using System;
using System.Collections.Generic;

namespace LargestPrimeFactor
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=3
         * The prime factors of 13195 are 5, 7, 13 and 29.
         * What is the largest prime factor of the number 600851475143 ?
         */
        static void Main(string[] args)
        {
            //Just check it on https://www.calculatorsoup.com/calculators/math/prime-factors.php
            long number = 600851475143;
            long largestPrimeFactor = LargestPrimeFactor(number);

            Console.WriteLine($"largest prime factor of {number} is {largestPrimeFactor}");

            Console.ReadKey();
        }

        public static long LargestPrimeFactor(long number)
        {
            int lastFactor = 1;

            var firstTwoPrimes = new List<int> { 2, 3 };

            foreach (var prime in firstTwoPrimes)
            {
                if (number % prime == 0)
                {
                    lastFactor = prime;

                    while (number % prime == 0)
                    {
                        number /= prime;
                    }
                }
            }

            // all prime numbers bigger than 5 can be written as
            // p = (6*k+1) or p = (6*k-1)
            double sqrtN = Math.Sqrt(number);
            for (int i = 5; i <= sqrtN; i += 6)
            {
                var primes = new List<int> { i, i + 2 };

                foreach (var prime in primes)
                {
                    if (number % prime == 0)
                    {
                        lastFactor = prime;

                        while (number % prime == 0)
                        {
                            number /= prime;
                        }
                    }
                }
            }

            return number == 1 ? lastFactor : number;
        }
    }
}
