using System;
using Trees.Classes;

namespace FindMaxValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(0);
            BinaryTree bt = new BinaryTree(node);

            Node node5 = new Node(5);
            Node node15 = new Node(15);
            Node node3 = new Node(3);
            Node node6 = new Node(6);
            Node node7 = new Node(7);

            node.LeftChild = node5;
            node.RightChild = node15;
            node15.LeftChild = node3;
            node15.RightChild = node7;
            node5.RightChild = node6;

            /*
             
                  0
                /   \
               5    15
                \   / \
                6  3   7
            */

            Console.WriteLine(FindMaxFromBT(bt));
        }

        public static int? FindMaxFromBT(BinaryTree bt)
        {
            if (bt.Root == null) return null;
            return FindMax(bt.Root);
        }

        public static int FindMax(Node current, Node temp = null)
        {
            if (temp == null) temp = current;
            if ((int)current.Value > (int)temp.Value) temp = current;
            if (current.LeftChild != null) temp.Value = FindMax(current.LeftChild, temp);
            if (current.RightChild != null) temp.Value = FindMax(current.RightChild, temp);

            return (int)temp.Value;
        }
    }
}
