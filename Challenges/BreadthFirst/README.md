# Breadth-First

Given a binary tree, create a method that takes in the binary tree as an input. Write an algorithm that prints out the value of each node in breadth-first order. Since it is exceedingly difficult to test methods that use `Console.WriteLine()`, the proposed solution accepts a generic `List<T>` collection of `Node` objects. This list will be instantiated for testing purposes outside of the created method and will be the method's return value.

This solution for breadth-first traversal starts by instatiating a Queue with the root of the BT set as the Front & Rear of the queue. Next, while there are still left and right children of the root in the queue, dequeue a node, add it to the `List<Node>` and enqueue its left and right children.

Lastly, return the list of nodes. Print the list of nodes in a separate static method in the `Program.cs` by calling the `PrintBreadthFirst` method in the `Main` method of `Program.cs`.

## Big O

* Time complexity: O(n) because the method will traverse ecah node in the BT
* Space complexity: O(n) because this method creates a new Queue in order to traverse the BT and keep track of the nodes by enqueuing and dequeuing nodes.

## Whiteboard Solution

