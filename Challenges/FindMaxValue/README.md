# Find Max Value

Given a binary tree, find the max value.

## Big O

> Space complexity: O(h)

Recursively traversing the tree using Depth-first traversal, in order will result in space complexity being the height of the call stack, which will be the height of the tree.

> Time complexity: O(n)

Worst case, we'll have to check every single node. If more nodes are added to the tree, the time complexity will grow linearly.

## Whiteboard Solution

![FindMaxValue](https://github.com/rh24/Data-Structures-and-Algorithms/blob/fizzbuzztree/assets/FindMaxValue.jpg)