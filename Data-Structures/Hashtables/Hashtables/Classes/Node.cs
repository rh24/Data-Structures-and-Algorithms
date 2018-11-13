using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables
{
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }
        public object Key { get; set; }

        public Node(object value)
        {
            Value = value;
        }
    }
}
