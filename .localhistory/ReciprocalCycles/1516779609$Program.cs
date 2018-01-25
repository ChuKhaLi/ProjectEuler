using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciprocalCycles
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=26
         * A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
         * 1/2	= 	0.5
         * 1/3	= 	0.(3)
         * 1/4	= 	0.25
         * 1/5	= 	0.2
         * 1/6	= 	0.1(6)
         * 1/7	= 	0.(142857)
         * 1/8	= 	0.125
         * 1/9	= 	0.(1)
         * 1/10	= 	0.1
         * Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle. It can be seen that 1/7 has a 6-digit recurring cycle.
         * Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
         */
        static void Main(string[] args)
        {
            Dictionary<int, int> dic = InitPrimeRecuringCycle();
            Console.ReadKey();
        }

        static int RecuringCycl(int number)
        {
            while (number % 2 == 0)
                number /= 2;

            while (number % 5 == 0)
                number /= 5;
        }

        static Dictionary<int, int> InitPrimeRecuringCycle()
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            List<int> primes = InitPrime();
            dic.Add(2, 0);
            dic.Add(3, 1);
            dic.Add(5, 0);
            foreach (var prime in primes)
            {
                dic.Add(prime, PrimeRecuringCycle(prime));
            }
            return dic;
        }

        static int PrimeRecuringCycle(int prime)
        {
            int remider = 10 % prime;
            int digit = 1;
            while (remider != 1)
            {
                remider = (remider * 10) % prime;
                digit++;
            }

            return digit;
        }

        static List<int> InitPrime()
        {
            List<int> primes = new List<int>();
            for (int i = 7; i < 1000; i += 2)
            {
                if (IsPrime(i))
                    primes.Add(i);
            }
            return primes;
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
            }
            return true;
        }
    }
}
