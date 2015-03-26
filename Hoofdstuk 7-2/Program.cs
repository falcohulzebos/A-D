using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hoofdstuk_7_2
{
    class Program
    {
        //public static void Main()
        //{
        //    string pattern = "patterns";
        //    string input = "er zijn veel patterns in deze tekst, maar de patterns hebben bepaalde patterns die je kan vinden";
        //    int occurenceCounter = 0;

        //    foreach (Match m in Regex.Matches(input, pattern))
        //    {
        //        occurenceCounter++;
        //    }
        //    Console.WriteLine(occurenceCounter);
        //    Console.ReadLine();
        //}

        public static void Main()
        {
            string pattern = "patterns";
            var sb = new StringBuilder("er zijn veel patterns in deze tekst, maar de patterns hebben bepaalde patterns die je kan vinden");
            int occurenceCounter = 0;
            string input = sb.ToString();
            foreach (Match m in Regex.Matches(input, pattern))
            {
                occurenceCounter++;
            }
            Console.WriteLine(occurenceCounter);
            Console.ReadLine();
        }
    }
}
