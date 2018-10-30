using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinarySearchTree
    {
        /// <summary>
        /// Root of BinarySearchTree instance
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="root">Set the root property upon instantiation</param>
        public BinarySearchTree(Node root)
        {
            Root = root;
        }

        /// <summary>
        /// This method will add a new node in its ordered place in the tree. It will traverse the tree's nodes by judging whether the node to add's value is greater than or equal to the left node's value. If greater, the pointer will move to the right node. This operation will continue until the pointer is null.
        /// </summary>
        /// <param name="newNode">Node to add to tree</param>
        /// <returns>true or false</returns>
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

        /// <summary>
        /// This method will search the binary tree instance for a node of a passed in value. If no node is found, return null.
        /// </summary>
        /// <param name="val">object (string or integer)</param>
        /// <returns>node containing matching value</returns>
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
