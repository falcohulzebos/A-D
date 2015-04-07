using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearch
{
    public class CNode<T>
    {
        public T data;
        public CNode<T> Left;
        public CNode<T> Right;

        public void displayNode()
        {
            Console.WriteLine(data + " ");
        }
    }

    public class binarySearchTree<T>
    {
        public CNode<T> root;

        public binarySearchTree()
        {
            root = null;
        }

        public void insert(T i) 
        {
            CNode<T> newNode = new CNode<T>();
            newNode.data = i;
            try
            {
                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    CNode<T> current = root;
                    CNode<T> parrent;

                    while (true)
                    {
                        parrent = current;

                        if (i.ToString().CompareTo(current.data.ToString()) > 0)
                        {
                            current = current.Left;

                            if (current == null)
                            {
                                parrent.Left = newNode;

                                break;
                            }
                        }
                        else
                        {
                            current = current.Right;

                            if (current == null)
                            {
                                parrent.Right = newNode;

                                break;
                            }
                        }
                        
                    }
                }
            }catch(Exception e){ }
        }

        public CNode<T> Find(T key) 
        {
            CNode<T> current = root;
            while (!current.data.Equals(key))
            {
                
                if (key.ToString().CompareTo(current.data.ToString()) > 0)
                    current = current.Left;
                else
                current = current.Right;
                if (current == null)
                    return null;
            }
            return current;
        } 
    }
}
