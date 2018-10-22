using System;
using Xunit;
using LinkList.Classes;
using static LLKth.Program;
using static LLReverse.Program;
using System.Collections.Generic;

namespace LLReverseTests
{
    public class LLReverseUnitTests
    {

        public static LList ll = new LList(new Node(0));

        public static Node node1 = new Node(1);
        public static Node node2 = new Node(2);
        public static Node node3 = new Node(3);
        public static Node node4 = new Node(4);

        public static List<Node> nodes = new List<Node>() { node1, node2, node3, node4 };

        /// <summary>
        /// 4 -->
        /// 3 -->
        /// 2 -->
        /// 1 -->
        /// 0 --> NULL
        /// --------- now, reverse it: ------------
        /// 0 -->
        /// 1 -->
        /// 2 -->
        /// 3 -->
        /// 4 --> NULL
        /// 
        /// In the ReverseLLInPlace method, the Head of the LL is set to the previous Node in the method, meaning that in order to print the LL backwards, the head is now 0, where originally it was 4. Test that the head of the newly reversed LL is 0. Test its subsequent values.
        /// </summary>
        [Fact]
        public void TestReverseLL()
        {
            foreach (var node in nodes)
            {
                ll.Add(node);
            }

            LList reversed = ReverseLLInPlace(ll);
            Node newHead = reversed.Head;

            Assert.Equal(0, newHead.Value);
            Assert.Equal(1, newHead.Next.Value);
            Assert.Equal(2, newHead.Next.Next.Value);
        }
    }
}
