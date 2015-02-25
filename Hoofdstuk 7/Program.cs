using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Hoofdstuk_7
{
    class Program
    {
        static void Main(string[] args)
        {
            const string SPACE = " ";
            string pig = "";
            string first;
            string last;
            string txt = "Dit is een piglatin generator";
            string[] words = txt.Split(' ');
            foreach (string word in words)
            {
                first = word.Substring(0, 1);
                last = word.Substring(1, word.Length - 1);

                pig += last + first + "ay" + SPACE;

            }
            Console.WriteLine(pig);
            Console.ReadKey();
        }
    }
}