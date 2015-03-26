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

        // counter and array
        private int count = 0;
        T[] myArray = new T[16];

      

        // rezize the array with 16 extra spaces
        public void ResizeArray()
        {
            Array.Resize(ref myArray, myArray.Length + 16);
        }

        // add value to arraylist
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

        // remove value from arraylist at specified index
        public void removeAt(int value)
        {
            var foos = new List<T>(myArray);
            foos.RemoveAt(value);
            myArray = foos.ToArray();
            count--;
        }

        // remove value from arraylist
        public void remove(T value)
        {
            int index = Array.IndexOf(myArray, value);
            removeAt(index);
        }

        // foreach
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public MyEnum<T> GetEnumerator()
        {
            return new MyEnum<T>(myArray);
        }
        

    }
    class MyEnum<T> : IEnumerator
    {
        
    public T[] array;

    // Enumerators are positioned before the first element 
    // until the first MoveNext() call. 
    int position = -1;

    public MyEnum(T[] list)
    {
        array = list;
    }

    public bool MoveNext()
    {
        position++;
        return (position < array.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public T Current
    {
        get
        {
            try
            {
                return array[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }


    }
}

