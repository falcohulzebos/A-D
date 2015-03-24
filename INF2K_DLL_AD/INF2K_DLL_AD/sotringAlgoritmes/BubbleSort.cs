using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD.sotringAlgoritmes
{
    class BubbleSort
    {
        public static void BubbleSort<T>(this T[] arr) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                        INF2K_DLL_AD.SwapClass.Swap<T>(ref arr[j], ref arr[j + 1]);
                }
            }
        }
    }
}
