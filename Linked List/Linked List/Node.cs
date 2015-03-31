using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class CNode<T>
    {
        public T Element;
        public CNode<T> Link;
       

        public CNode()
        {
            Element = default(T);
            Link = null;
        }

        public CNode(T theElement)
        {
            Element = theElement;
            Link = null;
        }

       
    }
}
