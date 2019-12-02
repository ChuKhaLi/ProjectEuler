using System;
using System.Collections.Generic;
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
            var solutions = Enumerable.Range(1, 1000).Select(FindSolution).ToArray();

            var maxSolution = solutions.Max();
            var perimeter = Array.IndexOf(solutions, maxSolution);

            Console.WriteLine($"With perimeter = {perimeter} we get max {maxSolution} solutions");

            //var tests = new List<int> {12, 120};
            //foreach (var test in tests)
            //{
            //    Console.WriteLine(FindSolution(test));
            //}

            Console.ReadKey();
        }

        static int FindSolution(int perimeter)
        {
            var count = 0;

            for (int i = perimeter; i > 0; i--)
            {
                for (int j = perimeter - i; j > 0; j--)
                {
                    for (int k = perimeter - i - j; k > 0; k--)
                    {
                        if (i + j + k == perimeter && 
                            (i * i == j * j + k * k || j * j == i * i + k * k || k * k == i * i + j * j))
                        {
                            Console.WriteLine(perimeter + ": " + i + " " + j + " " + k);
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine($"Found {count} solutions for {perimeter}");

            return count;
        }
    }
}
