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
        byte[] byteArray;

        public CBitArray(Boolean[] a)
        {
            
            byteArray = new byte[a.Length];
            boolArray = new Boolean[a.Length];
            boolArray = a;
            makeBitArray(boolArray);
        }

        private byte boolToBit(Boolean b)
        {
            byte returnByte = 0;
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

        public void makeBitArray(Boolean[] h)
        {
            for(int i = 0; i < h.Length ; i++)
            {
                byteArray[i] = boolToBit(h[i]);
            }
            BArray = new BitArray(byteArray);
            
        }

        public byte get(int index)
        {
            Boolean returnByte = false;
            returnByte = BArray.Get(index);
            return boolToBit(returnByte);
        }

        public void set(int index, Boolean value)
        {
            BArray.Set(index, value);
        }

        public int Length()
        { 
            return BArray.Length;
        }

        public void not()
        {
            for (int i = 0; i < BArray.Length; i++)
            {
                if (BArray.Get(i) == false)
                {
                    BArray.Set(i, true);
                }
                if (BArray.Get(i) == true)
                {
                    BArray.Set(i, false);
                }
            }
        }


        


    }
}
