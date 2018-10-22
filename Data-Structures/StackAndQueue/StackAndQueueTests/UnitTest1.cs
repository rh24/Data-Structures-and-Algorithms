using System;
using Xunit;
using StackAndQueue.Classes;

namespace StackAndQueueTests
{
    public class UnitTest1
    {
        public Stack stack = new Stack(new Node(0));
        public Queue queue = new Queue(new Node(0));

        /// <summary>
        /// Test pushing a node onto the stack.
        /// </summary>
        [Fact]
        public void PushNodeOntoStack()
        {
            stack.Push(new Node(1));
            object currentTopNodeValue = stack.Peek().Value;
            Assert.Equal(1, currentTopNodeValue);
        }
    }
}
