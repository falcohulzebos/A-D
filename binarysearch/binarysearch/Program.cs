using System;

public class Node
{
    public int data;
    public Node left;
    public Node right;



    public void displayNode()
    {
        Console.WriteLine(data + " ");
    }


}

public class binarySearchTree
{
    public Node root;

    public binarySearchTree()
    {
        root = null;
    }

    public void insert(int i)
    {
        Node newNode = new Node();
        newNode.data = i;

        if (root == null)
        {
            root = newNode;
        }
        else
        {
            Node current = root;
            Node parrent;

            while (true)
            {
                parrent = current;

                if (i < current.data)
                {
                    current = current.left;

                    if (current == null)
                    {
                        parrent.left = newNode;

                        break;
                    }
                    else
                    {
                        current = current.right;

                        if (current == null)
                        {
                            parrent.right = newNode;

                            break;
                        }
                    }
                }
            }
        }
    }
}