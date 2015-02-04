using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace INF2K_DLL_AD.Hoofdstuk_1
{
    class Timer2
    {
        static void Main()
        {
            int[] nums = new int[100000];
            BuildArray(nums);
            TimeSpan startTime;
            TimeSpan duration;
            startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
            DisplayNums(nums);
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startTime);
            Console.WriteLine("Time" + duration.TotalSeconds);
        }
        static void BuildArray(int[] arr)
        {
            for (int i = 0; i <= 99999; i++)
                arr[i] = i;
        }
        static void DisplayNums(int[] arr)
        {
          for(int i = 0; i <= arr.GetUpperBound(0); i++)
          Console.WriteLine(arr[i] + " ");
        }
    }
}
