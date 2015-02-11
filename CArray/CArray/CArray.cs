using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CArray
{
    public class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;
        
        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }

        public void insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }

        public void DisplayElements()
        {
           for(int i = 0; i <= upper; i++)
           {
               Console.Write(arr[i] + " ");
           }
        }

        public void Clear()
        {
            for(int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
                numElements = 0;
            }
        }
        static void Main()
        {
            CArray nums = new CArray(50);
            for(int i = 0; i <=49; i++)
            {
                nums.insert(i);
                nums.DisplayElements();
            }
        }
    }
}
