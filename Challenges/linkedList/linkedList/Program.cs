﻿using System;
using System.Collections.Generic;
using LinkList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate some Node objects
            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            // Instantiate a new LL
            LList ll = new LList(node0);


            ll.Add(node0);
            ll.Add(node1);
            ll.Add(node2);

            ll.Print();

            //// Make a generic list of Node obecjts to add in a foreach loop
            //var nodes = new List<Node> { node0, node1, node2, node3, node4 };

            ////Add each node in collection to LL
            //foreach (var node in nodes)
            //{
            //    ll.Add(node);
            //}

            ////Console.WriteLine(ll.Find(node0).Value);
            //Console.WriteLine(FindKthFromLast(0, ll));
            //Console.ReadLine();
        }

        static int FindKthFromLast(int k, LList ll)
        {
            ll.Current = ll.Head;

            // First instatiate a counter variable that will represent the number of nodes in LL
            int counter = 0;

            // Traverse the entire linked list to increment counter
            while (ll.Current.Next != null)
            {
                ll.Current = ll.Current.Next;
                counter++;
            }

            // Need to reset my Current pointer to the Head of LL
            ll.Current = ll.Head;

            // Loop through the LL again while counter > k? or counter >= k?
            while (counter > k)
            {
                ll.Current = ll.Current.Next;
                counter--;
            }

            return ll.Current.Value;
        }
    }
}
