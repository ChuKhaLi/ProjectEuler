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
            int max = 0;
            for(int i = 999; i >= 100; i--) 
                for(int j = 999; j>=100; j--)
                    if ((i * j > max) & Ispalindromic(i * j))
                        max = i * j;
            Console.WriteLine(max);
            Console.ReadKey();
        }

        static bool Ispalindromic(int x)
        {
            string s = x + "";
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string(charArray);
            return s.Equals(reverse);
        }
    }
}
