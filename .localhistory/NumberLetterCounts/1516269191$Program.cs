using System;
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
        private static readonly int[] SMALLER_THAN_TWENTY =
            {0,3,3,5,4,4,3,5,5,4,3,6,6,8,8,7,7,9,8,8,6};

        private static readonly int[] TENS =
            { 0, 3, 6, 6, 5, 5, 5, 7, 6, 6};

        private static readonly int HUNDREDS = 7;
        private static readonly int BIGGER_THAN_HUNDREDS = 10;
        private static readonly int ONE_THOUSAND = 11;
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine(ReadThreeDigit(342));
            Console.ReadKey();

        }

        static int ReadTwoDigit(int number)
        {
            int sum = 0;
            if (number <= 20)
                sum += SMALLER_THAN_TWENTY[number];
            else
            {
                sum += SMALLER_THAN_TWENTY[number % 10];
                sum += TENS[number / 10];
            }

            return sum;
        }

        static int ReadThreeDigit(int number)
        {
            int sum = 0;
            sum += SMALLER_THAN_TWENTY[number / 100];
            if (number % 100 == 0)
                return sum + HUNDREDS;
            else
            {
                sum += BIGGER_THAN_HUNDREDS;
                sum += ReadTwoDigit(number % 100);
            }
            return sum;
        }


    }
}
