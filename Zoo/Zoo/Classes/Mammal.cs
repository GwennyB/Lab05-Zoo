using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Animal
    {
        private string _garbageString = "";

        public override string BodyCovering {
            get { return "hair"; }
            set { _garbageString = value; }
        }

        /// <summary>
        /// Requires children to define how they travel
        /// </summary>
        public abstract void Travel();
    }
}
