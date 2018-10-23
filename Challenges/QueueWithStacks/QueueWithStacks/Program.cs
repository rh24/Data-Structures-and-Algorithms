using System;
using StackAndQueue.Classes;
using static QueueWithStacks.CustomQueue;

namespace QueueWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            CustomQueue queue = QueueWithStacks();

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            // StackTwo holds the enqueued nodes
            Node temp = queue.StackTwo.Peek();

            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }

            Console.WriteLine($"StackOne size: {queue.ReturnSizeOfStackOne()} // StackTwo size: {queue.ReturnSizeOfStackTwo()}");

            // OUTPUT:
            // 3 (Third "Enqueued" node)
            // 2 (Second "Enqueued" node)
            // 1 (First "Enqueued" node)
            // 0 (The first instantiated default node for the StackTwo property)
        }

        static CustomQueue QueueWithStacks()
        {
            return new CustomQueue();
        }
    }
}
