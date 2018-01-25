using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDigitSum
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=20
         * n! means n × (n − 1) × ... × 3 × 2 × 1
         * For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
         * and the sum of the digits in the number 
         * 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
         * Find the sum of the digits in the number 100!
         */
        static void Main(string[] args)
        {
            BigInteger product = BigInteger.One;
            int sum = 0;

            for (int i = 1; i <= 100; i++)
            {
                product = BigInteger.Multiply(product, BigInteger.Parse(i + ""));
            }

            foreach (char c in product.ToString())
            {
                sum += c - '0';
            }
            Console.WriteLine("The sum digits of 100! is: " + sum);
            Console.ReadKey();


        }
    }
}
