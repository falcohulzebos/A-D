using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace DigitalWatchnew
{
    class Time
    {
        
        int hours, minutes, seconds;
       
        public Time() 
        {
           
        }
        private Timer timer;
        Boolean mode = true;

        public void setMode(Boolean mode)
        {
            this.mode = mode;
        }

        public void incrementHours ()
        {
            hours++;
            if(hours == 24)
            {
                hours = 0;
            }
        }
        
        public void incrementMinutes ()
        {
            minutes++;
            if (minutes == 60)
            {
                minutes = 0;
            }
        }
       
        public void startClock()
        {
            timer = new System.Timers.Timer(1000);
           
            timer.Elapsed += (s,e) =>
            {
                if (seconds < 60)
                {
                    seconds++;
                }
                if(seconds == 60)
                {
                    seconds = 0;
                    minutes++;
                }
                if(minutes == 60)
                {
                    minutes = 0;
                    hours++;
                }
                if(hours == 24)
                {
                    hours = 0;
                }
                if (mode == false)
                timer.Stop();
                
                
            };
            if(mode == true)
            {
                timer.Start();
            }
           
        }

        public String getHours ()
        {
            if (hours < 10)
            {
                return "0" + hours;
            }
            return hours + "";
        }

        public String getMinutes()
        {
            if (minutes < 10)
            {
                return "0" + minutes;
            }
            return minutes + "";
        }

        public String getSeconds()
        {

            if (seconds < 10)
            {
                return "0" + seconds;
            }
            return seconds + "";
        }

        
        public String timeString()
        {
            return getHours() + ":" + getMinutes() + ":" + getSeconds();
        }
    }
}
