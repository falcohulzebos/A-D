using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtest
{
    class Program
    {
        private int[] arr;
        private int upper;
        private int numElements;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.BubbleSort();

            Console.ReadLine();
        }

        public void BubbleSort()
        {
            //Variabelen en array worden aangemaakt
            Console.WriteLine("Smart BubbleSort");
            int temp;
            int[] arr = new int[] { 3, 8, 1, 9, 6 };
            upper = arr.Length - 1;
            Boolean changed = false;
            //Do while zolang de array veranderd. Wanneer hij weer op true wordt gezet loopt hij er niet meer doorheen.
            do
            {
                for (int outer = upper; outer >= 1; outer--)
                {
                    for (int inner = 0; inner <= outer - 1; inner++)
                    {
                        if ((int)arr[inner] > arr[inner + 1])
                        {
                            temp = arr[inner];
                            arr[inner] = arr[inner + 1];
                            arr[inner + 1] = temp;

                        }
                    }
                    changed = true;

                }
            } while (changed == false);

            //For Loop om de array te printen in de console
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}