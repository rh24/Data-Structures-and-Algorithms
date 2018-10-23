using System;
using Xunit;
using StackAndQueue.Classes;
using QueueWithStacks;

namespace QueueWithStacksTests
{
    public class UnitTest1
    {
        /// <summary>
        /// OUTPUT:
        /// 4 (Fourth)
        /// 3 (Third "Enqueued" node)
        /// 2 (Second "Enqueued" node)
        /// 1 (First "Enqueued" node)
        /// 0 (The first instantiated default node for the StackTwo property)
        /// </summary>
        [Fact]
        public void TestEnqueue()
        {

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            CustomQueue queue = Program.QueueWithStacks();

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            // StackTwo holds the enqueued nodes
            int sizeOfStackTwo = queue.ReturnSizeOfStackTwo();
            int sizeOfStackOne = queue.ReturnSizeOfStackOne();

            Assert.Equal(3, sizeOfStackTwo);
            Assert.Equal(0, sizeOfStackOne);

            queue.Enqueue(node4);
            int newSizeOfStackTwo = queue.ReturnSizeOfStackTwo();
            Assert.Equal(4, newSizeOfStackTwo);
        }
    }
}
