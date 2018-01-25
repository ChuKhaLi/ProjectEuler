using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int sum = 0;
            int upperBound = UpperBound();
            for (int i = 2; i <= upperBound; i++)
            {
                int tmpSum = i, j = i;
                while (j > 0)
                {
                    tmpSum -= (int)Math.Pow(j % 10, 5);
                    j /= 10;
                }
                if (tmpSum == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum is: " + sum);
            Console.ReadKey();
        }

        static List<int> InitFactorial()
        {
            List<int> factors = new List<int>();

            // add 0! to 9! to list
            factors.AddRange(
                new int[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 });
            return factors;
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
