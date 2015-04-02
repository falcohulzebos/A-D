using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD.LinkedList
{
    public class CLinkedList<T>
    {
        // header node
        private CNode<T> header;

        // new Clinkedlist
        public CLinkedList()
        {
            header = new CNode<T>(default(T));
        }

        // return true if linkedlist is empty
        public bool IsEmpty()
        {
            return (header.Link == null);
        }

        // return first node
        public CNode<T> GetFirst()
        {
            return header;
        }

        // write contenst of list to console
        public void ShowList()
        {
            CNode<T> current = header.Link;

            while (!(current == null))
            {
                Console.WriteLine(current.Element);

                current = current.Link;
            }
        }
    }
}
