using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationOfPrimes
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=10
         * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
         * Find the sum of all the primes below two million.
         */
        static void Main(string[] args)
        {
        }

        static bool IsPrime(int n)
        {
            if (n % 2 == 0 || n % 3 == 0 || n < 2) return false;
            if (n < 4) return true;
            int i = -1;
            double sqrt_n = Math.Sqrt(n);
            do
            {
                i += 6;
                if (n % i == 0 || n % (i + 2) == 0) break;
            } while (i <= sqrt_n);
            return (i > sqrt_n);
        }
    }
}
