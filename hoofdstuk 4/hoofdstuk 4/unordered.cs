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
        //initialiseren van de lijst en de random.
        public int[] Lijst = new int[100];
        Random rnd = new Random(100);
        public unorderedBinsearch()
        {
              
        }
        //lijst vullen met de integers.
        public void FillArray()
        {
            for (int i = 0; i < Lijst.Length; i++)
            {
                Lijst[i] = rnd.Next(100);

            }
            Console.Write(Lijst);

        }
        //de functie voor het binair zoeken
        public static int binSearch(int value)
        {
            unorderedBinsearch u = new unorderedBinsearch();
            u.FillArray();
            int upperBound, lowerBound, mid;
            upperBound = u.Lijst.Length;
            lowerBound = 0;
            while(lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;

                if(u.Lijst[mid]==  value)
                {
                    return mid;
                }
                else if (value < u.Lijst[mid])
                {
                    upperBound = mid - 1;
                }
                else
                {
                    lowerBound = mid + 1;
                }

            }
            return -1;
        }
            

    }
}
