﻿using System;
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

        // if no preference, find the longest waiting animal
        // if dog, but first node.Value is a cat, save first cat in a temp

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
                    if (pointer.GetType().ToString().ToLower() == pref.ToLower() && pointer.FirstOfKind == true)
                    {
                        Animal temp = pointer.Next;
                        while (temp.GetType().ToString().ToLower() != pref.ToLower())
                        {
                            temp = temp.Next;
                        }

                        if (temp != null) temp.FirstOfKind = true;
                    }

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
                        Animal temp = pointer.Next;
                        Front = pointer.Next;
                        Front.FirstInQueue = true;
                        return pointer;
                    }
                }

                // This will be null if there are no animals in the shelter.
                return pointer;
            }
        }
    }
}
