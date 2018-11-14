# Tree Intersection

Given two binary trees as input, create a method called `TreeIntersections` that outputs common values from each binary tree.

## Big O

* Space complexity: O(n). As the values in the binary tree inputs increase, the hashtable will take up more memory linearly. This is due to new Nodes that are instantiated and added to the Linked Lists in each bucket.
* Time complexity: O(n). A hashtable look up is O(1), but this solution must check every single node in both binary trees in order to perform each look ups in two separate hashtables.

## Whiteboard Solution

![TreeIntersections](https://github.com/rh24/Data-Structures-and-Algorithms/blob/tree-intersections/assets/TreeIntersections.jpg)
