using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD.Sorting
{
    static class InsertionSort
    {
        // sorts a array with T values with a insertionsort algorithm
        public static void Sort<T>(this T[] arr) where T : IComparable<T>
        {
            int inner;
            T temp;

            for (int outer = 1; outer <= arr.Length - 1; outer++)
            {
                temp = arr[outer];
                inner = outer;

                while (inner > 0 && arr[inner - 1].CompareTo(temp) > 0)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;
            }
        }
    }
}
