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

        /// <summary>
        /// Test popping a node off the stack. Stacks operate as LIFO data structures. The last pushed node's value is 2. This means that the first popped off node's value will be 2.
        /// </summary>
        [Fact]
        public void PopNodeOffStack()
        {
            stack.Push(new Node(1));
            stack.Push(new Node(2));

            object poppedOffValue = stack.Pop().Value;
            Assert.Equal(2, poppedOffValue);

            object secondPoppedOffValue = stack.Pop().Value;
            Assert.Equal(1, secondPoppedOffValue);
        }

        /// <summary>
        /// Test peeking at Top node of stack. The Top node should be the last node pushed onto the stack.
        /// </summary>
        [Fact]
        public void PeekAtTopNodeOfStack()
        {
            stack.Push(new Node(1));
            stack.Push(new Node(2));
            stack.Push(new Node(3));

            object peekTopNodeValue = stack.Peek().Value;
            Assert.Equal(3, peekTopNodeValue);
        }
    }
}
