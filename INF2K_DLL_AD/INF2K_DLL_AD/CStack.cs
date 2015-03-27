using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD
{
    class CStack<T>
    {
        T[] stackArray;
        int counter = 0;
        
        // constructors
        // new stack with default length
        public CStack() 
        {
            stackArray = new T[16];
        }

        // copy of array to stack with length of array
        public CStack(T[] arr)
        {
            stackArray = new T[arr.Length];
            stackArray = arr;
        }

        // copy of queue to stack with length of old queue
        public CStack(CStack<T> stack)
        {
            stackArray = new T[stack.Length()];
            for(int i =0; i< stack.Length(); i++)
            {
                stackArray[i] = stack.pop();
            }
        }

        // add item to top of stack
        public void push(T item)
        {
            
            stackArray[counter] = item;
            counter++;
            if(counter == Length())
            {
                ResizeArray();
            }
        }

        // remove and return item from top of stack
        public T pop()
        {
            
            T returner = stackArray[counter];
            stackArray[counter] = default(T);
            counter--;
            return returner;
        }

        // return length of stack
        public int Length()
        {
            return stackArray.Length;
        }

        // remove all items from stack
        public void Clear()
        {
            stackArray = new T[16];
            counter = 0;
        }

        // add 16 places to stack
        public void ResizeArray()
        {
            Array.Resize(ref stackArray, stackArray.Length + 16);
        }

        // return top object in stack without deleting object
        public T Peek()
        {
            return stackArray[counter];
        }
    }
}
