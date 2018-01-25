using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private static readonly string ROOT_DIR = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().Location);
        static void Main(string[] args)
        {
            string filename = "p022_names.txt";
            List<string> names = ReadName(filename);
            Console.WriteLine("The total of all the name scores in the file " 
                + filename + " is: " + Score(names));
            Console.ReadKey();

        }

        static int Score(List<string> names)
        {
            int score = 0;
            for (int i = 0; i < names.Count; i++)
            {
                score += Worth(names[i]) * (i + 1);
            }

            return score;

        }

        static int Worth(string name)
        {
            int worth = 0;
            foreach (char c in name)
                worth += c - 'A' + 1;
            return worth;
        }

        static List<string> ReadName(string filePath)
        {
            List<string> names = new List<string>();
            if (!File.Exists(ROOT_DIR + @"\" + filePath))
            {
                Console.WriteLine(ROOT_DIR + @"\" + filePath + "File does not exists!");
            }
            else
            {
                using (FileStream fs = File.Open(filePath, FileMode.Open,
                    FileAccess.Read))
                using (BufferedStream bs = new BufferedStream(fs))
                using (StreamReader sr = new StreamReader(bs))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        names.AddRange(line.Replace("\"", "").Split(',').ToList());
                    }
                }
                names.Sort();
            }

            return names;
        }
    }
}
