using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Mammal : Animal
    {
        private string _garbageString = "";

        public override string BodyCovering {
            get { return "hair"; }
            set { _garbageString = value; }
        }

        public abstract void Travel();
    }
}
