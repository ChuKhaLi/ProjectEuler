using System;
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
            string s = "0123456789";
            List<string> permuttion = GetPermuttion(s, 0, s.Length - 1);
            timer.Stop();
            Console.WriteLine("the millionth lexicographic permutation of"+ 
                "the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9 is: " + permuttion[999999]);
            Console.WriteLine("Took {0}ms", timer.ElapsedMilliseconds);
            Console.ReadKey();

        }

        static List<string> GetPermuttion(string s, int start, int end)
        {
            List<string> permuttion = new List<string>();
            if (start == end)
            {
                permuttion.Add(s);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    s = Swap(s, start, i);
                    permuttion.AddRange(GetPermuttion(s, start + 1, end));
                    s = Swap(s, start, i);
                }
            }
            permuttion.Sort();
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
            return new string(s.ToCharArray().Reverse()));
        }
    }
}
