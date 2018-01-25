using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticPrimes
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=27
         * Euler discovered the remarkable quadratic formula:
         * n^2+n+41
         * It turns out that the formula will produce 40 primes for 
         * the consecutive integer values 0≤n≤39. However, 
         * when n=40,40^2+40+41=40(40+1)+41 is divisible by 41, 
         * and certainly when n=41,41^2+41+41 is clearly divisible by 41.
         * The incredible formula n^2−79n+1601 was discovered, 
         * which produces 80 primes for the consecutive values 0≤n≤79. 
         * The product of the coefficients, −79 and 1601, is −126479.
         * Considering quadratics of the form:
         * n^2+an+b, where |a|<1000 and |b|≤1000
         * where |n| is the modulus/absolute value of nn
         * e.g. |11|=11 and |−4|=4
         * Find the product of the coefficients, a and b, 
         * for the quadratic expression that produces the maximum number of primes 
         * for consecutive values of nn, starting with n=0.
         */
        static void Main(string[] args)
        {
            int nMax = 0, aMax =0, bMax=0;
            for(int a = -999;a<1000;a++)
            for (int b = -1000; b <= 1000; b++)
            {
                int n = 0;
                while()
            }
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
