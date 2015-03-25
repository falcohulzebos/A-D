using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace INF2K_DLL_AD.Hoofdstuk_1.oefeningen
{
    public class TimerClass
    {
        TimeSpan startingTime;
        TimeSpan duration;

        public TimerClass()
        {
            startingTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        public void stopTime()
        {
            Process p = Process.GetCurrentProcess();
            ProcessThread thread = p.Threads[0];
            thread.ProcessorAffinity = (IntPtr)1;
            duration = thread.UserProcessorTime.Subtract(startingTime);
        }

        public void startTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Process p = Process.GetCurrentProcess();
            ProcessThread thread = p.Threads[0];
            thread.ProcessorAffinity = (IntPtr)1;
            startingTime = thread.UserProcessorTime;
            
        }
        public TimeSpan result()
        {
            return duration;
        }
    }
}
