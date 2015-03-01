using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoofdstuk_6
{
    class CBitArray
    {
        BitArray BArray;
        Boolean[] boolArray;

        public CBitArray(Boolean[] a)
        {
            BArray = new BitArray(a.Length);
            boolArray = new Boolean[a.Length];
            boolArray = a;
            toBArray(a);
        }

        public void toBArray(Boolean[] b)
        {
            for(int i = 0; i< b.Length; i++)
            {
                BArray.Set(i, b[i]);
            }
            
        }

        public int boolToBit(Boolean b)
        {
            int returnByte = -1;
            if(b == true)
            {
                returnByte = 1;
            }
            if(b == false)
            {
                returnByte = 0;
            }

            return returnByte;
        }


    }
}
