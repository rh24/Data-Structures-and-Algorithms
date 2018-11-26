using System;
using System.Collections.Generic;

namespace Graph.Classes
{
    public class Graph
    {
        public LinkedList<LinkedList<Tuple<Node, string>>> AdjacencyList { get; set; }

        public Graph()
        {
            AdjacencyList = new LinkedList<LinkedList<Tuple<Node, string>>>();
        }
    }
}
