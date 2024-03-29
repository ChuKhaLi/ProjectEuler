﻿using System;

namespace SpecialPythagoreanTriplet
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=9
         * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
         * a2 + b2 = c2
         * For example, 32 + 42 = 9 + 16 = 25 = 52.
         * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
         * Find the product abc.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("the product a*b*c is: " + FindTriagle());
            Console.ReadKey();

        }

        static int FindTriagle()
        {
            for (int i = 999; i > 0; i--)
                for (int j = 1000 - i; j > 0; j--)
                    for (int k = 1000 - i - j; k > 0; k--)
                        if ((i * i == j * j + k * k) & (i + j + k == 1000))
                        {
                            return (i * j * k);
                        }

            return 0;
        }
    }
}
