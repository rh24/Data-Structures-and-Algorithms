using StackAndQueue.Classes;

namespace QueueWithStacks
{
    public class CustomQueue
    {
        // Input will always be pushed nodes when "Enqueue" operation happens
        public Stack Input { get; set; }

        // Output will hold the nodes like a "queue"
        public Stack Output { get; set; }

        /// <summary>
        /// Custom constructor instantiates 2 stacks. One is the Input stack. This is the stack that the Enqueue method will always push nodes onto.
        /// </summary>
        public CustomQueue()
        {
            Input = new Stack(null);
            Output = new Stack(null);
        }

        /// <summary>
        /// This method mimics the Enqueue method of a Queue by pushing a node onto Output. The pushed node on the stack is the next one that has "queued."
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(Node value)
        {
            Output.Push(value);
        }

        /// <summary>
        /// This method mimics the dequeue action of a Queue data structure by popping nodes off my Output onto my Input until the last one pushed onto Input is the "dequeued" node I am looking to return.
        /// </summary>
        /// <returns>Dequeued node that was "first one" in Output</returns>
        public Node Dequeue()
        {
            Node dq;

            // Change algorithm to pop until the next is not null because Stack must be instantiated with a node that is technically not a part of our dataset. All that's left in Output will be the node with .Value == 0 that Output was originally instantiated with.
            while (Output.Peek().Next != null)
            {
                Input.Push(Output.Pop());
            }

            // The node that we want that is "first one in the queue" is the last one that was pushed onto Stackone.
            dq = Input.Pop();

            while (Input.Peek().Next != null)
            {
                Output.Push(Input.Pop());
            }

            return dq;
        }

        /// <summary>
        /// Counts the nodes in Input
        /// </summary>
        /// <returns>integer size of Input</returns>
        public int ReturnSizeOfStackOne()
        {
            int count = 0;
            Node temp = Input.Peek().Next;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }

        /// <summary>
        /// Counts the nodes in Output
        /// </summary>
        /// <returns>integer size of Output</returns>
        public int ReturnSizeOfStackTwo()
        {
            int count = 0;
            Node temp = Output.Peek().Next;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }

            return count;
        }
    }
}
