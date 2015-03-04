using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofdstuk_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nounArray = new string[] { "I", "you", "he", "she", "Mary" };
            string[] verbArray = new string[] { "ate", "bought", "saw", "sold", "wanted" };
            string[] objeArray = new string[] { "apple", "banana", "pear", "peach", "melon" };
            var sb = new StringBuilder("ate Mary peach");
            string[] sentenceArray = sb.ToString().Split(' ');
            string noun = "", verb = "", obje = "";
            for (int i = 0; i < sentenceArray.Length; i++)
            {
                for (int j = 0; j < nounArray.Length; j++)
                {
                    if (sentenceArray[i] == nounArray[j])
                    {
                        noun = sentenceArray[i];
                    }

                    if (sentenceArray[i] == verbArray[j])
                    {
                        verb = sentenceArray[i];
                    }

                    if (sentenceArray[i] == objeArray[j])
                    {
                        obje = sentenceArray[i];
                    }

                }

            }

            Console.WriteLine("Noun: " + noun);
            Console.WriteLine("Verb: " + verb);
            Console.WriteLine("Object: " + obje);
            Console.ReadLine();
        }
    }
}
