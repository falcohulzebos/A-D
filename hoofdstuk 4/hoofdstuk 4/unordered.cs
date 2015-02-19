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
        public ArrayList Lijst = new ArrayList();
        Random rnd = new Random(100);
        public unorderedBinsearch()
        {
              
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
            unorderedBinsearch u = new unorderedBinsearch();

            int upperBound, lowerBound, mid;
            upperBound = u.Lijst.Count;
            lowerBound = 0;
            while(lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;

                if(u.Lijst[mid] ==  value)
                {
                    return mid;
                }

            }
        }
            

    }
}
