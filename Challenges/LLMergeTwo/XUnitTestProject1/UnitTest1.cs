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
        public static LList ll = new LList(new Node(0));

        // Set up LL2
        public static LList ll2 = new LList(new Node(1));

        /// <summary>
        /// Test merging lists with unequal number of nodes. Test that last node value is 0.
        /// 4 -->
        /// 3 -->
        /// 2 -->
        /// 1 -->
        /// 0 --> NULL
        /// </summary>
        [Fact]
        public void TestListsOfDifferentLengths()
        {
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            ll.Add(node2);
            ll.Add(node4);

            ll2.Add(node3);

            LList mergedList = MergeTwoLL(ll, ll2);

            Node lastNode = FindLast(mergedList);
            int lastNodeValue = (int)lastNode.Value;
            Assert.Equal(0, lastNodeValue);
        }


        /// <summary>
        /// Test merging lists with equal number of nodes.
        /// 3 -->
        /// 2 -->
        /// 0 --> NULL
        /// 1 -->
        /// </summary>
        [Fact]
        public void MergeListsOfSameLength()
        {
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            ll.Add(node2);

            ll2.Add(node3);

            LList mergedList = MergeTwoLL(ll, ll2);
            Assert.Equal(1, FindKthFromLast(0, mergedList));
        }

        /// <summary>
        /// 2 -->
        /// 3 -->
        /// 0 -->
        /// 1 --> NULL
        /// </summary>
        [Fact]
        public void FindKthForListsOfSameLength()
        {
            Node node2 = new Node(2);
            Node node3 = new Node(3);

            ll.Add(node2);

            ll2.Add(node3);

            LList mergedList = MergeTwoLL(ll, ll2);
            Assert.Equal(0, FindKthFromLast(1, mergedList));
        }
    }
}
