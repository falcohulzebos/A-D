using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace DigitalWatchnew
{
    class Watch
    {
        int mode = 0;
       
        Time time = new Time();
        String timeString;
       
        public Watch() 
        {
            time.startClock();
        }

        public void Switch()
        {
            mode++;
            if(mode == 3)
            {
                mode = 0;
                time.setMode(true);
                time.startClock();
            }
            if(mode != 0)
            {
                time.setMode(false);
            }
           
        }

        public void increment()
        {
            if(mode != 0)
            {
                if(mode == 1)
                {
                    time.incrementHours();
                }
                if(mode == 2)
                {
                    time.incrementMinutes();
                }
            }
        }
        
        public String showTime()
        {
            return time.timeString();
            
        }


    }
}
