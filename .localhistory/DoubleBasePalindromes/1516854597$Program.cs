using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(Convert.ToString(1000000, 2));
            Console.WriteLine(Ispalindromic(585));
            Console.ReadKey();
        }

        static bool Ispalindromic(int number)
        {
            string baseTen = number + "";
            if (!baseTen.Equals(
                new string(baseTen.ToCharArray().Reverse().ToArray())))
                return false;
            string binary = Convert.ToString(number, 2);
            if (!binary.Equals(
                new string(binary.ToCharArray().Reverse().ToArray())))
                return false;
            return true;
        }
    }
}
