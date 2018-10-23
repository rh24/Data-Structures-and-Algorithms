using System;
using System.Text;
using StackAndQueue.Classes;

namespace QueueWithStacks
{
    public class CustomQueue
    {
        // StackOne will temporarily hold the nodes when it's time to "dequeue"
        public Stack StackOne { get; set; }

        // StackTwo will hold the nodes like a "queue"
        public Stack StackTwo { get; set; }

        public CustomQueue()
        {
            StackOne = new Stack(new Node(0));
            StackTwo = new Stack(new Node(0));
        }

        public void Enqueue(Node value)
        {
            StackTwo.Push(value);
        }

        public Node Dequeue()
        {
            Node dq;

            // Change algorithm to pop until the next is not null because Stack must be instantiated with a node that is technically not a part of our dataset.
            while (StackTwo.Peek().Next != null)
            {
                StackOne.Push(StackTwo.Pop());
            }

            dq = StackOne.Pop();

            while (StackOne.Peek().Next != null)
            {
                StackTwo.Push(StackOne.Pop());
            }

            return dq;
        }
    }
}
