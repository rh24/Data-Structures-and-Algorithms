using System;
using LinkList.Classes;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            LList ll = new LList(node1);

            ll.Add(node2);

            ll.Print();
        }
    }
}
