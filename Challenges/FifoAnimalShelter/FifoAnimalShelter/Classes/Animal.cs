using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public abstract class Animal
    {
        /// <summary>
        /// Properties that must be overriden in derived classes
        /// </summary>
        public abstract bool FirstInQueue { get; set; }
        public abstract bool FirstOfKind { get; set; }
        public abstract string Name { get; set; }
        public abstract Animal Next { get; set; }
    }
}
