using System.Collections.Generic;
using Trees.Classes;
using Xunit;
using static TreeIntersection.Program;

namespace TreeIntersectionTests
{
    public class UnitTest1
    {
        /// <summary>
        /* BT1 and BT2 are nearly identical. Therefore, every single one of its values should be printed to the console except for 3 and 7.

        BT1:
                 4
               /   \
              2     5
             / \
            1   3

            BT2:
                 4
               /   \
              2     5
             / \
            1   7
         
        */
        /// </summary>
        [Fact]
        public void Test1()
        {
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            BinaryTree bt1 = new BinaryTree(node4);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node5 = new Node(5);
            node4.LeftChild = node2;
            node4.RightChild = node5;
            node2.LeftChild = node1;
            node2.RightChild = node3;

            Node bt2node7 = new Node(7);
            Node bt2node4 = new Node(4);
            BinaryTree bt2 = new BinaryTree(bt2node4);
            Node bt2node1 = new Node(1);
            Node bt2node2 = new Node(2);
            Node bt2node5 = new Node(5);
            bt2node4.LeftChild = bt2node2;
            bt2node4.RightChild = bt2node5;
            bt2node2.LeftChild = bt2node1;
            bt2node2.RightChild = bt2node7;

            List<object> overlapping = TreeIntersections(bt1, bt2);
            List<object> expectedValues = new List<object>() { 4, 2, 1, 5 };
            Assert.Equal(overlapping, expectedValues);
        }
    }
}
