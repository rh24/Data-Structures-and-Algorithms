using System;
using LinkList.Classes;
using System.Collections.Generic;

namespace LLKth
{
    public class Program
    {

        static void Main(string[] args)
        {
            // Instantiate some Node objects
            Node node4 = new Node(4);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            LList ll = new LList(node1);

            ll.Add(node2);
            ll.Add(node4);

            Console.WriteLine(FindKthFromLast(2, ll));
        }

        public static dynamic FindKthFromLast(int k, LList ll)
        {
            //ll.Current = ll.Head;

            if (k < 0) return "can't be negative";

            // First instatiate a counter variable that will represent the number of nodes in LL
            int counter = 0;

            // Traverse the entire linked list to increment counter
            while (ll.Current.Next != null)
            {
                counter++;
                ll.Current = ll.Current.Next;
            }

            // Need to reset my Current pointer to the Head of LL
            ll.Current = ll.Head;

            if (k > counter) return "aren't that many nodes";

            // Loop through the LL again while counter > k
            while (counter > k)
            {
                ll.Current = ll.Current.Next;
                counter--;
            }

            return ll.Current.Value;
        }
    }
}
