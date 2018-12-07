using System.Collections.Generic;

namespace Graph.Classes
{
    public class Graph
    {
        public Dictionary<Vertex, List<Vertex>> AdjacencyList { get; set; }
        public List<Edge> Edges { get; set; }

        /// <summary>
        /// Instantiate and a dictionary and a list of edges and set the props of the Graph object.
        /// </summary>
        public Graph()
        {
            AdjacencyList = new Dictionary<Vertex, List<Vertex>>();
            Edges = new List<Edge>();
        }

        /// <summary>
        /// This method adds an edge with a weight to the graph between two vertices.
        /// </summary>
        /// <param name="from">The starting vertex from which to add the edge</param>
        /// <param name="to">The ending vertex to which the edge is added</param>
        public void AddEdge(Vertex from, Vertex to, int weight)
        {
            Edges.Add(new Edge(from, to, weight));
            AdjacencyList[from].Add(to);
        }

        /// <summary>
        /// This method adds a node to the graph, but it does not add an edge to the graph.
        /// </summary>
        /// <param name="vertex">Vertex to add</param>
        public void AddNode(Vertex vertex)
        {
            AdjacencyList.Add(vertex, new List<Vertex>());
        }

        /// <summary>
        /// This method returns all the vertices in the graph.
        /// </summary>
        /// <returns>List of vertices</returns>
        public List<Vertex> GetNodes()
        {
            return new List<Vertex>(AdjacencyList.Keys);
        }

        /// <summary>
        /// This method gets all the neighbors of a vertex in the graph.
        /// </summary>
        /// <param name="vertex">Vertex whose neighbors will be returned</param>
        /// <returns>List of vertices that are connected by an edge to the input vertex</returns>
        public List<Vertex> GetNeighbors(Vertex vertex)
        {
            return AdjacencyList[vertex];
        }

        /// <summary>
        /// This method returns the number of vertices in the graph.
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return AdjacencyList.Count;
        }
    }
}
