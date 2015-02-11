using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryperformanceCounterClass
{
    class Lijsten
    {
        
        private Object thisLock = new Object();
        QueryPerfCounter Q = new QueryPerfCounter();
        int[] numbers = new int[1000000];
        private int i;



        public double FillArray()
        {
            lock (thisLock)
            {
                Q.Start();
                for (i = 0; i < 1000000; i++)
                {
                    numbers[i] = i;
                }
                Q.Stop();
            }

            return Q.Duration(1);

        }
        public double FillCollection()
        {
            lock (thisLock)
            {
                Q.Start();
                for (i = 0; i < 1000000; i++)
                {
                    numbers[i] = i;
                }
                Q.Stop();
            }

            return Q.Duration(2);

        }
    }
}
