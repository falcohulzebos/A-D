using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingH3
{
     class Program
    {
        
        
            static void Main() 
            {
                

                Random rnd = new Random();
                int[] nums = new int[10];
                Console.WriteLine("before sorting: ");
                for (int i = 0; i <= 9; i++)
                {
                    nums[i] = (rnd.Next(100));
                    Console.Write(nums[i] + " ");
                }

                
                
                Console.WriteLine("after sorting: ");
                INF2K_DLL_AD.sotringAlgoritmes.InsertionSort.Sort<int>(nums);
                for (int i = 0; i <= 9; i++)
                {
                  
                    Console.Write(nums[i] + " ");
                }
                Console.ReadLine();

            }

            //private int[] arr;
            //private int upper;
            //private int numElements;
            //public CArray(int size)
            //{
            //    arr = new int[size];
            //    upper = size - 1;
            //    numElements = 0;
            //}
            //public void Insert(int item)
            //{
            //    arr[numElements] = item;
            //    numElements++;
            //}
            //public void DisplayElements()
            //{
            //    for (int i = 0; i <= upper; i++)
            //        Console.WriteLine(arr[i] + " index is " + i);
                
            //}

            //public void Clear()
            //{
            //    for (int i = 0; i <= upper; i++)
            //    {
            //        arr[i] = 0;
            //        numElements = 0;
            //    }
            //}

            //public void BubbleSort()
            //{
            //    int temp;
                
                
                
            //        for (int outer = upper; outer >= 1; outer--)
            //        {
            //            for (int inner = 0; inner <= outer - 1; inner++)
            //            {
            //                if ((int)arr[inner] > arr[inner + 1])
            //                {
            //                    temp = arr[inner];
            //                    arr[inner] = arr[inner + 1];
            //                    arr[inner + 1] = temp;
            //                }
            //            }
                        
            //        }
                
            //}

            //public void SelectionSort()
            //{
            //    int min, temp;

            //    for (int outer = 0; outer <= upper; outer++)
            //    {
            //        min = outer;

            //        for (int inner = outer + 1; inner <= upper; inner++)
            //            if (arr[inner] < arr[min])
            //                min = inner;

            //        temp = arr[outer];
            //        arr[outer] = arr[min];
            //        arr[min] = temp;

            //    }

            //}


            //public static void InsertionSort<T>(this T[] arr) where T : IComparable<T>
            //{
            //    int inner;
            //    T temp;

            //    for (int outer = 1; outer <= arr.Length; outer++)
            //    {
            //        temp = arr[outer];
            //        inner = outer;

            //        while (inner > 0 && arr[inner - 1].CompareTo(temp) > 0)
            //        {
            //            arr[inner] = arr[inner - 1];
            //            inner -= 1;
            //        }
            //        arr[inner] = temp;
            //    }
            //}

            //public void InsertionSort()
            //{
            //    int inner, temp;

            //    for (int outer = 1; outer <= upper; outer++)
            //    {
            //        temp = arr[outer];
            //        inner = outer;

            //        while (inner > 0 && arr[inner - 1] >= temp)
            //        {
            //            arr[inner] = arr[inner - 1];
            //            inner -= 1;
            //        }
            //        arr[inner] = temp;
            //    }
            //}
   }
}
