using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD.Hoofdstuk_1
{
    class Oversimplified_Timing_Test
    {
        static void DisplayNums(int[] arr)
        {
            for (int i = 0; i < arr.GetUpperBound(0); i++)
                Console.WriteLine(arr[i] + " ");
            DateTime startTime;
            TimeSpan endTime;

            startTime = DateTime.Now;
            endTime = DateTime.Now.Subtract(startTime);
        }
        

    }
}
