using System;
using Xunit;
using LinkList.Classes;
using LLKth;

namespace LLKthTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestKthFromLast()
        {
            // Instantiate some Node objects
            Node node0 = new Node(0);
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            // Instantiate a new LL
            LList ll = new LList(node0);

            ll.Add(node1);
            ll.Add(node2);

            Assert.Equal(0, Program.FindKthFromLast(0, ll));
        }
    }
}
