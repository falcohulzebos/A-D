using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {

        static void Main()
        {
            LinkedList MyList = new LinkedList();
            ListIter iter = new ListIter(MyList);
            string choice, value;

            try
            {
                iter.InsertAfter("David");
                iter.InsertAfter("Mike");
                iter.InsertAfter("Raymond");
                iter.InsertAfter("Bernica");
                iter.InsertAfter("Jennifer");
                iter.InsertAfter("Donnie");
                iter.InsertAfter("Michael");
                iter.InsertAfter("Terrill");
                iter.InsertAfter("Mayo");
                iter.InsertAfter("Clayton");
                while (true)
                {
                    Console.WriteLine("(n) Move to next node");
                    Console.WriteLine("(g) Get value in current Node");
                    Console.WriteLine("(r) Reset Iterator");
                    Console.WriteLine("(s) Show complete list");
                    Console.WriteLine("(a) Insert after");
                    Console.WriteLine("(b) Insert before");
                    Console.WriteLine("(c) Clear the screen");
                    Console.WriteLine("(x) Exit");
                    Console.WriteLine();
                    Console.WriteLine("Enter your choice");

                    choice = Console.ReadLine();
                    choice = choice.ToLower();

                    char[] onechar = choice.ToCharArray();

                    switch (onechar[0])
                    {
                        case 'n':

                            if (!(MyList.IsEmpty()) && (!(iter.AtEnd())))
                            {
                                iter.NextLink();
                            }
                            else
                            {
                                Console.WriteLine("Can't move to next link");
                            }
                            break;

                        case 'g':

                            if (!(MyList.IsEmpty()))
                            {
                                Console.WriteLine("Element: " + iter.GetCurrent().Element);
                            }
                            else
                            {
                                Console.WriteLine("List is empty");
                            }
                            break;
                        case 'r':

                            iter.Reset();
                            break;

                        case 's':

                            if (!(MyList.IsEmpty()))
                            {
                                MyList.ShowList();
                            }
                            else
                            {
                                Console.WriteLine("List is empty");
                            }
                            break;

                        case 'a':

                            Console.WriteLine();
                            Console.Write("Enter value to insert:");
                            value = Console.ReadLine();
                            iter.InsertAfter(value);
                            break;

                        case 'b':

                            Console.WriteLine();
                            Console.Write("Enter value to insert:");
                            value = Console.ReadLine();
                            iter.InsertBefore(value);
                            break;

                        case 'c':
                            Console.Clear();
                            break;

                        case 'x':
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch
            {

            }
        }

        public class Node
        {
            public Object Element;
            public Node Link;

            public Node()
            {
                Element = null;
                Link = null;
            }

            public Node(Object theElement)
            {
                Element = theElement;
                Link = null;

            }
        }

        public class InsertBeforeHeaderException : System.ApplicationException
        {
            public InsertBeforeHeaderException(string message)
                : base(message)
            {

            }
        }

        public class LinkedList
        {
            private Node header;

            public LinkedList()
            {
                header = new Node("header");
            }

            public bool IsEmpty()
            {
                return (header.Link == null);
            }

            public Node GetFirst()
            {
                return header;
            }

            public void ShowList()
            {
                Node current = header.Link;

                while (!(current == null))
                {
                    Console.WriteLine(current.Element);

                    current = current.Link;
                }
            }
        }
        public class ListIter
        {
            private Node current;
            private Node previous;

            LinkedList theList;

            public ListIter(LinkedList list)
            {
                theList = list;
                current = theList.GetFirst();
                previous = null;
            }

            public void NextLink()
            {
                previous = current;
                current = current.Link;
            }

            public Node GetCurrent()
            {
                return current;
            }

            public void InsertBefore(Object theElement)
            {
                Node newNode = new Node(theElement);

                if (previous.Link == null)
                {
                    throw new InsertBeforeHeaderException("Can't insert here.");
                }
                else
                {
                    newNode.Link = previous.Link;
                    previous.Link = newNode;
                    current = newNode;
                }
            }

            public void InsertAfter(Object theElement)
            {
                Node newNode = new Node(theElement);
                newNode.Link = current.Link;
                current.Link = newNode;

            }

            public void Remove()
            {
                previous.Link = current.Link;
            }

            public void Reset()
            {
                current = theList.GetFirst();
                previous = null;
            }

            public bool AtEnd()
            {
                return (current.Link == null);
            }
        }
    }
}
