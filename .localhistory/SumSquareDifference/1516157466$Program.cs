using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=6
         * The sum of the squares of the first ten natural numbers is,
         * 1^2 + 2^2 + ... + 10^2 = 385
         * The square of the sum of the first ten natural numbers is,
         * (1 + 2 + ... + 10)^2 = 552 = 3025
         * Hence the difference between the sum of the squares of the first ten natural 
         * numbers and the square of the sum is 3025 − 385 = 2640.       
         * Find the difference between the sum of the squares of the first one hundred 
         * natural numbers and the square of the sum.
         */
        static void Main(string[] args)
        {
            /*
             * Mathematic way:
             * The sum of the squares of the first n natural numbers is
             * 1^2 + 2^2 + ... + n^2 = n(n+1)(2n+1)/6
             * The square of the sum of the first ten natural numbers is,
             * (1 + 2 + ... + 10)^2 = 552 = 3025
             */
            int sumSquare = 0, sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumSquare += i * i;
                sum += i;
            }
            int result = sum * sum - sumSquare;
        }
    }
}
