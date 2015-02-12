using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListClass
{
    class ArrayListClass
    {
        static void main()
        {
            int[] myArray = new int[2];
            myArray[0] = 1;
            myArray[1] = 2;
        }

        public void ResizeArray()
        {
            myArray.Resize();
        }
    }
}
