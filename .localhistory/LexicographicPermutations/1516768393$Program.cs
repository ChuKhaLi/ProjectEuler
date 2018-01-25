﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicographicPermutations
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=24
         * A permutation is an ordered arrangement of objects. For example, 
         * 3124 is one possible permutation of the digits 1, 2, 3 and 4. 
         * If all of the permutations are listed numerically or alphabetically, 
         * we call it lexicographic order. 
         * The lexicographic permutations of 0, 1 and 2 are:
         * 012   021   102   120   201   210
         * What is the millionth lexicographic permutation of 
         * the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
         */
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            string s = "012";
            List<string> permuttion = GetPermuttion(s);
            timer.Stop();
//            Console.WriteLine("the millionth lexicographic permutation of" +
//                "the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9 is: " + permuttion[999999]);
            Console.WriteLine("Took {0}ms", timer.ElapsedMilliseconds);
            Console.ReadKey();

        }

        static List<string> GetPermuttion(string s)
        {
            List<string> permuttion = new List<string>();
            int size = s.Length;
            bool isFinished = false;
            while (!isFinished & permuttion.Count < 1000)
            {
                permuttion.Add(s);
                // print this permutation

                // Find the rightmost character which is smaller than its next
                // character. Let us call it 'first char'
                int i = 0;
                for (i = size - 2; i >= 0; --i)
                    if (s[i] < s[i + 1])
                        break;

                // If there is no such chracter, all are sorted in decreasing order,
                // means we just printed the last permutation and we are done.
                if (i == -1)
                    isFinished = true;
                else
                {
                    // Find the ceil of 'first char' in right of first character.
                    // Ceil of a character is the smallest character greater than it
                    int ceilIndex = findCeil(s, s[i], i + 1, size - 1);

                    // Swap first and second characters
                    s = Swap(s, s[i], s[ceilIndex]);

                    // reverse the string on right of 'first char'
                    s = Reverse(s.Substring(i + 1, size - i - 1));
                }
            }
            return permuttion;

        }

        static string Swap(string s, int i, int j)
        {
            char[] array = s.ToCharArray();
            char tmp = array[i]; array[i] = array[j]; array[j] = tmp;
            return new string(array);
        }

        static string Reverse(string s)
        {
            return new string(s.ToCharArray().Reverse().ToArray());
        }

        static int findCeil(string str, char first, int l, int h)
        {
            // initialize index of ceiling element
            int ceilIndex = l;

            // Now iterate through rest of the elements and find
            // the smallest character greater than 'first'
            for (int i = l + 1; i <= h; i++)
                if (str[i] > first && str[i] < str[ceilIndex])
                    ceilIndex = i;

            return ceilIndex;
        }
    }
}