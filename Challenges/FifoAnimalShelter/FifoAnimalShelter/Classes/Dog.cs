using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Dog : Animal
    {
        public override string Name { get; set; }
        public override Animal Next { get; set; }
        public override bool FirstOfKind { get; set; } = false;
        public override bool FirstInQueue { get; set; } = false;

        public Dog(string name)
        {
            Name = name;
        }
    }
}
