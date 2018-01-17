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
//            while (count <= 10001)
//            {
//                
//            }
            Console.WriteLine(IsPrime(16));
            Console.ReadKey();

        }

        static bool IsPrime(int n)
        {
            for (int j = 1; j <= Math.Sqrt(n); j+=2)
            {
                if(j==1) continue;
                if (n % j == 0) return false;
            }
            return true;
        }
    }
}
