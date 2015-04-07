using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularList
{
class Program
    {
        static void Main(string[] args)
        {
            LinkedList collection = new LinkedList();
            Console.WriteLine("Invoeren gegevens: ");
            collection.Insert("een", "header");
            collection.Insert("twee", "een");
            collection.Insert("drie", "twee");
            collection.Insert("vier", "drie");
            collection.Insert("vijf", "vier");
            collection.Insert("zes", "vijf");
            collection.Insert("zeven", "zes");
            collection.PrintList();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            collection.Remove("vier");
            Console.WriteLine("");
            collection.PrintList();
            Console.ReadLine();
            
        }
    }


    public class Node 
    {

        public Object Element;
        public Node next;
        public Node previous;

        public Node() 
        {
            Element = null;
            next = null;
            previous = null;
        }

        public Node(Object theElement) 
        {
            Element = theElement;
            next = null;
            previous = null;
        }
    }

    public class LinkedList {

        public Node current;
        protected Node header;
        private int count;

        public LinkedList() 
        {
            count = 0;
            header = new Node("header");
            header.next = header;
        }

        public bool IsEmpty() 
        {
            return (header.next == null);
        }

        public void MakeEmpty() 
        {
            header.next = null;
        }

        public void PrintList() 
        {
            Node current = new Node();
            current = header;
            int counter = 0;


            while (!(current.next.Element.ToString() == "header")) 
            {
                Console.WriteLine(counter + ": "+ current.next.Element);
                current = current.next;
                counter++;
            }
        }

        private Node FindPrevious(Object n) 
        {
            Node current = header.next;

            while (!(current.previous == null) && current.previous.Element !=n)
            {
                current = current.previous;
            }
            return current;
         }

        private Node Find(Object n) 
        {
            Node current = new Node();
            current = header;

            while (current.Element != n)
            {
                current = current.next;
            }
            return current;
        }

        public void Remove(Object n) 
        {
            Node p = FindPrevious(n);
            try { 
            if (!(p.next == null))
            {
                p.previous = p.next.next;
            }
            count--;
            }
            catch(Exception)
            {}
        }

        public void Insert(Object n1, Object n2) 
        {
            Node current = new Node();
            Node newnode = new Node(n1);
            current = Find(n2);
            newnode.next = current.next;
            current.next = newnode;
            count++;
        }

        public void InsertFirst(Object n) 
        {
            Node current = new Node(n);
            current.next = header;
            header.next = current;
            count++;

        }

        public Node Move(int n) 
        {
            Node current = header.next;
            Node temp;

            for(int i = 0; i <= n; i++)
            {
                current = current.next;
            }
            if (current.Element.ToString() == "header")
            {
                current = current.next;
            }
            temp = current;
            return temp;

        }
    }
}
