using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.Classes;

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

            // Make a generic list of Node obecjts to add in a foreach loop
            var nodes = new List<Node> { node0, node1, node2, node3, node4 };

            // Add each node in collection to LL
            foreach (var node in nodes)
            {
                ll.Add(node);
            }

            Console.WriteLine(ll.Find(node0).Value);


        }

        static void FindKthFromlast(int k)
        {
            Console.WriteLine(FindKthFromLast(k));
        }
    }
}
