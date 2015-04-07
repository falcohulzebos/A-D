using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD.search 
{
    class searchClass<T>
    {
        /// <summary>
        /// Performs sequential search on the array
        /// </summary>
        /// <param name="arr">Array to search</param>
        /// <param name="value">value to search for</param>
        /// <param name="occurance">occurance wich must be found</param>
        /// <returns>int index</returns>
        public int seqSearch(T[] arr, T value, int occurance)
        {
            T theValue = default(T);
            int occuranceCounter = 0;
            int index = -1; ;
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
                        index = i;
                        notFinished = false;
                    }
                }
            }
            return index;
        }

        /// <summary>
        /// searches for lowest value in array
        /// </summary>
        /// <param name="arr">Array to search</param>
        /// <returns>min value</returns>
        public T Min(T[] arr)
        {
            T theValue = default(T);
            for(int i = 0; i < arr.Length; i++)
            {
                T temp = arr[i];
                if(temp.ToString().CompareTo(theValue.ToString()) < 0)
                {
                    theValue = temp;
                }
            }
            return theValue;
        }

        /// <summary>
        /// searches for highest value in array
        /// </summary>
        /// <param name="arr">Array to search</param>
        /// <returns>max value</returns>
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

        /// <summary>
        /// searches for value in array with binary algorithm
        /// </summary>
        /// <param name="arr">Array to search</param>
        /// <returns>min value</returns>
        public int binSearch(T[] arr, T value)
        {
            int upperBound, lowerBound, mid;

            upperBound = arr.Length;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;

                if (arr[mid].Equals(value))
                {
                    return mid;
                }
                else if (value.ToString().CompareTo(arr[mid]) < 0)
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
