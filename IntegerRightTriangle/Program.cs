using System;
using System.Linq;

namespace IntegerRightTriangle
{
    class Program
    {
        /*
         * If p is the perimeter of a right angle triangle with integral length sides, {a,b,c},
         * there are exactly three solutions for p = 120.
         * {20,48,52}, {24,45,51}, {30,40,50}
         * For which value of p ≤ 1000, is the number of solutions maximised?
         */
        static void Main(string[] args)
        {
            var perimeters = Enumerable.Range(0, 1000).ToArray();

            for (int i = 999; i > 0; i--)
            {
                for (int j = 1000 - i; j > 0; j--)
                {
                    for (int k = 1000 - i - j; k > 0; k--)
                    {
                        if (i * i == j * j + k * k && i + j + k <= 1000)
                        {
                            perimeters[i + j + k - 1]++;
                            Console.WriteLine(i + " " + j + " " + k + " " + perimeters[i + j + k - 1]);
                        }
                    }
                }
            }

            var maxSolution = perimeters.Max();
            var perimeter = Array.IndexOf(perimeters, maxSolution);

            Console.WriteLine($"With perimeter = {perimeter} we get max {maxSolution} solutions");
            Console.ReadKey();
        }
    }
}
