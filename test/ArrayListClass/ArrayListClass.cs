using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListClass
{
    class ArrayListClass<T>
    {
        
        
        private int counter = 0;
        T[] myArray = new T[16];

        static void main()
        {
            
        }

      
        public void ResizeArray()
        {
            Array.Resize(ref myArray, myArray.Length + 16);
        }

        public void Add(T value)
        {
            myArray[counter] = value;
        }
    }
}
