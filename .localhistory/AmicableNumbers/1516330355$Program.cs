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
            Console.WriteLine(SumOfDivisor(16));
            Console.ReadKey();
        }

        static int NumberOfDivisors(int number)
        {
            int count = 1;
            List<int> powerOfPrimeFactor = new List<int>();
            int temp = 0;
            while (number % 2 == 0)
            {
                temp++;
                number = number / 2;
            }
            powerOfPrimeFactor.Add(temp);

            temp = 0;
            while (number % 3 == 0)
            {
                temp++;
                number = number / 3;
            }
            powerOfPrimeFactor.Add(temp);

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
                powerOfPrimeFactor.Add(temp);

                temp = 0;
                while (number % (i + 2) == 0)
                {
                    temp++;
                    number = number / (i + 2);
                }
                powerOfPrimeFactor.Add(temp);
            }

            if (number > 2)
                powerOfPrimeFactor.Add(1);

            foreach (var power in powerOfPrimeFactor)
                count *= (power + 1);
            return count;
        }

        static double SumOfDivisor(int number)
        {
            double sum = 0-number;
            int temp = 0;
            while (number % 2 == 0)
            {
                temp++;
                number = number / 2;
            }
            if (temp > 0)
                sum += (Math.Pow(2, (temp + 1)) - 1);

            temp = 0;
            while (number % 3 == 0)
            {
                temp++;
                number = number / 3;
            }
            if (temp > 0)
                sum += (Math.Pow(3, (temp + 1)) - 1) / 2;

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
                    sum += (Math.Pow(i, (temp + 1)) - 1) / (i - 1);

                temp = 0;
                while (number % (i + 2) == 0)
                {
                    temp++;
                    number = number / (i + 2);
                }
                if (temp > 0)
                    sum += (Math.Pow((i + 2), (temp + 1)) - 1) / ((i + 2) - 1);
            }
            return sum;
        }
    }
}
