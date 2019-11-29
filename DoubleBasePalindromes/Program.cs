using System;
using System.Linq;

namespace DoubleBasePalindromes
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=36
         * The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
         * Find the sum of all numbers, less than one million, which are palindromic 
         * in base 10 and base 2.
         * (Please note that the palindromic number, in either base, may not include 
         * leading zeros.)
         */
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000000; i++)
            {
                if (IsPalindromic(i))
                    sum += i;
            }
            Console.WriteLine("The sum is: " + sum);
            Console.ReadKey();
        }

        static bool IsPalindromic(int number)
        {
            string baseTen = number + "";

            if (!baseTen.Equals(string.Concat(baseTen.Reverse())))
                return false;

            string binary = Convert.ToString(number, 2);

            if (!binary.Equals(string.Concat(binary.Reverse())))
                return false;

            return true;
        }
    }
}
