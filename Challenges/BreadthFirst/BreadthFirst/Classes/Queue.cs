using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstChallenge.Classes
{
    public class Queue
    {
        // Queue instance properties
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public int Size { get; set; }

        /// <summary>
        /// Queue class constructor that sets the Front and Rear to the node with which the queue is instantiated
        /// </summary>
        /// <param name="node"></param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// This method peeks at the Front of the queue.
        /// </summary>
        /// <returns>Front property of queue, which is a Node object</returns>
        public Node Peek()
        {
            try
            {
                return Front;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Enqueue will check if the node is not null in a conditional in order to avoid executing a try-catch. This is common error that can be handled without a try-catch.
        /// </summary>
        /// <param name="node">Node object to add to queue</param>
        /// <returns>true if successful, false if node is null</returns>
        public bool Enqueue(Node node)
        {
            if (node != null)
            {
                Rear.Next = node;
                Rear = Rear.Next;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method removes the Front node from the queue.
        /// </summary>
        /// <returns>Node that was removed from queue</returns>
        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }

        /// <summary>
        /// This method returns the size of the queue.
        /// </summary>
        /// <returns>number nodes in queue</returns>
        public int Count()
        {
            Node pointer = Front;
            int count = 0;

            while (pointer != null)
            {
                count++;
                pointer = pointer.Next;
            }

            return Size = count;
        }
    }
}
