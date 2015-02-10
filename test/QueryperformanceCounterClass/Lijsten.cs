using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryperformanceCounterClass
{
    class Lijsten
    {
        int[] numbers = new int[1000000];
        private int i;
        public void FillArray()
        {
            for(i = 0; i <= 1000000; i++)
            {
                numbers[i] = i;
            }
        }
    }
}
