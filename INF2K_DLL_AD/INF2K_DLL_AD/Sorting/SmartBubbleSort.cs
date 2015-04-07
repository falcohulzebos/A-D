using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD.Sorting
{
    static class SmartBubbleSort
    {
        public static void BubbleSort<T>(this T[] arr) where T : IComparable<T>
        {
            Boolean changed = false;
            //Do while zolang de array veranderd. Wanneer hij weer op true wordt gezet loopt hij er niet meer doorheen.
            do
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        // check of de eerste value groter is dan de tweede, zo ja Swap
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                            INF2K_DLL_AD.SwapClass.Swap<T>(ref arr[j], ref arr[j + 1]);
                    }
                    changed = true;
                }
            } while (changed == false);
        }
    }
}
