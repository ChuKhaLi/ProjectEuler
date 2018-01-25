using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitFifthPowers
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=30
         * Surprisingly there are only three numbers that can be written as 
         * the sum of fourth powers of their digits:
         * 1634 = 1^4 + 6^4 + 3^4 + 4^4
         * 8208 = 8^4 + 2^4 + 0^4 + 8^4
         * 9474 = 9^4 + 4^4 + 7^4 + 4^4
         * As 1 = 1^4 is not a sum it is not included.
         * The sum of these numbers is 1634 + 8208 + 9474 = 19316.
         * Find the sum of all the numbers that can be written as 
         * the sum of fifth powers of their digits.
         */
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Stop();
            int sum = 0;
            //int upperBound = UpperBound();
            for (int i = 2; i <= 354294; i++)
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
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("The sum is: " + sum);
            Console.ReadKey();
        }

        /*
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
