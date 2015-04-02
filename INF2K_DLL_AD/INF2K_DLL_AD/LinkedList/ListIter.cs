using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD.LinkedList
{
    public class ListIter<T>
    {
        private CNode<T> current;
        private CNode<T> previous;

        CLinkedList<T> theList;

        // new iterator
        // parameter list linkedlist for iterator
        public ListIter(CLinkedList<T> list)
        {
            theList = list;
            current = theList.GetFirst();
            previous = null;
        }

        // goes to next node
        // current node becomes previous
        // next node becomes current node
        public void NextLink()
        {
            previous = current;
            current = current.Link;
        }

        // returns current node
        public CNode<T> GetCurrent()
        {
            return current;
        }

        // insert new node before current node
        public void InsertBefore(T theElement)
        {
            CNode<T> newNode = new CNode<T>(theElement);

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

        // insert new node after current node 
        public void InsertAfter(T theElement)
        {
            CNode<T> newNode = new CNode<T>(theElement);
            newNode.Link = current.Link;
            current.Link = newNode;

        }

        // remove node from linkedlist
        public void Remove()
        {
            previous.Link = current.Link;
        }

        // resets iterator
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
    
    // exception class for handeling inserting before header
    public class InsertBeforeHeaderException : System.ApplicationException
    {
        public InsertBeforeHeaderException(string message)
            : base(message)
        {

        }
    }
}
