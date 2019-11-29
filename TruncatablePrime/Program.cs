using System;
using System.Collections.Generic;

namespace TruncatablePrime
{
    class Program
    {
        /*
         *The number 3797 has an interesting property.Being prime itself, it is possible to continuously remove
         * digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7.
         * Similarly we can work from right to left: 3797, 379, 37, and 3.
         * Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
         * NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.
         */
        static void Main(string[] args)
        {
            var numbers = new List<int> { 3797 };

            foreach (var number in numbers)
            {
                Console.WriteLine(IsTruncablePrime(number));
            }

            int sum = 0;
            int count = 0;
            int i = 11;
            while (true)
            {
                if (IsTruncablePrime(i))
                {
                    sum += i;
                    count++;
                }

                if (count == 11)
                {
                    break;
                }

                if (IsTruncablePrime(i + 2))
                {
                    sum += i + 2;
                    count++;
                }

                if (count == 11)
                {
                    break;
                }

                i += 6;
            }

            Console.WriteLine($"the sum of the only eleven truncatable primes is {sum}");

            Console.ReadKey();
        }

        static bool IsTruncablePrime(long number)
        {
            var str = number + "";
            var len = str.Length;

            if (!IsPrime(number))
            {
                return false;
            }

            for (var i = 1; i < len; i++)
            {
                var truncateLeft = long.Parse(str.Substring(i, len - i));
                var truncateRight = long.Parse(str.Substring(0, len - i));

                if (!IsPrime(truncateLeft) | !IsPrime(truncateRight))
                {
                    return false;
                }
            }

            //Console.WriteLine($"{number} is truncatable prime");

            return true;
        }

        static bool IsPrime(long n)
        {
            if (n == 2 || n == 3)
            {
                return true;
            }

            if (n % 2 == 0 || n % 3 == 0 || n < 2)
            {
                return false;
            }

            double sqrtN = Math.Sqrt(n);
            for (var i = 5; i <= sqrtN; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
