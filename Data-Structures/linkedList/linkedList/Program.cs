using System;
using LinkList.Classes;

namespace LinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Node node = new Node(1);
            LList ll = new LList(node);
        }
    }
}
