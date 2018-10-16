using System;
using Xunit;
using linkedList.Classes;

namespace LinkedListTests
{
    public class UnitTest1
    {
        public static Node node = new Node(1);
        public static LList ll = new LList(node);

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
