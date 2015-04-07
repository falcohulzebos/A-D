using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD
{
    public class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;
        
        // new array
        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }

        // insert item at end of array
        public void insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }

        // writes elements to console
        public void DisplayElements()
        {
           for(int i = 0; i <= upper; i++)
           {
               Console.Write(arr[i] + " ");
           }
        }

        // clears array
        public void Clear()
        {
            for(int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
                numElements = 0;
            }
        }
        
    }
}
