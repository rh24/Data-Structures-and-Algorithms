using Hashtables;
using System;
using System.Collections.Generic;
using Trees.Classes;
using Node = Trees.Classes.Node;

namespace TreeIntersection
{
    class Program
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

            /* BT1 and BT2 are identical. Therefore, every single one of its values should be printed to the console.
              
                 4
               /   \
              2     5
             / \
            1   3

                 4
               /   \
              2     5
             / \
            1   3
         
             */

            Node bt2node3 = new Node(3);
            Node bt2node4 = new Node(4);
            BinaryTree bt2 = new BinaryTree(bt2node4);
            Node bt2node1 = new Node(1);
            Node bt2node2 = new Node(2);
            Node bt2node5 = new Node(5);
            bt2node4.LeftChild = bt2node2;
            bt2node4.RightChild = bt2node5;
            bt2node2.LeftChild = bt2node1;
            bt2node2.RightChild = bt2node3;

            List<object> overlapping = TreeIntersections(bt1, bt2);

            foreach (var val in overlapping)
            {
                Console.WriteLine(val);
            }
        }

        public static List<object> TreeIntersections(BinaryTree bt1, BinaryTree bt2)
        {
            Hashtable ht1 = new Hashtable();
            Hashtable ht2 = new Hashtable();
            List<object> overlappingValues = new List<object>();

            ht1 = RecursivePreOrder(bt1.Root, ht1);
            ht2 = RecursivePreOrder(bt2.Root, ht2);

            Trees.Classes.Node current1 = bt1.Root;

            RecursivePreOrder(current1.LeftChild, overlappingValues, ht1, ht2);
            RecursivePreOrder(current1.RightChild, overlappingValues, ht1, ht2);

            return overlappingValues;
        }
         
        public static Hashtable RecursivePreOrder(Trees.Classes.Node node, Hashtable ht)
        {
            if (node == null) return ht;
            ht.Add(node.Value.ToString(), node.Value);
            RecursivePreOrder(node.LeftChild, ht);
            RecursivePreOrder(node.RightChild, ht);
            return ht;
        }

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
