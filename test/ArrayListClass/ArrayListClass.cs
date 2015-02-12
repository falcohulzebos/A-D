using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListClass
{
    class ArrayListClass
    {
        int[] myArray = new int[16];

        public void ResizeArray()
        {           
            Array.Resize(ref myArray, myArray.Length + 16);
        }

        public static void ReadArray<T>(T[] inputArray)
        {
            
        }
    }
}
