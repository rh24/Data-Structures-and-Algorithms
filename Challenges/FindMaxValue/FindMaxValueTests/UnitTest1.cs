using System;
using Xunit;
using Trees.Classes;
using static FindMaxValue.Program;

namespace FindMaxValueTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test that FindMaxFromBT returns correct max val of nodes in the binary tree.
        /// </summary>
        [Fact]
        public void FindMaxTest()
        {
            Node node = new Node(0);
            BinaryTree bt = new BinaryTree(node);

            Node node5 = new Node(5);
            Node node15 = new Node(15);
            Node node3 = new Node(3);
            Node node6 = new Node(6);
            Node node7 = new Node(7);

            node.LeftChild = node5;
            node.RightChild = node15;
            node15.LeftChild = node3;
            node15.RightChild = node7;
            node5.RightChild = node6;

            Assert.Equal(15, FindMaxFromBT(bt));
            Assert.IsType<int>(FindMaxFromBT(bt));

            node5.LeftChild = new Node(55);

            Assert.Equal(55, FindMaxFromBT(bt));
        }
    }
}
