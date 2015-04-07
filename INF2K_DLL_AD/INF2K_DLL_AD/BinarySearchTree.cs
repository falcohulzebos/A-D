using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF2K_DLL_AD
{
    // single node class with data and corresponding left and right node
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
        // root node
        public CNode<T> root;
        
        // new binarysearchtree
        public binarySearchTree()
        {
            root = null;
        }

        // insert a value into the tree
        public void insert(T i) 
        {
            // new node + data
            CNode<T> newNode = new CNode<T>();
            newNode.data = i;
            try
            {
                // if there is not a root node yet, root node = new node
                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    CNode<T> current = root;
                    CNode<T> parrent;
                    // check if new node should be left or right of parrent node, if new node value is lower then parrent, new node left
                    // else new node right
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

        // finds node with provided T data
        public CNode<T> Find(T data) 
        {
            CNode<T> current = root;
            // check if current node data equals data
            while (!current.data.Equals(data))
            {
                // if data < node data- search left node else search rigth node
                if (data.ToString().CompareTo(current.data.ToString()) > 0)
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
