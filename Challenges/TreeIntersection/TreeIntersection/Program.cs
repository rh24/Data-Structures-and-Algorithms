using Hashtables;
using System;
using System.Collections.Generic;
using Trees.Classes;
using Node = Trees.Classes.Node;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            BinaryTree bt1 = new BinaryTree(node4);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node5 = new Node(5);
            node4.LeftChild = node2;
            node4.RightChild = node5;
            node2.LeftChild = node1;
            node2.RightChild = node3;

            /* BT1 and BT2 are nearly identical. Therefore, every single one of its values should be printed to the console except for 3 and 7.
              
            BT1:
                 4
               /   \
              2     5
             / \
            1   3

            BT2:
                 4
               /   \
              2     5
             / \
            1   7
         
             */

            Node bt2node7 = new Node(7);
            Node bt2node4 = new Node(4);
            BinaryTree bt2 = new BinaryTree(bt2node4);
            Node bt2node1 = new Node(1);
            Node bt2node2 = new Node(2);
            Node bt2node5 = new Node(5);
            bt2node4.LeftChild = bt2node2;
            bt2node4.RightChild = bt2node5;
            bt2node2.LeftChild = bt2node1;
            bt2node2.RightChild = bt2node7;

            List<object> overlapping = TreeIntersections(bt1, bt2);

            // This will print 4, 2, 1, 5.
            foreach (var val in overlapping)
            {
                Console.WriteLine(val);
            }
        }

        /// <summary>
        /// This method takes in two binary trees as inputs and outputs the common values that are contained in both of the trees.
        /// </summary>
        /// <param name="bt1">First binary tree</param>
        /// <param name="bt2">Second binary tree</param>
        /// <returns>A generic list of objects that represent shared values</returns>
        public static List<object> TreeIntersections(BinaryTree bt1, BinaryTree bt2)
        {
            Hashtable ht1 = new Hashtable();
            Hashtable ht2 = new Hashtable();
            List<object> overlappingValues = new List<object>();

            ht1 = RecursivePreOrder(bt1.Root, ht1);
            ht2 = RecursivePreOrder(bt2.Root, ht2);
            Trees.Classes.Node current1 = bt1.Root;

            RecursivePreOrder(current1, overlappingValues, ht1, ht2);

            return overlappingValues;
        }

        /// <summary>
        /// This is a helper methods that recursively traverses a binary tree in depth-first pre-order traversal. As the tree is traversed, each node is stored in a hashtable.
        /// </summary>
        /// <param name="node">Node of binary tree</param>
        /// <param name="ht">Hashtable to store node values as key-value pairs</param>
        /// <returns>Hashtable containing all key-value pairs produced from each node of the binary tree</returns>
        public static Hashtable RecursivePreOrder(Trees.Classes.Node node, Hashtable ht)
        {
            if (node == null) return ht;
            ht.Add(node.Value.ToString(), node.Value);
            RecursivePreOrder(node.LeftChild, ht);
            RecursivePreOrder(node.RightChild, ht);
            return ht;
        }

        /// <summary>
        /// This method traverses abinary tree recursively using depth-first pre-order traversal and returns a generic list object containing shared values from two hashtables.
        /// </summary>
        /// <param name="node">Node of binary tree</param>
        /// <param name="returnList">Generic List of objects</param>
        /// <param name="ht1">First hashtable containing key-value pairs produced from nodes of binary tree 1</param>
        /// <param name="ht2">Second hashtable containing key-value pairs produced from nodes of binary tree 2</param>
        /// <returns></returns>
        public static List<object> RecursivePreOrder(Trees.Classes.Node node, List<object> returnList, Hashtable ht1, Hashtable ht2)
        {
            if (node == null) return returnList;
            if (ht1.Find(node.Value.ToString()) != null && ht2.Find(node.Value.ToString()) != null) returnList.Add(node.Value);
            RecursivePreOrder(node.LeftChild, returnList, ht1, ht2);
            RecursivePreOrder(node.RightChild, returnList, ht1, ht2);
            return returnList;
        }
    }
}
