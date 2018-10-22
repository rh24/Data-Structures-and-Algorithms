using System;
using LinkList.Classes;
using System.Collections.Generic;

namespace LLReverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            LList ll = new LList(new Node(0));

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            List<Node> nodes = new List<Node>() { node1, node2, node3, node4 };

            foreach (var node in nodes)
            {
                ll.Add(node);
            }

            ll.Print();
            // 4 --> 3 --> 2 --> 1 --> 0 --> NULL

            Console.WriteLine("--------- now, reverse it: ------------");

            LList reversed = ReverseLLInPlace(ll);
            reversed.Print();

            //LList reverseTwo = ReverseLLWithNext(ll);
            //reverseTwo.Print();
        }

        public static LList ReverseLLInPlace(LList ll)
        {
            ll.Current = ll.Head;

            Node next;
            Node current = ll.Current;
            Node previous = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            ll.Head = previous;

            return ll;
        }

        // When should I loop until current.Next != null vs. current != null?
        // Looping while current.Next != null results in a lot of repetitive code in this problem...
        static LList ReverseLLWithNext(LList ll)
        {
            ll.Current = ll.Head;

            Node previous = null;
            Node current = ll.Current;
            Node next = current.Next;

            while (current.Next != null)
            {
                current.Next = previous;
                previous = current;
                current = next;
                next = current.Next;
            }

            if (current.Next == null)
            {
                current.Next = previous;
                previous = current;
                current = next;
            }

            ll.Head = previous;

            return ll;
        }
    }
}
