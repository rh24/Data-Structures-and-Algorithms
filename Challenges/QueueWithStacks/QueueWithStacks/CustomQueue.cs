using System;
using System.Text;
using StackAndQueue.Classes;

namespace QueueWithStacks
{
    public class CustomQueue
    {
        public Stack StackOne { get; set; }
        public Stack StackTwo { get; set; }

        public CustomQueue()
        {
            StackOne = new Stack(new Node(0));
            StackTwo = new Stack(new Node(0));
        }
    }
}
