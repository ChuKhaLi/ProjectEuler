using System;
using System.Collections.Generic;

namespace AmicableNumbers
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=21
         * Let d(n) be defined as the sum of proper divisors of n 
         * (numbers less than n which divide evenly into n).
         * If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair 
         * and each of a and b are called amicable numbers.
         * For example, the proper divisors of 
         * 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; 
         * therefore d(220) = 284. The proper divisors of 
         * 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
         * Evaluate the sum of all the amicable numbers under 10000.
         */
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 2; i < 10000; i++)
            {
                int j = SumOfProperDivisors(i);
                if (j <= i)
                {
                    continue;
                }

                if (SumOfProperDivisors(j) == i)
                {
                    sum = sum + i + j;
                }
            }

            Console.WriteLine("The sum of all the amicable numbers under 10000 is: " + sum);

            Console.ReadKey();
        }

        // Get formula from here https://math.stackexchange.com/questions/22721/is-there-a-formula-to-calculate-the-sum-of-all-proper-divisors-of-a-number
        static int SumOfProperDivisors(int number)
        {
            int c = number, sum = 1;
            int temp = 0;

            var firstTwoPrimes = new List<int> { 2, 3 };

            foreach (var prime in firstTwoPrimes)
            {
                while (number % prime == 0)
                {
                    temp++;
                    number /= prime;
                }

                if (temp > 0)
                {
                    sum *= (int)(Math.Pow(prime, temp + 1) - 1) / (prime - 1);
                }

                temp = 0;
            }

            // all prime numbers bigger than 5 can be written as
            // p = (6*k+1) or p = (6*k-1)
            double sqrtN = Math.Sqrt(number);
            for (int i = 5; i <= sqrtN; i = i + 6)
            {
                var primes = new List<int> { i, i + 2 };

                foreach (var prime in primes)
                {
                    while (number % prime == 0)
                    {
                        temp++;
                        number /= prime;
                    }

                    if (temp > 0)
                    {
                        sum *= (int)(Math.Pow(prime, temp + 1) - 1) / (prime - 1);
                    }

                    temp = 0;
                }
            }

            if (number > 2)
            {
                sum *= (int)(Math.Pow(number, 2) - 1) / (number - 1);
            }

            return sum - c;
        }
    }
}
