using System;
using Xunit;
using LinkList.Classes;
using static LLKth.Program;
using static LLMergeTwo.Program;

namespace LLMergeTwoTests
{
    public class UnitTest1
    {
        // Set up LL1
        public static LList l1 = new LList(new Node("lastNode1"));

        // Set up LL2
        public static LList l2 = new LList(new Node("lastNode2"));

        /// <summary>
        /// Test lists of equal number of nodes. Test that last node value is "lastNode2."
        /// </summary>
        [Fact]
        public void Test1()
        {
            Node node0 = new Node("third");
            Node node1 = new Node("world");
            Node node2 = new Node("hello");
            Node node4 = new Node("goodnight");
            Node node5 = new Node("and stars");

            l1.Add(node0);
            l1.Add(node2);

            l2.Add(node5);
            l2.Add(node4);

            LList mergedList = MergeTwoLL(l1, l2);

            Node lastNode = FindLast(mergedList);
            string lastStringValue = lastNode.Value.ToString();
            Assert.Equal("lastNode2", lastStringValue);
        }

        [Fact]
        public void TestValueOfListsOfDifferentLength()
        {
            Node node0 = new Node("third");
            Node node1 = new Node("world");
            Node node2 = new Node("hello");
            Node node3 = new Node("moon");
            Node node4 = new Node("goodnight");
            Node node5 = new Node("and stars");

            l1.Add(node0);
            l1.Add(node2);
            l1.Add(node3);

            l2.Add(node5);
            l2.Add(node4);

            LList mergedList = MergeTwoLL(l1, l2);

            Node lastNode = FindLast(mergedList);
            string lastStringValue = lastNode.Value.ToString();
            Assert.Equal("lastNode2", lastStringValue);
        }
    }
}
