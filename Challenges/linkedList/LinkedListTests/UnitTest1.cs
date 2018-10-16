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
        /// Test Find and Add
        /// </summary>
        [Fact]
        public void TestAddAndFind()
        {
            Node existing = new Node(0);
            ll.Add(existing);
            Assert.Equal(0, ll.Find(existing).Value);
        }

        [Fact]
        public void TestPrint()
        {

        }

    }
}
