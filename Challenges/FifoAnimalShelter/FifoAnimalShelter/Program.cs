using System;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat meow = new Cat("Meow");
            Dog scout = new Dog("Scout");
            AnimalShelter shelter = new AnimalShelter(meow);

            Console.WriteLine($"****** Welcome to the Animal Shelter! ********");
            Console.WriteLine(shelter.Enqueue(meow));
            Console.WriteLine($"Meow the cat is the first of its kind: {meow.FirstOfKind} and first in shelter: {meow.FirstInQueue}");

            Console.WriteLine(shelter.Enqueue(scout));
            Console.WriteLine($"Scout the dog is the first of its kind: {scout.FirstOfKind} and first in shelter: {scout.FirstInQueue}");
        }
    }
}
