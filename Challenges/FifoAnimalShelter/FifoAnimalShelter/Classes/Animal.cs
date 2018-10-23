using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public abstract class Animal
    {
        public virtual bool firstInQueue { get; set; }
        public abstract string Name { get; set; }
    }
}
