using System;

namespace DigitFactorials
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=34
         * 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
         * Find the sum of all numbers which are equal to the sum of 
         * the factorial of their digits.
         * Note: as 1! = 1 and 2! = 2 are not sums they are not included.
         */
        static void Main(string[] args)
        {
            int[] factors = new int[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
            int sum = 0;

            int upperBound = UpperBound(); 
            //upperBound = UpperBound(); -> precalculate this
            for (int i = 10; i <= 2540160; i++)
            {
                int tmpSum = i, j = i;
                while (j > 0)
                {
                    tmpSum -= factors[j % 10];
                    j /= 10;
                }
                sum += tmpSum == 0 ? i : 0;
            }
            Console.WriteLine("The sum is: " + sum);
            Console.ReadKey();
        }

        /*
         * Just like Problem 30
         * Find the upper bound
         * If number n has m digits,
         * so n <= m*9!
         * 10^m <= m*9!
         */
        static int UpperBound()
        {
            int digit = 1;
            while ((Math.Pow(10, digit) - 362880 * digit) <= 0)
            {
                digit++;
            }
            return 362880 * digit;
        }
    }
}
