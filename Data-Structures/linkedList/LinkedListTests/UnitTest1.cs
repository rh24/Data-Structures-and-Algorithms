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

        // print append addbefore add after
        [Fact]
        public void
    }
}
