using System;
using Xunit;
using LinkedList.Classes;
using System.Collections.Generic;

namespace LinkedListTests
{
    public class UnitTest1
    {
        public static Node node = new Node(1);
        public static LList ll = new LList(node);

        [Fact]
        public void TestFindKthFromEnd()
        {
            /* This only passes if I run it in isolation
            // Instantiate some Node objects
            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            //// Instantiate a new LL
            //LList ll = new LList(node0);

            // Make a generic list of Node obecjts to add in a foreach loop
            var nodes = new List<Node> { node0, node1, node2, node3, node4 };

            // Add each node in collection to LL
            foreach (var node in nodes)
            {
                ll.Add(node);
            }
            */

            Assert.Equal(1, ll.FindKthFromLast(0));
        }

        /// <summary>
        /// Test All adding methods and Find
        /// </summary>
        [Fact]
        public void AddAndFind()
        {
            Node newNode = new Node(0);
            ll.Add(newNode);
            Assert.Equal(0, ll.Find(newNode).Value);

            // Test AddBefore
            Node addNode = new Node(5);
            ll.AddBefore(addNode, newNode);
            Assert.Equal(addNode.Next, newNode);

            // ll looks like => 5, 0, 1

            Node nodeToAdd = new Node(7);
            //Test AddAfter
            ll.AddAfter(nodeToAdd, newNode.Next);
            // 5, 0, 1, 7
            Assert.Null(nodeToAdd.Next);
            Assert.Equal(1, newNode.Next.Value);
        }

        /// <summary>
        /// Test print
        /// </summary>
        [Fact]
        public void TestPrint()
        {
            Assert.True(ll.Print());
        }
    }
}
