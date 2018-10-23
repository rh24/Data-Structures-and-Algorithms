# Queue with Stacks

In a custom Queue class, mimic the behavior of a queue data structure using 2 stacks. The stacks will be properties set on the `CustomQueue` class. Within this class, there should be an `Enqueue(value)` and a `Dequeue()` method that mimic those of a FIFO data structure, but utilize two underlying stacks that may implement the `Pop()` and `Push()` methods.

Since stacks are a LIFO data structure, one stack must hold all the nodes while the other will be empty. This is so that when values are 'enqueued', they will be pushed onto the stack holding the nodes, but when a node is 'dequeued' all the nodes will be popped off the holding stack, and then, they will be pushed onto the empty stack for temporary holding. The last value in the stack will be popped off and returned by the dequeue method. Afterwards, the nodes will be poppped off the temporary holding stack and pushed back onto the original stack from which they came. Since is the first node in the stack, it is like the first node in the custom queue.

## Big O

>`Enqueue(value)`

* Space complexity: O(1) because we're not allocating new memory. We are only adjusting pointers of existing objects in the heap.
* Time complexity: O(1)

>`Dequeue()`

* Space complexity: O(1)
* Time complexity: O(n)

## Whiteboard Solution

![queue_with_stacks](https://github.com/rh24/Data-Structures-and-Algorithms/blob/queue-with-stacks/assets/QueueWithStacks.jpg)
