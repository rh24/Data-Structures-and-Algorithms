using System;
using Xunit;
using StackAndQueue.Classes;
using QueueWithStacks;
using System.Collections.Generic;

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
        /// 0 (The first instantiated default node for the Output property)
        /// </summary>
        [Fact]
        public void TestEnqueue()
        {

            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);

            CustomQueue queue = Program.QueueWithStacks();

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            // Output holds the enqueued nodes
            int sizeOfStackTwo = queue.ReturnSizeOfStackTwo();
            int sizeOfStackOne = queue.ReturnSizeOfStackOne();

            Assert.Equal(3, sizeOfStackTwo);
            Assert.Equal(0, sizeOfStackOne);

            queue.Enqueue(node4);
            int newSizeOfStackTwo = queue.ReturnSizeOfStackTwo();
            Assert.Equal(4, newSizeOfStackTwo);
        }

        /// <summary>
        /// Test the Dequeue method for the CustomQueue class. Add nodes to set up the custom queue instance. Dequeue and test original size vs. new size. Check that the first dequeued node was the first to be added, and so on.
        /// </summary>
        [Fact]
        public void TestDequeue()
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);

            CustomQueue queue = Program.QueueWithStacks();

            List<Node> nodes = new List<Node>() { node1, node2, node3, node4, node5, node6 };

            foreach (var node in nodes)
            {
                queue.Enqueue(node);
            }

            int originalSizeOfQueue = queue.ReturnSizeOfStackTwo();

            Node firstDequeued = queue.Dequeue();
            Node secondDequeued = queue.Dequeue();
            Node thirdDequeued = queue.Dequeue();

            int newSizeOfQueue = queue.ReturnSizeOfStackTwo();

            Assert.Equal(node1, firstDequeued);
            Assert.Equal(node2, secondDequeued);
            Assert.Equal(node3, thirdDequeued);
            Assert.Equal(6, originalSizeOfQueue);
            Assert.Equal(3, newSizeOfQueue);
        }
    }
}
