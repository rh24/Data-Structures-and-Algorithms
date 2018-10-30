using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        public bool Add(Node newNode)
        {
            Node current = Root;
            try
            {
                while (current != null)
                {
                    // you found a leaf!
                    if (current.RightChild == null && current.LeftChild == null)
                    {
                        if ((int)current.Value < (int)newNode.Value) current.RightChild = newNode;
                        else current.LeftChild = newNode;
                    }

                    if ((int)newNode.Value >= (int)current.LeftChild.Value)
                    {
                        current = current.RightChild;
                    }
                    else if ((int)newNode.Value < (int)current.RightChild.Value)
                    {
                        current = current.LeftChild;
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

        public Node Search(object val)
        {
            Node curr = Root;

            while (curr != null)
            {
                if ((int)curr.Value == (int)val) return curr;

                if ((int)curr.Value < (int)val)
                {
                    curr = curr.RightChild;
                }
                else if ((int)curr.Value > (int)val)
                {
                    curr = curr.LeftChild;
                }
            }

            return null;
        }
    }
}
