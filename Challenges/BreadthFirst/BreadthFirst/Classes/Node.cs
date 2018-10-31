using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstChallenge.Classes
{
    public class Node
    {
        // Node instance properties
        public object Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public Node Next { get; set; }

        // Node class constructor
        public Node(object val)
        {
            Value = val;
        }
    }
}
