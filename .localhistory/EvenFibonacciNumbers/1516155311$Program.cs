﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    class Program
    {
        /*
         * Each new term in the Fibonacci sequence is generated by adding 
         * the previous two terms. By starting with 1 and 2, the first 10 terms will be:
         * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
         * By considering the terms in the Fibonacci sequence whose values 
         * do not exceed four million, find the sum of the even-valued terms.
         */
        static void Main(string[] args)
        {
            int f1 = 1, f2 = 2;
            int sum = 0;
            while (f2 <= 4000000)
            {
                if (f2 % 2 == 0) sum += f2;
                f2 = f1 + f2;
                f1 = f2 - f1;
            }
            Console.WriteLine(
                "The sum of the even-valued terms is: " + sum);
            Console.ReadKey();
        }
    }
}
