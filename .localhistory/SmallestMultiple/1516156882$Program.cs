using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=5
         * 2520 is the smallest number that can be divided by each of the numbers 
         * from 1 to 10 without any remainder.
         * What is the smallest positive number that is evenly divisible by 
         * all of the numbers from 1 to 20?
         */
        static void Main(string[] args)
        {
            /*
             * Call the number is s
             * All the prime numbers is divided by s
             * Factorize others number, take the highest power of each prime number
             * Prime numbers smaller than 20: 2,3,5,7,11,13,17,19
             * The highest power of 2 is 4 (16 = 2^4; 32 = 2^5 > 20)
             * The highest power of 3 is 2 (9 = 3^2; 27 = 3^3 > 20)
             * The highest power of 5 is 1 (5 = 5^1; 25 = 5^2 > 20)
             * The highest power of others prime is 1
             * s = 2^4*3^2*5*7*11*13*17*19
             */
            int s = Math.Pow(2, 4) * Math.Pow(3, 2) * 5 * 7 * 11 * 13 * 17 * 19;
            Console.WriteLine("the smallest positive number that is evenly divisible by "+
                "all of the numbers from 1 to 20 is: " + );
        }
    }
}
