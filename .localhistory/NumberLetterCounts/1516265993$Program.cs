﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLetterCounts
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=17
         * If the numbers 1 to 5 are written out in words: one, two, three, four, five,
         * then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
         * If all the numbers from 1 to 1000 (one thousand) inclusive were written out 
         * in words, how many letters would be used?
         * NOTE: Do not count spaces or hyphens. For example, 
         * 342 (three hundred and forty-two) contains 23 letters and 
         * 115 (one hundred and fifteen) contains 20 letters. The use of "and" 
         * when writing out numbers is in compliance with British usage.
         */
        private readonly int[] SMALLER_THAN_TWENTY =
            {0,3,3,5,4,4,3,5,5,4,3,6,6,8,8,7,7,9,8,8,6};

        private readonly int[] TENS = 
            { 0, 3, 6, 6, 6, 5, 5, 7, 6, 6};

        private readonly int HUNDREDS = 8;
        private readonly int BIGGER_THAN_HUNDREDS = 11;
        private readonly int ONE_THOUSAND = 11;
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                
            }
        }
    }
}