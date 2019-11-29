using System;

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
            double sum = 2 + 3; // 2 and 3 are primes
            for (int i = 5; i < 2000000; i += 2)
                if (IsPrime(i)) sum += i;
            Console.WriteLine(sum);
            Console.ReadKey();
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
