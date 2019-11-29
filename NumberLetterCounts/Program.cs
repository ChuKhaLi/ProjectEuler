using System;

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
        private static readonly int[] SmallerThanTwenty = { 0, 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8, 7, 7, 9, 8, 8, 6 };
        private static readonly int[] Tens = { 0, 3, 6, 6, 5, 5, 5, 7, 6, 6 };
        private static readonly int Hundreds = 7;
        private static readonly int BiggerThanHundreds = 10;
        private static readonly int OneThousand = 11;

        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
                sum += ReadNumber(i);
            Console.WriteLine("The number of letters needed is: " + sum);
            Console.ReadKey();

        }

        static int ReadNumber(int number)
        {
            if (number < 100)
                return ReadTwoDigit(number);
            if (number == 1000)
                return OneThousand;
            return ReadThreeDigit(number);
        }

        static int ReadTwoDigit(int number)
        {
            int sum = 0;
            if (number <= 20)
                sum += SmallerThanTwenty[number];
            else
            {
                sum += SmallerThanTwenty[number % 10];
                sum += Tens[number / 10];
            }
            return sum;
        }

        static int ReadThreeDigit(int number)
        {
            int sum = 0;
            sum += SmallerThanTwenty[number / 100];
            if (number % 100 == 0)
                return sum + Hundreds;
            sum += BiggerThanHundreds;
            sum += ReadTwoDigit(number % 100);
            return sum;
        }
    }
}
