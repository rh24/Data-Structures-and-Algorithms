using Hashtables;
using System;
using System.Collections.Generic.List;
using Trees.Classes;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<Node> TreeIntersections(BinaryTree bt1, BinaryTree bt2,
        {
            Hashtable ht1 = new Hashtable();
            Hashtable ht2 = new Hashtable();

            ht1 = RecursivePreOrder(bt1.Root, ht1);
            ht2 = RecursivePreOrder(bt2.Root, ht2);
        }
         
        public static Hashtable RecursivePreOrder(Trees.Classes.Node node, Hashtable ht)
        {
            if (node == null) return ht;
            ht.Add((string)node.Value, node.Value);
            RecursivePreOrder(node.LeftChild, ht);
            RecursivePreOrder(node.RightChild, ht);
        }
    }
}
