using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Cat : Animal
    {
        public override string Name { get; set; }
        public override bool FirstOfKind { get; set; } = false;
        public override Animal Next { get; set; }
        public override bool FirstInQueue { get; set; } = false;
    }
}
