# Hashtables

Hashtables are a data structure that use key-value pairs in order to store data into an array. This is done in several steps:

* Create a hashing algorithm
* Create an array of 1024 indices
* Store the key-value pair in a bucket at an index of the array
* In the case of collisions, add the key-value pair to the LinkedList in the bucket

Hashtables are an efficient way of looking up data because as long as the key of the value to find is known, it's possible to find the value in O(1), assuming there aren't any collisions within a bucket in the array. If there are collisions, finding the value of the given key will be in O(n) time, as we'd have to traverse through a LinkedList.

## Big O

> GetHash(string key)

* Space complexity: O(n). As the size of the string increases, so will the number of ASCII values in the bytes array.
* Time complexity: O(n). Must loop through the array to sum the ASCII values of the chars in string.

> Add(string key, object value)

* Space complexity: O(n). Adding a key-value pair requires instantiating a new Node.
* Time complexity: O(1). Node is always added to the Head of the LinkedList.

> FInd(object value)

* Space complexity: O(1). No new memory is intantiated on the heap in order to find a value in the hashtable.
* Time complexity: O(1) if there are no collisions. O(n) if collisions are present.