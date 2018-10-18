using System;
using Xunit;
using LinkList.Classes;
using LLKth;

namespace LLKthTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData("aren't that many nodes", 7)]
        [InlineData("can't be negative", -2)]
        [InlineData(3, 3)]
        public void TestKthFromLast(object expected, int kth)
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
            ll.Add(node3);

            Assert.Equal(expected, Program.FindKthFromLast(kth, ll));
            //Assert.Equal(expected, Program.FindKthFromLast(kth, ll));
            //Assert.Equal(expected, Program.FindKthFromLast(kth, ll));
        }
    }
}
