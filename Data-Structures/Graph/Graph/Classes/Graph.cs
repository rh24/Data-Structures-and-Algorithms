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

        /// <summary>
        /// This method adds an edge with a weight to the graph between two vertices.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        public void AddEdge(Node parent, Tuple<Node, int> child)
        {
            foreach (var item in AdjacencyList)
            {
                var node = item.First.Value.Item1;
                var edge = item.First.Value.Item2;
            }
        }

        /// <summary>
        /// This method adds a node to the graph, but it does not add an edge to the graph.
        /// </summary>
        /// <param name="node"></param>
        public void AddVertex(Node node)
        {

        }

        public void GetNodes()
        {

        }

        public LinkedList<Tuple<Node, int>> GetNeighbors(Node node)
        {

        }

        public int Size()
        {

        }
    }
}
