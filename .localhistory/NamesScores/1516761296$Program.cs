﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesScores
{
    class Program
    {
        /*
         * https://projecteuler.net/problem=22
         * Using names.txt (right click and 'Save Link/Target As...'), 
         * a 46K text file containing over five-thousand first names, 
         * begin by sorting it into alphabetical order. Then working out 
         * the alphabetical value for each name, multiply this value by 
         * its alphabetical position in the list to obtain a name score.
         * For example, when the list is sorted into alphabetical order, 
         * COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in 
         * the list. So, COLIN would obtain a score of 938 × 53 = 49714.
         * What is the total of all the name scores in the file?
         */
        static void Main(string[] args)
        {
        }

        static List<string> ReadName(string filePath)
        {
            List<string> names = new List<string>();
            if (!Directory.Exists(filePath))
            {
                Console.WriteLine("File does not exists!");
            }
            else
            {
                using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                    }
                }
            }

            return names;
        }
    }
}
