using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INF2K_DLL_AD;

namespace Testapplicatie
{
    class Program
    {
        int[] randomIntArray;
        static void Main(string[] args)
        {
            Program p = new Program();
            Boolean breaker = true;
            

            // while loop voor programma continu laten draaien
            while(breaker)
            {
                Console.WriteLine();
                Console.WriteLine("TestApplicatie voor INF2K_DLL_AD");
                Console.WriteLine("opties:");
                Console.WriteLine("1 : bubblesort");
                Console.WriteLine("2 : insertionsort");
                Console.WriteLine("3 : smartbubblesort");

                Console.WriteLine("4 : binarysearch");
                Console.WriteLine("5 : minmax");
                Console.WriteLine("6 : sequentialsearch");

                Console.WriteLine("7 : queue");
                Console.WriteLine("8 : priorityqueue");
                Console.WriteLine("9 : stack");

                Console.WriteLine("10 : buckethash");
                Console.WriteLine("11 : linearhash");
                Console.WriteLine("12 : quadratichash");

                Console.WriteLine("13 : circularylinkedlist");
                Console.WriteLine("14 : koublylinkedlist");
                Console.WriteLine("15 : doublynode");
                Console.WriteLine("16 : iterator");
                Console.WriteLine("17 : linkedlist");
                Console.WriteLine("18 : binarysearchtree");

                Console.WriteLine("19 : exit");
                Console.WriteLine("give number choise:");
                int choise = Int32.Parse(Console.ReadLine());

                // keuze selectie
                if(choise < 1 || choise > 19)
                {
                    Console.WriteLine("wrong input, give new number choise:");
                    choise = Int32.Parse(Console.ReadLine());
                }

                if(choise == 1)
                {
                    Console.WriteLine("bubblesort:");
                    p.bubblesort();
                }

                if (choise == 2)
                {
                    Console.WriteLine("insertionsort:");
                    p.insertionsort();
                }
                if (choise == 3)
                {
                    Console.WriteLine("Smartbubblesort:");
                    p.smartbubblesort();
                }
                if (choise == 4 )
                {
                    Console.WriteLine("binarysearch:");
                    p.binarysearch();
                }
                if (choise == 5)
                {
                    Console.WriteLine("minmax:");
                    p.minmax();
                }
                if (choise == 6)
                {
                    Console.WriteLine("sequentialsearch:");
                    p.sequentialsearch();
                }
                if (choise == 7)
                {
                    Console.WriteLine("queue:");
                    p.queue();
                }
                if (choise == 8)
                {
                    Console.WriteLine("priorityqueue:");
                    p.priorityqueue();
                }
                if (choise == 9)
                {
                    Console.WriteLine("stack:");
                    p.stack();
                }
                if (choise == 10)
                {
                    Console.WriteLine("buckethash:");
                    p.buckethash();
                }
                if (choise == 11)
                {
                    Console.WriteLine("linearhash:");
                    p.linearhash();
                }
                if (choise == 12)
                {
                    Console.WriteLine("quadratichash:");
                    p.quadratichash();
                }
                if (choise == 13)
                {
                    Console.WriteLine("circularylinkedlist:");
                    p.circularylinkedlist();
                }
                if (choise == 14)
                {
                    Console.WriteLine("doublylinkedlist:");
                    p.doublylinkedlist();
                }
                if (choise == 15)
                {
                    Console.WriteLine("doublynode:");
                    p.doublynode();
                }
                if (choise == 16)
                {
                    Console.WriteLine("iterator:");
                    p.iterator();
                }
                if (choise == 17)
                {
                    Console.WriteLine("linkedlist:");
                    p.linkedlist();
                }
                if(choise == 18)
                {
                    Console.WriteLine("binarysearchtree:");
                    p.binarysearchtree();
                }
                if (choise == 19)
                {
                    breaker = false;
                }

            }

        }  
        
        public void newRandomIntArray(int size)
        {
            Console.WriteLine("unsorted array");
            randomIntArray = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++ )
            {
                randomIntArray[i] = rnd.Next(size * 2);
                Console.Write(randomIntArray[i]+" ");
            }
        }

        // bubblesort methode
        public void bubblesort()
        {
            newRandomIntArray(100);
            

        }
        public void insertionsort() { }
        public void smartbubblesort() { }

        public void binarysearch() { }
        public void minmax() { }
        public void sequentialsearch() { }

        public void queue() { }
        public void priorityqueue() { }
        public void stack() { }

        public void buckethash() { }
        public void linearhash() { }
        public void quadratichash() { }

        public void circularylinkedlist() { }
        public void doublylinkedlist() { }
        public void doublynode() { }
        public void iterator() { }
        public void linkedlist() { }
        public void binarysearchtree() { }
    }
}
