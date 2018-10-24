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

            Assert.True(isAnimalShelter);
            Assert.True(nameOfFirstCat);
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

            Assert.Equal(2, animalCount);
        }
    }
}
