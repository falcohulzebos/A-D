using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingH3
{
    class CArray
    {
        
        
            static void Main()
            {
                Random rnd = new Random();
                CArray nums = new CArray(100);
                for (int i = 0; i <= 99; i++)
                {
                    nums.Insert(rnd.Next(100));
                }

                Console.WriteLine("before sorting: ");
                nums.DisplayElements();
                nums.BubbleSort();
                Console.WriteLine("after sorting: ");
                nums.DisplayElements();
                Console.ReadLine();

            }

            private int[] arr;
            private int upper;
            private int numElements;
            public CArray(int size)
            {
                arr = new int[size];
                upper = size - 1;
                numElements = 0;
            }
            public void Insert(int item)
            {
                arr[numElements] = item;
                numElements++;
            }
            public void DisplayElements()
            {
                for (int i = 0; i <= upper; i++)
                    Console.WriteLine(arr[i] + " index is " + i);
                
            }

            public void Clear()
            {
                for (int i = 0; i <= upper; i++)
                {
                    arr[i] = 0;
                    numElements = 0;
                }
            }

            public void BubbleSort()
            {
                int temp;
                
                
                
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
                        
                    }
                
            }

   }
}
