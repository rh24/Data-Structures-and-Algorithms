using System;
using System.Collections.Generic;

namespace Graph.Classes
{
    public class Graph
    {
        public LinkedList<LinkedList<Tuple<Node, int>>> AdjacencyList { get; set; }
    }
}
