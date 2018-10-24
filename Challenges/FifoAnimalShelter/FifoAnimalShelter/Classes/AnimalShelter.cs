using System;
using System.Collections.Generic;
using System.Text;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public AnimalShelter(Animal catOrDog)
        {
            Front = catOrDog;
            Rear = catOrDog;

            catOrDog.FirstInQueue = true;
            catOrDog.FirstOfKind = true;
        }

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

                    //Rear.Next = pointer;
                    //Rear = pointer;
                    //Front = pointer.Next;
                    pointer = pointer.Next;
                }

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
