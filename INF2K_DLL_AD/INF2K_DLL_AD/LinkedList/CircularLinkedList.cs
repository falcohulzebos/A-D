using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD.LinkedList
{
    // Node klasse waar de data in op wordt geslagen. Deze nodes worden in een array gezet.
    public class Node 
    {

        public Object Element;  // inhoud van de node
        public Node next;       // de aanliggende node
        public Node previous;   // de vorige node

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

    public class CircularLinkedList {

        public Node current;       // de huidige node
        protected Node header;     // de eerste node in de list
        private int count;         // het aantal objecten in de list

        public CircularLinkedList() 
        {
            count = 0;
            header = new Node("header");
            header.next = header;
           
        }

        // checken of de list leeg is.
        public bool IsEmpty() 
        {
            return (header.next == null);
        }

        // de plek naast de header leegmaken
        public void MakeEmpty() 
        {
            header.next = null;
        }

        // Alle inhoud van de list printen in de console
        public void PrintList() 
        {
            Node current = new Node();
            current = header;
            int counter = 0;

            // zolang de volgende node geen "header" is, print dan de volgende node uit in de console
            while (!(current.next.Element.ToString() == "header")) 
            {
                Console.WriteLine(counter + ": "+ current.next.Element);
                current = current.next;
                counter++;
            }
        }

        // De Node opzoeken die 1 plek voor de ingegeven node ligt.
        private Node FindPrevious(Object n) 
        {
            // beginnen bij de node na de header
            Node current = header.next;
            Console.WriteLine("current " + current.Element.ToString());
            
            // Als de volgende node niet leeg is en als de volgende node niet de ingevulde parameter is
            // dan wordt current de volgende node en herhaalt de loop zich
            // is de volgende node wel de ingevulde parameter, dan wordt de huidige node uitgeprint.
            while (!(current.next == null) && current.next.Element !=n)
            {
               
                    current = current.next;
                
            }
            return current;
         }

        // zoeken naar de ingegeven node.
        private Node Find(Object n) 
        {
            // beginnen bij de header
            Node current = new Node();
            current = header;

            // zolang current niet de ingegeven parameter is wordt de volgende node bekeken.
            while (current.Element != n)
            {
                current = current.next;
            }
            return current;
        }

        // verwijderen van de ingegeven node
        public void Remove(Object n) 
        {
            // eerst wordt er gekeken naar de node die voor de ingegeven node ligt.
            Node p = FindPrevious(n);
            Console.WriteLine("previous= " + p.Element.ToString());
            try 
            { 
                // als de node na de "vorige" node geen null is
                // dan wordt de ingegeven node vervangen door de volgende node
                // en wordt de count met 1 naar beneden gehaald.
                if (!(p.next == null))
                {
                 p.next = p.next.next;
                }
                count--;
                }
                catch(Exception)
                {}
        }

        // toevoegen van een entry.
        // n1: de toe te voegen node
        // n2: de node waarnaast n1 moet worden toegevoegd.
        public void Insert(Object n1, Object n2) 
        {
            Node current = new Node();
            Node newnode = new Node(n1);    // de node om toe te voegen
            current = Find(n2);             // current wordt de node waarnaast n1 moet worden toegevoegd.
            newnode.next = current.next;    // nieuwe lege node naast de nieuwe node toevoegen
            current.next = newnode;         // node naast de huidige node wordt de nieuwe node.
           
            count++;
        }

        // een node aan het begin toevoegen
        public void InsertFirst(Object n) 
        {
            Node current = new Node(n);
            current.next = header;      // current.next wordt "header"
            header.next = current;      // nieuwe node wordt na header toegevoegd.
           
            count++;

        }

        // alle nodes een n aantal plekken opschuiven.
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
