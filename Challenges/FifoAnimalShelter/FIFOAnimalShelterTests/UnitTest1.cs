using System;
using Xunit;
using static FIFOAnimalShelter.Program;
using FIFOAnimalShelter;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelterTests
{
    public class UnitTest1
    {
        public static AnimalShelter shelter = FifoAnimalShelter();

        /// <summary>
        /// Tests whether FifoAnimalShelter() in Program.cs returns an AnimalShelter object. It is always instantiated with a Cat named "Kitty."
        /// </summary>
        [Fact]
        public void CreateAnAnimalShelter()
        {
            var shelter = FifoAnimalShelter();
            bool isAnimalShelter = shelter is AnimalShelter;
            bool nameOfFirstCat = shelter.Front.Name == "Kitty";
            bool isCat = shelter.Front is Cat;

            Assert.True(isAnimalShelter);
            Assert.True(nameOfFirstCat);
            Assert.True(isCat);
        }

        /// <summary>
        /// Test whether a cat gets successfully enqueued.
        /// </summary>
        [Fact]
        public void TestEnqueue()
        {
            Cat meow = new Cat("Meow");
            Dog scout = new Dog("Scout");
            Cat waffles = new Cat("Waffles");
            shelter.Enqueue(meow);
            int animalCount = shelter.PrintAllAnimalsInShelterAndCount();
            shelter.Enqueue(scout);
            int secondAnimalCount = shelter.PrintAllAnimalsInShelterAndCount();
            shelter.Enqueue(waffles);
            int thirdAnimalCount = shelter.PrintAllAnimalsInShelterAndCount();

            Assert.Equal(2, animalCount);
            Assert.Equal(3, secondAnimalCount);
            Assert.Equal(4, thirdAnimalCount);
        }

        /// <summary>
        /// Test that the first "cat" to be dequeued's name is "Kitty" because kitty was first in line. Afterwards, test that a "dog" is succesfully dequeued.
        /// </summary>
        [Fact]
        public void TestDequeue()
        {
            Cat meow = new Cat("Meow");
            Dog scout = new Dog("Scout");
            Cat waffles = new Cat("Waffles");
            shelter.Enqueue(meow);
            shelter.Enqueue(scout);
            shelter.Enqueue(waffles);

            Animal kitty = shelter.Dequeue("cat");

            Assert.Equal("Kitty", kitty.Name);
            Assert.True(kitty.FirstInQueue);
            Assert.True(kitty.FirstOfKind);

            Animal secondDequeued = shelter.Dequeue("dog");

            Assert.Equal("Scout", secondDequeued.Name);
            Assert.True(secondDequeued.FirstOfKind);
            Assert.False(secondDequeued.FirstInQueue);
        }
    }
}
