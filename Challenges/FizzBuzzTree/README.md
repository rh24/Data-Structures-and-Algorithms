# FizzBuzz Tree

Given a tree, traverse the nodes and assess the values of the traversed nodes. If divisible by 3 & 5, print "FizzBuzz." If divisible by 3, print "Fizz," and if divisible by 5, print "Buzz." Print the value as is if the node's value does not fit any of the aforementioned conditions.

## Big O

> Space complexity: O(h)

This solution uses a depth-first traversal, preorder method (Root, Left, Right), and recursively traverses the tree. Therefore, the space complexity of the solution will be O(h), the height of the tree. With each recursive call, a new frame will be added to the stack.

> Time complexity: O(n)

Worst case is that each node of the tree must be checked. Therefore, time complexity is O(n).

## Whiteboard Solution

![FizzBuzzTree](https://github.com/rh24/Data-Structures-and-Algorithms/blob/fizzbuzztree/assets/FizzBuzzTree.jpg)