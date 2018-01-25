using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            int max = 1;
            int value = 0;
            for (int i = 7; i < 1000; i++)
            {
                int tmp = RecuringCycle(i);
                if (tmp >= max)
                {
                    max = tmp;
                    value = i;
                }
            }
            Console.WriteLine("The value of d is: " + value);
            Console.ReadKey();
        }


        static int RecuringCycle(int prime)
        {
            int digit = 1;
            while (prime % 2 == 0)
                prime /= 2;

            while (prime % 5 == 0)
                prime /= 5;
            if (prime == 1) return 0;
            int remider = 10 % prime;
            while (remider != 1)
            {
                remider = (remider * 10) % prime;
                digit++;
            }
            return digit;
        }
    }
}
