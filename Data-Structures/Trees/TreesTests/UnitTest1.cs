using System;
using Xunit;
using Trees.Classes;
using System.Collections.Generic;
using System.Linq;

namespace TreesTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test preorder binary tree prints from root, left, right.
        /// </summary>
        [Fact]
        public void TestPreOrder()
        {
            List<Node> nodes = new List<Node>();
            Node node0 = new Node(0);
            BinaryTree bt = new BinaryTree(node0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            node0.RightChild = node1;
            node0.LeftChild = node4;
            node1.LeftChild = node2;
            node1.RightChild = node5;
            node2.RightChild = node3;
            /*

                 0
               /   \
              4     1
             / \
            2   5
             \
              3

             */
            foreach (var node in bt.PreOrder(node0, nodes))
            {
                Console.WriteLine(node.Value);
            }

            // preorder print of values
            IEnumerable<int> vals = new List<int>() { 0, 4, 1, 2, 3, 5 };
            IEnumerable<int> nodeVals = nodes.Select(n => (int)n.Value);
            Assert.Equal(vals, nodeVals);
            Assert.Equal(0, bt.Root.Value);
            Assert.Equal(4, bt.Root.LeftChild.Value);
        }
    }
}
