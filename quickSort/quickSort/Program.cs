using CcQuicksort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace quickSort
{

    class Program
    {

        

        static void Main(string[] args)
        {
            
            // Create an unsorted array of string elements
            string[] unsorted = { "z", "e", "x", "c", "m", "q", "a" };
           
            // Print the unsorted array
            Console.WriteLine("unsorted list");
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.WriteLine(unsorted[i] + " ");
            }

            Console.WriteLine();

            // Sort the array
            CQuicksort.Quicksort(unsorted, 0 , unsorted.Length-1);

            // Print the sorted array
            Console.WriteLine();
            Console.WriteLine("sorted list");
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.WriteLine(unsorted[i]);
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
