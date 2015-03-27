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
            Console.WriteLine("1: searchmethodstest \r\n 2: unorderedbinarytest \r\n 3: CArray");
            if (Console.ReadLine() == "1") { p.searchMethodsTest(); }
            if (Console.ReadLine() == "2") { p.unorderedBinaryTest(); }
            if (Console.ReadLine() == "3") { p.cArrayTests(); }
            if (Console.ReadLine() == "4") { p.getMin(); }
            if (Console.ReadLine() == "5") { p.getMax(); }
            
            

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
            unorderedBinsearch<int> u = new unorderedBinsearch<int>();
            Console.WriteLine("unordered binarysearch value 5: " + u.binSearch(arr,5));  
        }

        public void cArrayTests()
        {
            
        }

        public void getMin()
        {
            Console.WriteLine("min value");
            Console.WriteLine(s.Min(arr));
        }

        public void getMax()
        {
            Console.WriteLine("max value");
            Console.WriteLine(s.Max(arr));

        }


    }
}
