using System;
using System.Collections.Generic;
using System.Text;

namespace linkedList.Classes
{
    public class LList
    {
        /// <summary>
        /// First node in the LL.
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// The node that is used to traverse through the LL.
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// LL requires a node at time tof creation to be the head.
        /// </summary>
        /// <param name="head"></param>
        public LList(Node head)
        {
        }

        /// <summary>
        /// Adding a node at the beginning is O(n).
        /// </summary>
        /// <param name="node"></param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        // we have to traverse the LL in order to print, so it's linear time. O(n).
        // O(1) because adding no aditional memory.
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.WriteLine($"{Current.Value} -->");
                Current = Current.Next;
            }

            Console.WriteLine($"{Current.Value} --> NULL");
            Current = Head;
        }

        // O(n) because we have to traverse through entire LL.
        // O(1) because no additional memory.
        public void Append(Node node)
        {
            Current = Head;

            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = node;
            Current = Head;
        }

        // O(n) because we have to traverse the entire LL.
        // O(1) because no additional memory.
        public void AddBefore(Node newNode, Node existingNode)
        {
            Current = Head;

            if (Head.Value == existingNode.Value)
            {
                Add(newNode);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    Current.Next = newNode;
                    newNode.Next = existingNode;
                }

                Current = Current.Next;
            }
        }

        // AddAfter
        public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    Current = Current.Next;
                    Current.Next = newNode;
                }
            }
        }

        // Find => returns a Node
        // O(n) time. O(1) space.
        public Node Find(Node nodeToFind)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == nodeToFind.Value)
                {
                    return Current;
                }

                Current = Current.Next;
            }

            return null;
        }

    }
}
