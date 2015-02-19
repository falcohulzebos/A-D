using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoofdstuk_4
{
    class SearchClass
    {
        public string seqSearch(int[] arr, int value, int occurance)
        {
            int theValue = -1;
            int occuranceCounter = 0;
            Boolean notFinished = true;
            int i;
            for (i = 0; i < arr.Length - 1 & notFinished == true; i++)
            {
                if (arr[i] == value)
                {
                    occuranceCounter++;

                    if (occuranceCounter == occurance)
                    {
                        theValue = arr[i];
                        notFinished = false;
                    }
                }
            }
            return "value: " + theValue + " index: "+ (i-1) ;
        }

        public string seqLast(int[] arr, int value)
        {
            int theValue = -1, i, theIndex = 0;

            for (i = 0; i < arr.Length - 1  ; i++)
            {
                if (arr[i] == value)
                {

                    theIndex = i;
                    theValue = arr[i];
                  
                }
            }
            return "value: " + theValue + " index: " + theIndex;
        }

    }
}
