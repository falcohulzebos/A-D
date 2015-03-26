using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace INF2K_DLL_AD
{
    public class TimerClass
    {
        // timespans
        TimeSpan startingTime;
        TimeSpan duration;

        // calls timerclass with initial values
        public TimerClass()
        {
            startingTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }

        // stops mesuring time 
        public void stopTime()
        {
            Process p = Process.GetCurrentProcess();
            ProcessThread thread = p.Threads[0];
            thread.ProcessorAffinity = (IntPtr)1;
            duration = thread.UserProcessorTime.Subtract(startingTime);
        }

        // starts mesuring time
        public void startTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Process p = Process.GetCurrentProcess();
            ProcessThread thread = p.Threads[0];
            thread.ProcessorAffinity = (IntPtr)1;
            startingTime = thread.UserProcessorTime;
            
        }

        // retuns duration
        public TimeSpan result()
        {
            return duration;
        }
    }
}
