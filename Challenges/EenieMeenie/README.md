# Eenie Meenie Minie Moe

Given an integer, write a method that circles around an array of 'people' `n` number of times until there is only one person left. Return the single, leftover person.

## Approach

Implement the Queue data structure, creating a new queue with each node having a value of each string in the array. Dequeue and enqueue until reaching the nth node. When reaching the nth node, dequeue that node. Continue until only one node is left, and then return that node's value.

## Big O

Space complexity: O(n)
Time complexity: O(n)