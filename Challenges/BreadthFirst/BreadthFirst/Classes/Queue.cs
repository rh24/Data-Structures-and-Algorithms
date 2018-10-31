using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirst.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public int Size { get; set; }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

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

        public Node Dequeue()
        {
            Node temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }

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
