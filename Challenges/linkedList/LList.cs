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
        /// Adding a node at the beginning is O(n)_
        /// </summary>
        /// <param name="node"></param>
        public void Add(Node node)
        {
            node.Next = Head;
            Head = node;
            Current = Head;
        }

        // we have to traverse the LL in order to print, so it's linear time. O(n).
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
    }
}
