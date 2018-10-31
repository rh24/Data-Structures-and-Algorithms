using System;
using System.Collections.Generic;
using BreadthFirst.Classes;

namespace BreadthFirst
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
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            // Reassign the List after traversing BT in breadth-first
            nodesToPrint = BreadthFirst(node0, nodesToPrint);

            // Print out values of List<Node> in console
            foreach (var node in nodesToPrint)
            {
                Console.WriteLine(node.Value);
            }
        }

        public static List<Node> BreadthFirst(Node rootOfBinaryTree, List<Node> nodesToPrint)
        {
            Queue breadth = new Queue(rootOfBinaryTree);

            while (breadth.Peek().RightChild != null || breadth.Peek().LeftChild != null)
            {
                Node temp = breadth.Dequeue();
                nodesToPrint.Add(temp);
                breadth.Enqueue(temp.LeftChild);
                breadth.Enqueue(temp.RightChild);
            }

            return nodesToPrint;
        }
    }

}
