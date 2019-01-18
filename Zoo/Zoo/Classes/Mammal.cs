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
        public abstract string Travel();

        /// <summary>
        /// Allows children to hibernate and comment on it
        /// </summary>
        /// <param name="months"> number of months the hibernation lasts </param>
        /// <returns> nap report </returns>
        public virtual string Hibernate(int months)
        {
            string nap = $"What a great {months} month nap!";
            return nap;
        }

    }
}
