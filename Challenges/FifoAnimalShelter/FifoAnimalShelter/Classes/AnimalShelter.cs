using System;
using System.Collections.Generic;
using System.Text;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter
{
    public class AnimalShelter
    {
        /// <summary>
        /// Properties that mimic a Queue, which is a FIFO data structure
        /// </summary>
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        /// <summary>
        ///  Constructor requires an Animal object. Set the first animal in the shelter as both first in queue and first of its kind.
        /// </summary>
        /// <param name="catOrDog"></param>
        public AnimalShelter(Animal catOrDog)
        {
            Front = catOrDog;
            Rear = catOrDog;

            catOrDog.FirstInQueue = true;
            catOrDog.FirstOfKind = true;
        }

        /// <summary>
        /// Add an animal object to the Rear of the queue. Check if its of type Cat or Dog.
        /// </summary>
        /// <param name="animal">object that derives from Animal class</param>
        /// <returns>A string that signals whether enqueue was successful</returns>
        public string Enqueue(Animal animal)
        {
            string successMessage = "Sorry, we only house cats and dogs.";

            if (animal is Cat || animal is Dog)
            {
                if (Front == Rear && animal.GetType() != Front.GetType()) animal.FirstOfKind = true;
                Rear.Next = animal;
                Rear = animal;
                successMessage = $"{animal.GetType()} successfully sheltered!";
            }

            return successMessage;
        }

        /// <summary>
        /// This method dequeues the first Cat or Dog based on the preference paramter. If no preference is provided, the longest waiting Animal object will be returned.
        /// </summary>
        /// <param name="pref">string that is "cat" or "dog". Defaults to null</param>
        /// <returns></returns>
        public Animal Dequeue(string pref = null)
        {
            Animal pointer = Front;

            if (pref != null)
            {
                while (pointer != null)
                {
                    if (pointer.GetType().ToString().ToLower().Contains(pref.ToLower()) && pointer.FirstOfKind == true)
                    {
                        Animal temp = pointer.Next;
                        while (temp != null && !temp.GetType().ToString().ToLower().Contains(pref.ToLower()))
                        {
                            temp = temp.Next;
                        }

                        if (temp != null) temp.FirstOfKind = true;

                        break;
                    }

                    Rear.Next = pointer;
                    Rear = pointer;
                    pointer = pointer.Next;
                }

                Front = pointer.Next;
                Front.FirstInQueue = true;
                pointer.Next = null;
                return pointer;
            }
            else
            {
                while (pointer != null)
                {
                    if (pointer.FirstInQueue == true)
                    {
                        Front = pointer.Next;
                        Front.FirstInQueue = true;
                        pointer.Next = null;
                        return pointer;
                    }
                }

                // This will be null if there are no animals in the shelter.
                return pointer;
            }
        }

        /// <summary>
        /// This method is to print all my animals in the shelter to the console so that I can see what's in my queue.
        /// </summary>
        public void PrintAllAnimalsInShelter()
        {
            Animal pointer = Front;

            while (pointer != null)
            {
                Console.WriteLine($"Type: {pointer.GetType()}. Name: {pointer.Name}. First In Queue: {pointer.FirstInQueue}. First of Kind: {pointer.FirstOfKind}");
                pointer = pointer.Next;
            }
        }
    }
}
