using System;
using Trees.Classes;
using System.Collections.Generic;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPreOrder();
            PrintInOrder();
            PrintPostOrder();
            PrintAddNodeToBSTAndSearch();
        }

        static void PrintAddNodeToBSTAndSearch()
        {
            List<Node> nodes = new List<Node>();
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            BinarySearchTree bst = new BinarySearchTree(node4);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node5 = new Node(5);
            node4.LeftChild = node2;
            node4.RightChild = node5;
            node2.LeftChild = node1;
            node2.RightChild = node3;

            /* BEFORE ADD:
              
                 4
               /   \
              2     5
             / \
            1   3
         
             */

            /* AFTER ADD:

                 4
               /   \
              2     5
             / \     \
            1   3     7

             */

            Node nodeToAdd = new Node(7);

            bst.Add(nodeToAdd);

            Console.WriteLine($"The node with value 7 should have been added as the RightChild of node 5." + Environment.NewLine + $"Root: {bst.Root.Value} \n\t root.RightChild: {bst.Root.RightChild.Value} \n\t root.RightChild.RightChild: {bst.Root.RightChild.RightChild.Value}");

            Console.WriteLine($"I searched for the val of 5, and I found the node! Its value is {bst.Search(5).Value}");
        }

        static void PrintPreOrder()
        {
            List<Node> nodes = new List<Node>();
            Node node0 = new Node(0);
            BinaryTree bt = new BinaryTree(node0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            node0.RightChild = node1;
            node0.LeftChild = node4;
            node1.LeftChild = node2;
            node1.RightChild = node5;
            node2.RightChild = node3;
            /*
             
                 0
               /   \
              4     1
             / \
            2   5
             \
              3
         
             */

            Console.WriteLine("------------ PRE-ORDER: -------------");
            foreach (var node in bt.PreOrder(node0, nodes))
            {
                Console.WriteLine(node.Value);
            }
        }

        static void PrintInOrder()
        {
            List<Node> nodes = new List<Node>();
            Node node0 = new Node(0);
            BinaryTree bt = new BinaryTree(node0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            node0.RightChild = node1;
            node0.LeftChild = node4;
            node1.LeftChild = node2;
            node1.RightChild = node5;
            node2.RightChild = node3;
            /*
             
                 0
               /   \
              4     1
             / \
            2   5
             \
              3
         
             */

            Console.WriteLine("------------ IN ORDER: -------------");
            foreach (var node in bt.InOrder(node0, nodes))
            {
                Console.WriteLine(node.Value);
            }
        }

        static void PrintPostOrder()
        {
            List<Node> nodes = new List<Node>();
            Node node0 = new Node(0);
            BinaryTree bt = new BinaryTree(node0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            node0.RightChild = node1;
            node0.LeftChild = node4;
            node1.LeftChild = node2;
            node1.RightChild = node5;
            node2.RightChild = node3;
            /*
             
                 0
               /   \
              4     1
             / \
            2   5
             \
              3
         
             */

            Console.WriteLine("------------ POST-ORDER: -------------");
            foreach (var node in bt.PostOrder(node0, nodes))
            {
                Console.WriteLine(node.Value);
            }
        }
    }
}
