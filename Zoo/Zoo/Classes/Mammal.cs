using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Animal
    {
        // backing stores
        // redirect targets for unwanted property 'set' inputs
        private string _garbageString = "";

        // inherited properties overrides
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
