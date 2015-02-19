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
        SearchClass<int> s = new SearchClass<int>();
        

        static void Main(string[] args)
        {
            
            Program p = new Program();
            
            p.fillArray();
            p.searchMethodsTest();
            p.unorderedBinaryTest();
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

        public void searchMethodsTest()
        {
            Console.WriteLine("sequential search value 4 occurance 2: \r\n " + s.seqSearch(arr, 4, 2));
            Console.WriteLine("sequential search value 4: \r\n " + s.seqLast(arr, 4));
        }

        public void unorderedBinaryTest()
        {
            Console.WriteLine("unordered binarysearch value 5: " + unorderedBinsearch.binSearch(5));  
        }
    }
}
