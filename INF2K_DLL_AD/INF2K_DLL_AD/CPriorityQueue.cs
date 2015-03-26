using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace INF2K_DLL_AD
{
    class CPriorityQueue<T>
    {
        ArrayList queueArray = new ArrayList();
        int counter = 0;
        int deleteIndex;
        // constructors
        // new queue with default length
        public CPriorityQueue() 
        {
            
        }

        // copy of queue to queue with length of old queue
        public CPriorityQueue(CPriorityQueue<T> queue)
        {
           
            for(int i =0; i< queue.Length(); i++)
            {
                queueArray[i] = queue.Dequeue();
            }
        }

        // add item to back of queue
        public void Enqueue(T item, int priority)
        {
            queueArray[counter] = new Item(item, priority);
            counter++;
        }

        // remove and return first item with highest priority
        public T Dequeue()
        {
            ArrayList temparray = new ArrayList();
            T returner = Peek();
            queueArray.Remove(deleteIndex);
            counter--;
            return returner;
        }

        // return length of queue
        public int Length()
        {
            return queueArray.Count;
        }

        // remove all items from queue
        public void Clear()
        {
            queueArray = new ArrayList();
            counter = 0;
        }

        // return first object in queue without deleting object
        public T Peek()
        {
            T returner = default(T);
            Item lowest = (Item)queueArray[0];
            for (int i = 0; i < queueArray.Count; i++)
            {
                Item temp = (Item)queueArray[i];
                if (temp.getPriority() < lowest.getPriority())
                {
                    lowest = temp;
                    deleteIndex = i;
                }
            }
            returner = lowest.getItem();
            return returner;
        }

        // item class with stored item and priority
        private class Item
        {
            T item;
            int priority;


            public Item(T item, int priority)
            {
                this.item = item;
                this.priority = priority;
            }

            public T getItem()
            {
                return item;
            }

            public int getPriority()
            {
                return priority;
            }
        }
    }
}
