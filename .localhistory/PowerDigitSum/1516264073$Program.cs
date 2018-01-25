using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PowerDigitSum
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=16
         * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
         * What is the sum of the digits of the number 2^1000?
         */
        static void Main(string[] args)
        {
        }

        static int SumDigit()
        {
            int sum = 0;
            BigInteger bigInt = BigInteger.Pow(BigInteger.Parse("2"),1000);
            foreach (char c in bigInt.ToString())
                sum += c - '0';
            return 0;
        }

        
    }
}
