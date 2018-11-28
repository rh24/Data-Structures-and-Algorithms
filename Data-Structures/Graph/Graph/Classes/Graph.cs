﻿using System;
using System.Collections.Generic;

namespace Graph.Classes
{
    public class Graph
    {
        public List<Tuple<Node, string>> AdjacencyList { get; set; }

        public Graph()
        {
            AdjacencyList = new List<Tuple<Node, string>>();
        }

        /// <summary>
        /// This method adds an edge with a weight to the graph between two vertices.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="child"></param>
        public void AddEdge(Tuple<Node, string> parent, Tuple<Node, string> child)
        {
            foreach (var item in AdjacencyList)
            {
                var node = item.Item1;
                var edge = item.Item2;
            }
        }

        /// <summary>
        /// This method adds a node to the graph, but it does not add an edge to the graph.
        /// </summary>
        /// <param name="node"></param>
        public void AddVertex(Node node)
        {
            List<Tuple<Node, string>> newList = new List<Tuple<Node, string>>();
            AdjacencyList.Add(new Tuple<Node, string>(node, node.Value));
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
