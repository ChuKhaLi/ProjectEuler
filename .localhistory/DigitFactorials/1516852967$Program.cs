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
        }

        /*
         * Just like Problem 30
         * Find the upper bound
         * If number n has m digits,
         * so n <= m*9^5
         * 10^m <= m*9^5
         */
        static int UpperBound()
        {
            int digit = 1;

            while ((Math.Pow(10, digit) - 59049 * digit) <= 0)
            {
                digit++;
            }

            return 59049 * digit;
        }
    }
}
