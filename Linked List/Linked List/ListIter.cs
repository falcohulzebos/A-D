using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class ListIter<T>
    {
        private CNode<T> current;
        private CNode<T> previous;

        CLinkedList<T> theList;

        public ListIter(CLinkedList<T> list)
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

        public CNode<T> GetCurrent()
        {
            return current;
        }

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

        public void InsertAfter(T theElement)
        {
            CNode<T> newNode = new CNode<T>(theElement);
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
    
    public class InsertBeforeHeaderException : System.ApplicationException
    {
        public InsertBeforeHeaderException(string message)
            : base(message)
        {

        }
    }
}
