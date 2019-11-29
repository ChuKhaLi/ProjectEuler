using System;
using System.Linq;

namespace LargestPalindromeProduct
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=4
         * A palindromic number reads the same both ways. 
         * The largest palindrome made from the product of two 2-digit numbers is 
         * 9009 = 91 × 99.
         * Find the largest palindrome made from the product of two 3-digit numbers.
         */
        static void Main(string[] args)
        {
            // just bruce force it
            int max = 0;
            for (int i = 999; i >= 100; i--)
                for (int j = 999; j >= i; j--)
                    if ((i * j > max) & IsPalindromic(i * j))
                        max = i * j;
            Console.WriteLine(
                "The largest palindrome made from the product of two 3-digit numbers is: " +
                max);
            Console.ReadKey();
        }

        static bool IsPalindromic(int x)
        {
            return x + "" == string.Concat((x + "").Reverse());
        }
    }
}
