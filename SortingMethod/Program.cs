using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMethod
{
    class Bubblesort
    {

        static void Main()
        {

        }
        interface ISortAlgorithm<T>
        {
            void Sort(T[] words);
        }
        class BubbleSort : ISortAlgorithm<int>
        {
            public void Sort(int[] words)
            {
               // int[] words = { 800, 11, 50, 771, 649, 770, 240, 9 };

                int temp;
                for (int i = 1; i <= words.Length - 2; i++)
                {
                    for (int sort = 0; sort <= words.Length - 2; sort++)
                    {
                        if (words[sort] > words[sort + 1])
                        {
                            temp = words[sort + 1];
                            words[sort + 1] = words[sort];
                            words[sort] = temp;
                        }
                    }
                }
                Console.WriteLine("BubbleSort");
                foreach (int word in words)
                    Console.Write(word + " ");
                Console.ReadLine();
            }
        }
    }
}
