using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
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
            Head = head;
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
        public bool Print()
        {
            try
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
            catch (Exception)
            {
                throw;
            }

            return true;
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
            //Current = Head;

            while (Current.Next != null)
            {
                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next.Next;
                    Current.Next = existingNode;
                }

                Current = Current.Next;
            }

            //Node whereToAddAfter = Find(existingNode);
            //newNode.Next = Current.Next.Next;
            //Current.Next = newNode;
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

        public int FindKthFromLast(int k)
        {
            Current = Head;

            // First instatiate a counter variable that will represent the number of nodes in LL
            int counter = 0;

            // Traverse the entire linked list to increment counter
            while (Current.Next != null)
            {
                Current = Current.Next;
                counter++;
            }

            // Need to reset my Current pointer to the Head of LL
            Current = Head;

            // Loop through the LL again while counter > k? or counter >= k?
            while (counter > k)
            {
                Current = Current.Next;
                counter--;
            }

            return Current.Value;
        }
    }
}
