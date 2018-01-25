using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1000DigitFibonacciNumber
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=25
         * The Fibonacci sequence is defined by the recurrence relation:
         * Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
         * Hence the first 12 terms will be:
         * F1 = 1
         * F2 = 1
         * F3 = 2
         * F4 = 3
         * F5 = 5
         * F6 = 8
         * F7 = 13
         * F8 = 21
         * F9 = 34
         * F10 = 55
         * F11 = 89
         * F12 = 144
         * The 12th term, F12, is the first term to contain three digits.
         * What is the index of the first term in the Fibonacci sequence 
         * to contain 1000 digits?
         */

        static void Main(string[] args)
        {
           
            BigInteger f0 = BigInteger.Zero;
            BigInteger f1 = BigInteger.One;
            int count = f1.ToString().Length;
            while (count <= 3)
            {
                f1 = f0 + f1;
                f0 = f1 - f0;
                count = f1.ToString().Length;
            }


        }
    }
}
