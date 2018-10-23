﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        public

        public Stack(Node node)
        {
            Top = node;
        }

        public Node Peek()
        {
            // implement a try-catch here to prevent null exception
            try
            {
                return Top;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Node Pop()
        {
            Node pointer = Peek();
            Top = Top.Next;
            pointer.Next = null;
            return pointer;
        }

        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }
    }
}
