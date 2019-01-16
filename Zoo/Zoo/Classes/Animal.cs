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

        public abstract bool Eat(IAmDinner critter);
        public virtual int GiveBirth(int babies)
        {
            return babies;
        }

    }
}
