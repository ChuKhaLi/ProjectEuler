using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSpiralDiagonals
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=28
         * Starting with the number 1 and moving to the right in a clockwise 
         * direction a 5 by 5 spiral is formed as follows:
         * 21 22 23 24 25
         * 20  7  8  9 10
         * 19  6  1  2 11
         * 18  5  4  3 12
         * 17 16 15 14 13
         * It can be verified that the sum of the numbers on the diagonals is 101.
         * What is the sum of the numbers on the diagonals in a 1001 by 1001 
         * spiral formed in the same way?
         */
        static void Main(string[] args)
        {
            /*
             * 4 corners of spiral n*n (n = 2*k+1) are:
             *  Upper Right: ur = n*n
             *  Upper Left: ul =  ur - (n-1) = n*n -(n-1)
             *  Lower Left lf = ul - (n-1) = n*n - 2*(n-1)
             *  Lower Right lr = lf - (n-1) = n*n - 3*(n-1)
             *  Sum of 4 corner is: 4*n*n - 6*(n-1)
             */

            int sum = 1;
            for (int i = 3; i < 1001; i += 2)
                sum += i * i - 6 * (i - 1);
        }
    }
}
