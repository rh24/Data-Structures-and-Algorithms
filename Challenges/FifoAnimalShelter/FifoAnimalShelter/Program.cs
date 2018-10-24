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
            Cat waffles = new Cat("Waffles");
            AnimalShelter shelter = FIFOAnimalShelter();

            Console.WriteLine($"****** Welcome to the Animal Shelter! ********");
            Console.WriteLine(shelter.Enqueue(meow));
            Console.WriteLine($"Meow the cat is the first of its kind: {meow.FirstOfKind} and first in shelter: {meow.FirstInQueue}");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(shelter.Enqueue(scout));
            Console.WriteLine($"Scout the dog is the first of its kind: {scout.FirstOfKind} and first in shelter: {scout.FirstInQueue}");

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"Dequeue {shelter.Dequeue("cat").GetType()}");
            Console.WriteLine($"My first animal is now {shelter.Front.Name}. It is the first in the shelter now: {shelter.Front.FirstInQueue}.");

            Console.WriteLine(Environment.NewLine);

            shelter.Enqueue(waffles);

            shelter.PrintAllAnimalsInShelter();
        }

        static AnimalShelter FIFOAnimalShelter()
        {
            Cat kitty = new Cat("Kitty");
            return new AnimalShelter(kitty);
        }
    }
}
