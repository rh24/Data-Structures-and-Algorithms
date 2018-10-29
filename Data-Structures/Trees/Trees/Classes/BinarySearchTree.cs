using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        public bool Add(Node newNode, Node root)
        {
            try
            {
                while (root != null)
                {
                    // you found a leaf!
                    if (root.RightChild == null && root.LeftChild == null)
                    {
                        if ((int)root.Value < (int)newNode.Value) root.RightChild = newNode;
                        else root.LeftChild = newNode;
                    }

                    if ((int)newNode.Value > (int)root.LeftChild.Value)
                    {
                        root = root.RightChild;
                        Add(newNode, root);
                    }

                    if ((int)newNode.Value < (int)root.RightChild.Value)
                    {
                        root = root.LeftChild;
                        Add(newNode, root);
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        //public Node Search(object val)
        //{

        //}
    }
}
