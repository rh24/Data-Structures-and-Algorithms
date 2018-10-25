using System;
using StackAndQueue.Classes;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(new Node(0));
            Console.WriteLine(stack.Size);
            stack.Push(new Node(0));
            Console.WriteLine(stack.Size);
        }
    }
}
