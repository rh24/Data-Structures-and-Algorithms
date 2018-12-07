namespace Graph.Classes
{
    public class Edge
    {
        public Vertex To { get; set; }
        public Vertex From { get; set; }
        public int Weight { get; set; }

        public Edge(Vertex from, Vertex to, int weight)
        {
            To = to;
            From = from;
            Weight = weight;
        }
    }
}
