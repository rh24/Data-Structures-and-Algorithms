# Queue with Stacks

In a custom Queue class, mimic the behavior of a queue data structure using 2 stacks. The stacks will be properties set on the `CustomQueue` class. Within this class, there should be an `Enqueue(value)` and a `Dequeue()` method that mimic those of a FIFO data structure, but utilize two underlying stacks that may implement the `Pop()` and `Push()` methods.

Since stacks are a LIFO data structure, one stack must hold all the nodes. When values are 'enqueued', they will be pushed onto the stack holding the nodes. When they are 'dequeued' all the nodes will be popped off the holding stack, and then, they will be pushed onto the empty, temporarily holding stack. The last value in the stack will be popped off and returned by the dequeue method. Since is the first node in the stack, it is like the first node in the custom queue.

## Big O



## Whiteboard Solution

![queue_with_stacks](https://github.com/rh24/Data-Structures-and-Algorithms/blob/queue-with-stacks/assets/QueueWithStacks.jpg)