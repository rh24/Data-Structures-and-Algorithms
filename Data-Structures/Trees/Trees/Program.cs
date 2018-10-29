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
        }

        static void PrintPreOrder()
        {
            List<Node> nodes = new List<Node>();
            BinaryTree bt = new BinaryTree();
            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            node0.LeftChild = node1;
            node0.RightChild = node4;
            node1.LeftChild = node2;
            node1.RightChild = node5;
            node2.RightChild = node3;
            /*
             
                 0
               /   \
              1     4
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
            BinaryTree bt = new BinaryTree();
            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            node0.LeftChild = node1;
            node0.RightChild = node4;
            node1.LeftChild = node2;
            node1.RightChild = node5;
            node2.RightChild = node3;
            /*
             
                 0
               /   \
              1     4
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
            BinaryTree bt = new BinaryTree();
            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            node0.LeftChild = node1;
            node0.RightChild = node4;
            node1.LeftChild = node2;
            node1.RightChild = node5;
            node2.RightChild = node3;
            /*
             
                 0
               /   \
              1     4
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
