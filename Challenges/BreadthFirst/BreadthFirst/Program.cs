using System;
using System.Collections.Generic;
using BreadthFirstChallenge.Classes;

namespace BreadthFirstChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate list collection that will hold the breadth first nodes of BT
            List<Node> nodesToPrint = new List<Node>();

            // Set up a BT
            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node43 = new Node(43);
            Node node7 = new Node(7);
            Node node15 = new Node(15);
            Node node21 = new Node(21);
            Node node3 = new Node(3);

            node0.LeftChild = node1;
            node0.RightChild = node43;
            node1.LeftChild = node7;
            node1.RightChild = node15;
            node43.LeftChild = node21;
            node43.RightChild = node3;

            /*
            
                    0
                  /   \
                 1     43
                / \    /\
               7  15  21 3

             */

            // Reassign the List after traversing BT in breadth-first
            nodesToPrint = BreadthFirst(node0, nodesToPrint);

            // Print out values of List<Node> in console
            foreach (var node in nodesToPrint)
            {
                Console.WriteLine(node.Value);
            }
        }

        /// <summary>
        /// This method collects the nodes in breadth-first traversal order.
        /// </summary>
        /// <param name="rootOfBinaryTree">root of the binary tree</param>
        /// <param name="nodesToPrint">List object that will later be iterated over to print the node values</param>
        /// <returns>List of nodes</returns>
        public static List<Node> BreadthFirst(Node rootOfBinaryTree, List<Node> nodesToPrint)
        {
            Queue breadth = new Queue(rootOfBinaryTree);

            while (breadth.Peek() != null)
            {
                Node temp = breadth.Peek();
                nodesToPrint.Add(temp);
                breadth.Enqueue(temp.LeftChild);
                breadth.Enqueue(temp.RightChild);
                breadth.Dequeue();
            }

            return nodesToPrint;
        }
    }

}
