using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hoofdstuk_4
{
    public class unorderedBinsearch
    {
        public unorderedBinsearch()
        {
            ArrayList Lijst = new ArrayList();
            Random rnd = new Random(100);  
        }
        
        public void FillArray()
        {
            for (int i = 0; i < 100; i++)
            {
                Lijst.Add(rnd.Next(100));

            }
            Console.Write(Lijst);

        }
        static int binSearch(int value)
        {
            int upperBound, lowerBound, mid;
            upperBound = Lijst.Length - 1;
            lowerBound = 0;
            while(lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
            }
        }
            

    }
}
