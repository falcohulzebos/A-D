using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListClass 
{
    class ArrayListClass<T> : IEnumerable
    {


        private int count = 0;
        T[] myArray = new T[16];

      


        public void ResizeArray()
        {
            Array.Resize(ref myArray, myArray.Length + 16);
        }

        public void Add(T value)
        {
            if(count == myArray.Length)
            {
                ResizeArray();
                
            }
            if (count < myArray.Length)
            {
                myArray[count] = value;
            }
        }

        public void removeAt(int value)
        {
            var foos = new List<T>(myArray);
            foos.RemoveAt(value);
            myArray = foos.ToArray();
            count--;
        }

        public void remove(T value)
        {
            int index = Array.IndexOf(myArray, value);
            removeAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public Enum GetEnumerator()
        {
            return new Enum(myArray);
        }
        

    }
    class Enum : IEnumerator
    {



    }
}

