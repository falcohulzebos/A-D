using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;


namespace DigitalWatch
{
    class DigitalWatch
    {
        public int hours, minutes;
        public Boolean setHours, setMinutes;
        Display display = new Display();
        Thread timer;

        public DigitalWatch()
        {
            hours = 0;
            minutes = 0;
            setHours = false;
            setMinutes = false;
            timer = new Thread(new ThreadStart(startTimer));
            timer.Start();
            Display disp = new Display();
        }

       
        public void startTimer()
        {
            Thread.Sleep(1000);
            minutes++;
            if(minutes == 60)
            {
                hours++;
            }
            if(hours == 24)
            {
                hours = 0;
            }
        }
        

    }
}
