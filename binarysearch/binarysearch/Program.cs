using System;

namespace binarysearch
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            binarySearchTree<int> b = new binarySearchTree<int>();
            for (int i = 0; i < 25;i++)
            {
                int value = rnd.Next(50);
                b.insert(value);
                Console.WriteLine(value);
            }
            int choise = Int32.Parse( Console.ReadLine());
            if (b.Find(choise) != null)
            {
                int data = b.Find(choise).data;
                if (data != null) { Console.WriteLine(data); } else { Console.WriteLine("null"); }
            }
            
            Console.ReadLine();
        }
    }
}