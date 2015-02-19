using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoofdstuk_4
{
    class Program
    {
        public int[] arr = new int[100];
        Random rnd = new Random();

        static void Main(string[] args)
        {
            Program p = new Program();
            SearchClass s = new SearchClass();
            p.fillArray();
            Console.WriteLine("sequential search value 4 occurance 2: \r\n "+ s.seqSearch(p.arr, 4 , 2));
            Console.WriteLine("sequential search value 4: \r\n "+ s.seqLast(p.arr, 4));
            Console.ReadLine();
        }

        public void fillArray()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(8);
                Console.WriteLine("index: "+ i + "value: " +arr[i]);
            }
        }

    }
}
