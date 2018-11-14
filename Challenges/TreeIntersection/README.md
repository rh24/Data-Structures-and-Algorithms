# Tree Intersections

Given two binary trees as input, create a method called `TreeIntersections` that outputs common values from each binary tree.

## Big O

* Space complexity: O(n). As the values in the binary tree inputs increase, the hashtable will increase in size.
* Time complexity: O(n^2). A hashtable look up is O(1), but this solution traverses one entire hashtable and looks up the values in the second hashtable. Some of those linked lists in the buckets may have collisions and require additional looping. Therefore, the worst case is O(n^2).

## Whiteboard Solution

![TreeIntersections](https://github.com/rh24/Data-Structures-and-Algorithms/blob/tree-intersections/assets/TreeIntersections.jpg)