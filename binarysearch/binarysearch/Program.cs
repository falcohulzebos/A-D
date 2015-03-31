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
            b.Find((Int32.Parse( Console.ReadLine())));
            Console.ReadLine();
        }
    }
}