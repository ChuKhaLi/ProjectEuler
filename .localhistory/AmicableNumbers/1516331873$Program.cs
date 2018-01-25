using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AmicableNumbers
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=21
         * Let d(n) be defined as the sum of proper divisors of n 
         * (numbers less than n which divide evenly into n).
         * If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair 
         * and each of a and b are called amicable numbers.
         * For example, the proper divisors of 
         * 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; 
         * therefore d(220) = 284. The proper divisors of 
         * 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
         * Evaluate the sum of all the amicable numbers under 10000.
         */
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 2; i < 10000; i++)
            {

                b = SumOfProperDivisors(a)
                if b > a then
                if SumOfProperDivisors(b) = a then
                    sum = sum + a + b
            }
            Console.WriteLine(SumOfDivisor(220));
            Console.ReadKey();
        }

        static double SumOfDivisor(int number)
        {

            int c = number, sum = 1;
            int temp = 0;
            while (number % 2 == 0)
            {
                temp++;
                number = number / 2;
            }
            if (temp > 0)
                sum *= (int)Math.Pow(2, temp + 1) - 1;

            temp = 0;
            while (number % 3 == 0)
            {
                temp++;
                number = number / 3;
            }
            if (temp > 0)
                sum *= (int)(Math.Pow(3, temp + 1) - 1) / 2;
            // all prime numbers bigger than 5 can be written as
            // p = (6*k+1) or p = (6*k-1)
            double sqrt_n = Math.Sqrt(number);
            for (int i = 5; i <= sqrt_n; i = i + 6)
            {
                temp = 0;
                while (number % i == 0)
                {
                    temp++;
                    number = number / i;
                }
                if (temp > 0)
                    sum *= (int)(Math.Pow(i, temp + 1) - 1) / (i - 1);

                temp = 0;
                while (number % (i + 2) == 0)
                {
                    temp++;
                    number = number / (i + 2);
                }
                if (temp > 0)
                    sum *= (int)(Math.Pow((i + 2), temp + 1) - 1) / (i + 1);
            }

            if (number > 2)
                sum *= (int)(Math.Pow(number, 2) - 1) / (number - 1);

            return sum - c;
        }
    }
}
