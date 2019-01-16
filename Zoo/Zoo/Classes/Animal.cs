using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public abstract class Animal : IEat
    {
        public abstract string Species { get; set; }
        public abstract string BodyCovering { get; set; }

        public abstract bool LivesOnLand { get; set; }

        public abstract bool HangsWithPosse { get; set; }

        /// <summary>
        /// Implementation of IEat interface
        /// Requires children to define their eating habits
        /// </summary>
        /// <param name="critter"> critter to be eaten </param>
        /// <returns> confirmation of meal </returns>
        public abstract bool Eat(IAmDinner critter);

        /// <summary>
        /// Requires children to define their reproduction
        /// </summary>
        /// <param name="babies"> number of babies </param>
        /// <returns>number of babies </returns>
        public virtual int GiveBirth(int babies)
        {
            return babies;
        }

    }
}
