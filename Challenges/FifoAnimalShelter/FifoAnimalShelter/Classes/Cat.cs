using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Cat : Animal
    {
        /// <summary>
        /// Override properties from base Animal class
        /// </summary>
        public override string Name { get; set; }
        public override bool FirstOfKind { get; set; } = false;
        public override Animal Next { get; set; }
        public override bool FirstInQueue { get; set; } = false;

        /// <summary>
        /// Constructor that requires Cats be instantiated with a name
        /// </summary>
        /// <param name="name"></param>
        public Cat(string name)
        {
            Name = name;
        }
    }
}
