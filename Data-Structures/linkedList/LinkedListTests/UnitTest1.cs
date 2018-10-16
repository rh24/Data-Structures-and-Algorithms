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
        /// Test Add and Find
        /// </summary>
        [Fact]
        public void AddAndFind()
        {
            Node newNode = new Node(0);
            ll.Add(newNode);
            Assert.Equal(0, ll.Find(newNode).Value);
        }

        //// print append addbefore add after
        //[Fact]
        //public void TestAddAfter()
        //{
        //    Node newNode = new Node(4);
        //    Node existingNode = new Node(3);
        //    // 3, 0, 1
        //    ll.Add(existingNode);
        //    // 3, 4, 0, 1
        //    ll.AddAfter(existingNode, newNode);
        //    Assert.Equal(0, newNode.Next.Value);
        //}

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
