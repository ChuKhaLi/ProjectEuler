using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        static bool Ispalindromic(int x)
        {
            string s = x + "";
            return s.Equals(s.Reverse()));
            return false;
        }
    }
}
