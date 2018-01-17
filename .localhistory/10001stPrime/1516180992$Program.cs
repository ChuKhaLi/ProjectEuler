using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001stPrime
{
    class Program
    {
        /*
         * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, 
         * we can see that the 6th prime is 13.
         * What is the 10 001st prime number?
         */
        static void Main(string[] args)
        {
            //Just check it on https://primes.utm.edu/nthprime/index.php#nth
            int count = 3, i = 5;
            while (count <= 10001)
            {
                if (IsPrime(i))
                {
                    if (count == 10001)
                        break;
                    count++;
                }
                i += 2;
            }
            Console.WriteLine("the 10001st prime number is: " + i);
            Console.ReadKey();

        }

        static bool IsPrime(int n)
        {
            if (n % 2 == 0 || n % 3 == 0 || n < 2) return false;
            if (n < 9) return true;
            int i;
            double sqrt_n = Math.Sqrt(n) + 1;
            for (i = 5; i <= sqrt_n; i = i + 6)
            {
                if (n % i == 0 || n % (i + 2) == 0) return false;
                i += 6;
            }
            return true;
        }
    }
}
