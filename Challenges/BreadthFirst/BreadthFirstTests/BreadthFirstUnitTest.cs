using Xunit;
using BreadthFirstChallenge.Classes;
using System.Collections.Generic;
using System.Linq;
using static BreadthFirstChallenge.Program;

namespace BreadthFirstTests
{
    public class BreadthFirstUnitTest
    {
        /// <summary>
        /// This method tests breadth first traversal by arranging a binary tree, creating an IEnumerable<int> of numbers that represent the node values in order of breadth-first traversal, and testing whether the root node is as arranged.
        /// </summary>
        [Fact]
        public void TestBreadthFirst()
        {
            // Instantiate list collection that will hold the breadth first nodes of BT
            List<Node> nodesToPrint = new List<Node>();

            // Set up a BT
            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node43 = new Node(43);
            Node node7 = new Node(7);
            Node node15 = new Node(15);
            Node node21 = new Node(21);
            Node node3 = new Node(3);

            node0.LeftChild = node1;
            node0.RightChild = node43;
            node1.LeftChild = node7;
            node1.RightChild = node15;
            node43.LeftChild = node21;
            node43.RightChild = node3;

            /*
            
                    0
                  /   \
                 1     43
                / \    /\
               7  15  21 3

             */

            IEnumerable<int> breadthFirstVals = new List<int>() { 0, 1, 43, 7, 15, 21, 3 };
            IEnumerable<int> nodeVals = BreadthFirst(node0, nodesToPrint).Select(n => (int)n.Value);

            Assert.IsAssignableFrom<IEnumerable<int>>(nodeVals);
            Assert.Equal(0, node0.Value);
            Assert.Equal(breadthFirstVals, nodeVals);
        }
    }
}
