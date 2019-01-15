using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Mammal : Animal
    {
        public override string BodyCovering { get; set; }

        public abstract void Travel();
    }
}
