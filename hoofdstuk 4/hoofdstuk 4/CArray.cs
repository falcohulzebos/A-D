using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoofdstuk_4
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
            CArray nums = new CArray(10);
            Random rnd = new Random(100);
            for(int i = 0; i <10; i++)
            {
                nums.insert((int)(rnd.NextDouble() * 100));
                Console.WriteLine("Before sorting: ");
                nums.DisplayElements();
                Console.WriteLine("During sorting: ");
                nums.BubbleSort();
                Console.WriteLine("After sorting: ");
                nums.DisplayElements();
            }
        }

        public static void BubbleSort<T>(this T[] arr) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                        swap(arr[j], arr[j + 1]);
                }
            }
        }

        public void selectionSort()
        {
            int min, temp;
            for(int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = inner = outer + 1; inner <= upper; inner++)
                {
                    if(arr[inner] < arr[min])
                    {
                        min = inner;
                        temp = arr[outer];
                        arr[outer] = arr[min];
                        arr[min] = temp;
                    }
                }
            }
        }
    }
}
