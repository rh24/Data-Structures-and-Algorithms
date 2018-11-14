using Hashtables;
using System;
using System.Collections.Generic;
using System.Collections.Generic.List;
using Trees.Classes;
using Node = Hashtables.Node;

namespace TreeIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<Hashtables.Node> TreeIntersections(BinaryTree bt1, BinaryTree bt2)
        {
            Hashtable ht1 = new Hashtable();
            Hashtable ht2 = new Hashtable();
            List<Hashtables.Node> overlappingValues = new List<Hashtables.Node>();

            ht1 = RecursivePreOrder(bt1.Root, ht1);
            ht2 = RecursivePreOrder(bt2.Root, ht2);

            for (int i = 0; i < ht1.HT.Length; i++)
            {
                if (ht1.HT[i] != null)
                {
                    Node current = ht1.HT[i].Head;

                    while (current != null)
                    {
                        Node found = ht2.HT[i].Find(current);
                        if (found != null) overlappingValues.Add(found);
                        current = current.Next;
                    }
                }
            }

            return overlappingValues;
        }
         
        public static Hashtable RecursivePreOrder(Trees.Classes.Node node, Hashtable ht)
        {
            if (node == null) return ht;
            ht.Add((string)node.Value, node.Value);
            RecursivePreOrder(node.LeftChild, ht);
            RecursivePreOrder(node.RightChild, ht);
            return ht;
        }
    }
}
