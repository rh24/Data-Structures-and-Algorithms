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
            //Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            // Instantiate a new LL
            LList ll = new LList(node1);


            ///ll.Add(node0);
            ll.Add(node1);
            ll.Add(node2);
            ll.Add(node3);

            //ll.Print();

            //Console.WriteLine(ll.Find(node0).Value);
            Console.WriteLine(FindKthFromLast(7, ll));
            Console.ReadLine();
        }

        public static dynamic FindKthFromLast(int k, LList ll)
        {
            //ll.Current = ll.Head;

            if (k < 0) return "can't be negtive";

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
