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
            List<Node> testNodes = bt.PreOrder(node0, nodes);

            // preorder print of values
            IEnumerable<int> vals = new List<int>() { 0, 4, 1, 2, 3, 5 };
            IEnumerable<int> nodeVals = testNodes.Select(n => (int)n.Value);
            Assert.Equal(vals, nodeVals);
            Assert.Equal(0, bt.Root.Value);
            Assert.Equal(4, bt.Root.LeftChild.Value);
        }

        /// <summary>
        /// Test in order traverses left, root, right.
        /// </summary>
        [Fact]
        public void TestInOrder()
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

            List<Node> testNodes = bt.InOrder(node0, nodes);

            // inorder print of values
            IEnumerable<int> vals = new List<int>() { 4, 0, 2, 3, 1, 5 };
            IEnumerable<int> nodeVals = testNodes.Select(n => (int)n.Value);
            Assert.Equal(vals, nodeVals);
            Assert.Equal(0, bt.Root.Value);
            Assert.Equal(4, bt.Root.LeftChild.Value);
        }

        /// <summary>
        /// Test post order traverses left, right, root.
        /// </summary>
        [Fact]
        public void TestPostOrder()
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

            List<Node> testNodes = bt.PostOrder(node0, nodes);

            // inorder print of values
            IEnumerable<int> vals = new List<int>() { 4, 2, 3, 1, 5, 0 };
            IEnumerable<int> nodeVals = testNodes.Select(n => (int)n.Value);
            Assert.Equal(vals, nodeVals);
            Assert.Equal(0, bt.Root.Value);
            Assert.Equal(4, bt.Root.LeftChild.Value);
        }

        /// <summary>
        /// Test that new node adds to BST in ordered place. Test BST Search method does not find non existent nodes and finds values of existing nodes in the tree.
        /// </summary>
        [Fact]
        public void AddToBSTAndSearch()
        {
            List<Node> nodes = new List<Node>();
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            BinarySearchTree bst = new BinarySearchTree(node4);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node5 = new Node(5);
            node4.LeftChild = node2;
            node4.RightChild = node5;
            node2.LeftChild = node1;
            node2.RightChild = node3;

            /* BEFORE ADD:
              
                 4
               /   \
              2     5
             / \
            1   3
         
             */

            /* AFTER ADD:

                 4
               /   \
              2     5
             / \     \
            1   3     7

             */

            Node nodeToAdd = new Node(7);

            bool added = bst.Add(nodeToAdd);

            Assert.True(added);
            Assert.Equal(4, bst.Root.Value);
            Assert.Equal(5, bst.Search(5).Value);
            Assert.Equal(7, bst.Search(7).Value);
            Assert.IsType<Node>(bst.Search(7));
            Assert.IsType<Node>(bst.Search(4));
            Assert.Null(bst.Search(10));
        }
    }
}
