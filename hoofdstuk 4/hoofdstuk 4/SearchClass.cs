using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoofdstuk_4
{
    class SearchClass
    {
        public int seqSearch(int[] arr, int value, int occurance)
        {
            int theValue = -1;
            int occuranceCounter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == value)
                {
                    occuranceCounter++;
                    if (occuranceCounter == occurance)
                    {
                        theValue = arr[i];
                    }
                }
            }
            return theValue;
        }

        public int seqLast(int[] arr, int value)
        {
            int theValue = -1;
            int occurranceCounter = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == value)
                {
                    occurranceCounter++;
                    if (occurranceCounter > arr.Length)
                    {
                        theValue = arr[i];
                    }
                }
            }
            return theValue;
        }

    }
}
