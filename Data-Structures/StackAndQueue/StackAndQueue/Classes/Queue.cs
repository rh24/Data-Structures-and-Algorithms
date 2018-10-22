using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        public Node Peek()
        {
            return Front;
        }

        // Add node to end of queue
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        // Remove node from first in queue
        // Set your pointers equal to null so the unused objects can be GC'ed.
        public Node Dequeue()
        {
            Node pointer = Peek();
            Front = Front.Next;
            pointer.Next = null;
            return pointer;
        }
    }
}
