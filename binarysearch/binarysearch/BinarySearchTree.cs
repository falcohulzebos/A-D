using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearch
{
    public class Node<T>
    {
        public T data;
        public Node<T> Left;
        public Node<T> Right;

        public void displayNode()
        {
            Console.WriteLine(data + " ");
        }
    }

    public class binarySearchTree<T>
    {
        public Node<T> root;

        public binarySearchTree()
        {
            root = null;
        }

        public void insert(T i)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = i;

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node<T> current = root;
                Node<T> parrent;

                while (true)
                {
                    parrent = current;

                    if (i.ToString().CompareTo(current.data.ToString()) < 0)
                    {
                        current = current.Left;

                        if (current == null)
                        {
                            parrent.Left = newNode;

                            break;
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
            }
        }

        public Node<T> Find(T key)
        {
            Node<T> current = root;
            while (!current.data.Equals(key))
            {
                
                if (key.ToString().CompareTo(current.data.ToString()) < 0)
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
