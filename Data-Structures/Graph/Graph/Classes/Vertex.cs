using System.Collections.Generic;

namespace Graph.Classes
{
    public class Vertex
    {
        public string Value { get; set; }
        public List<Vertex> Neighbors { get; set; }
    }
}
