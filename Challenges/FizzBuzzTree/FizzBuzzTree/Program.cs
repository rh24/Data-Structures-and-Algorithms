using System;
using Trees.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node node = new Node(0);
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

            FizzBuzz(node);
        }

        public static void FizzBuzz(Node node)
        {
            if (node == null) return;

            // Edge case is if node value is 0, print 0
            if ((int)node.Value == 0) Console.WriteLine(0);
            else if ((int)node.Value % 15 == 0) Console.WriteLine("FizzBuzz");
            else if ((int)node.Value % 3 == 0) Console.WriteLine("Fizz");
            else if ((int)node.Value % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(node.Value);

            FizzBuzz(node.LeftChild);
            FizzBuzz(node.RightChild);
        }
    }
}
