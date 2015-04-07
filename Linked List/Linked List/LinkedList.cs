using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class CLinkedList<T>
    {
        private CNode<T> header;

        public CLinkedList()
        {
            header = new CNode<T>(default(T));
        }

        public bool IsEmpty()
        {
            return (header.Link == null);
        }

        public CNode<T> GetFirst()
        {
            return header;
        }

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
