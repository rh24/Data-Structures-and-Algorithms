using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Dog : Animal
    {
        /// <summary>
        /// Override properties from base Animal class
        /// </summary>
        public override string Name { get; set; }
        public override Animal Next { get; set; }
        public override bool FirstOfKind { get; set; } = false;
        public override bool FirstInQueue { get; set; } = false;

        /// <summary>
        /// Constructor that requires Dogs be instantiated with a name
        /// </summary>
        public Dog(string name)
        {
            Name = name;
        }
    }
}
