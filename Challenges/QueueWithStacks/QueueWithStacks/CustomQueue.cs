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

        /// <summary>
        /// Custom constructor instantiates 2 stacks. Stack must be instantiated with a node.
        /// </summary>
        public CustomQueue()
        {
            StackOne = new Stack(new Node(0));
            StackTwo = new Stack(new Node(0));
        }

        /// <summary>
        /// This method mimics the Enqueue method of a Queue by pushing a node onto StackTwo. The pushed node on the stack is the next one that has "queued."
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(Node value)
        {
            StackTwo.Push(value);
        }

        /// <summary>
        /// This method mimics the dequeue action of a Queue data structure by popping nodes off my StackTwo onto my StackOne until the last one pushed onto StackOne is the "dequeued" node I am looking to return.
        /// </summary>
        /// <returns>Dequeued node that was "first one" in StackTwo</returns>
        public Node Dequeue()
        {
            Node dq;

            // Change algorithm to pop until the next is not null because Stack must be instantiated with a node that is technically not a part of our dataset. All that's left in StackTwo will be the node with .Value == 0 that StackTwo was originally instantiated with.
            while (StackTwo.Peek().Next != null)
            {
                StackOne.Push(StackTwo.Pop());
            }

            // The node that we want that is "first one in the queue" is the last one that was pushed onto Stackone.
            dq = StackOne.Pop();

            while (StackOne.Peek().Next != null)
            {
                StackTwo.Push(StackOne.Pop());
            }

            return dq;
        }

        /// <summary>
        /// Counts the nodes in StackOne
        /// </summary>
        /// <returns>integer size of StackOne</returns>
        public int ReturnSizeOfStackOne()
        {
            int count = 0;
            Node temp = StackOne.Peek().Next;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }

        /// <summary>
        /// Counts the nodes in StackTwo
        /// </summary>
        /// <returns>integer size of StackTwo</returns>
        public int ReturnSizeOfStackTwo()
        {
            int count = 0;
            Node temp = StackTwo.Peek().Next;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }
    }
}
