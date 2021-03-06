﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoofdstuk_4
{
    class SearchClass<T>
    {
        public string seqSearch(T[] arr, T value, int occurance)
        {
            T theValue = default(T);
            int occuranceCounter = 0;
            Boolean notFinished = true;
            int i;
            for (i = 0; i < arr.Length - 1 & notFinished == true; i++)
            {
                if (arr[i].Equals(value))
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

        public string seqLast(T[] arr, T value)
        {
            T theValue = default(T);
            int i, theIndex = 0;

            for (i = 0; i < arr.Length - 1  ; i++)
            {
                if (arr[i].Equals(value))
                {

                    theIndex = i;
                    theValue = arr[i];
                  
                }
            }
            return "value: " + theValue + " index: " + theIndex;
        }

        public T Max(T[] arr)
        {
            T theValue = default(T);
            for (int i = 0; i < arr.Length; i++)
            {
                T temp = arr[i];
                if (temp.ToString().CompareTo(theValue.ToString()) > 0)
                {
                    theValue = temp;
                }
            }
            return theValue;
        }

        public T Min(T[] arr)
        {
            T theValue = default(T);
            for (int i = 0; i < arr.Length; i++)
            {
                T temp = arr[i];
                if (temp.ToString().CompareTo(theValue.ToString()) < 0)
                {
                    theValue = temp;
                }
            }
            return theValue;
        }

    }
}
