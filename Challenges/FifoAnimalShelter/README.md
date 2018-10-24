# FIFO Animal Shelter

Create an AnimalShelter class that operates using a first in, first out approach. Within this class, implement an `Enqueue(animal)` method and a `Dequeue(pref)` method, where `animal` represents an `Animal` object and `pref` represents a string: either 'cat' or 'dog.' This `pref` string can be optionally null, in which case the dequeue method should return the longest waiting animal.

If a preference is given, dequeue the longest waiting animal of preference.

The approach I took has an abstract parent Animal class and two derived concrete classes: Cat and Dog.

## Big O

>`Enqueue(animal)`

* Time complexity: O(1)
* Space complexity: O(1)

>`Dequeue(pref)`

* Time complexity: O(n)
* Space complexity: O(1)

## Whiteboard Solution

![FIFOAnimalShelter](https://github.com/rh24/Data-Structures-and-Algorithms/blob/fifo-animal-shelter/assets/FIFOAnimalShelter.jpeg)