using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestCollatzSequence
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=14
         * The following iterative sequence is defined for the set of positive integers:
         * n → n/2 (n is even)
         * n → 3n + 1 (n is odd)
         * Using the rule above and starting with 13, we generate 
         * the following sequence:
         * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
         * It can be seen that this sequence (starting at 13 and finishing at 1) 
         * contains 10 terms. Although it has not been proved yet (Collatz Problem), 
         * it is thought that all starting numbers finish at 1.
         * Which starting number, under one million, produces the longest chain?
         * NOTE: Once the chain starts the terms are allowed to go above one million.
         */

        static void Main(string[] args)
        {
            long longestChain = 0, number = 0;
            foreach (var num in Enumerable.Range(1, 999999))
            {
                var chain = CountChain(num);
                if (chain > longestChain)
                {
                    longestChain = chain;
                    number = num;
                }
            }

            Console.WriteLine($"The number, under one million, produces the longest chain is {number} with {longestChain} terms");
            Console.ReadKey();
        }

        private static Dictionary<long, long> _chainLength = new Dictionary<long, long> { [1] = 1 };
        static long CountChain(long n)
        {
            if (_chainLength.ContainsKey(n))
            {
                return _chainLength[n];
            }

            if (n % 2 == 0)
            {
                _chainLength[n] = 1 + CountChain(n / 2);
            }
            else
            {
                _chainLength[n] = 2 + CountChain((3 * n + 1) / 2);
            }

            return _chainLength[n];
        }
    }
}
