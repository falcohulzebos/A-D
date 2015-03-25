using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD
{
    class CQueue<T>
    {
        
        T[] queueArray;
        int counter = 0;
        
        // constructors
        // new queue with default length
        public CQueue() 
        {
            queueArray = new T[16];
        }

        // copy of array to queue with length of array
        public CQueue(T[] arr)
        {
            queueArray = new T[arr.Length];
            queueArray = arr;
        }

        // copy of queue to queue with length of old queue
        public CQueue(CQueue<T> queue)
        {
            queueArray = new T[queue.Length()];
            for(int i =0; i< queue.Length(); i++)
            {
                queueArray[i] = queue.Dequeue();
            }
        }

        // add item to back of queue
        public void Enqueue(T item)
        {
            
            queueArray[counter] = item;
            counter++;
            if(counter == Length())
            {
                ResizeArray();
            }
        }

        // remove and return item from front of queue
        public T Dequeue()
        {
            T[] temparray = new T[queueArray.Length];
            T returner = queueArray[0];
            for (int i = 0; i < counter; i++)
            {
                temparray[i] = queueArray[i + 1];
            }
            queueArray = temparray;
            counter--;
            return returner;
        }

        // return length of queue
        public int Length()
        {
            return queueArray.Length;
        }

        // remove all items from queue
        public void Clear()
        {
            queueArray = new T[16];
            counter = 0;
        }

        // add 16 places to queue
        public void ResizeArray()
        {
            Array.Resize(ref queueArray, queueArray.Length + 16);
        }

        // return first object in queue without deleting object
        public T Peek()
        {
            return queueArray[0];
        }
    }
}
