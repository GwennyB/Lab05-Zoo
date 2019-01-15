using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    abstract class Animal : IEat
    {
        public abstract string BodyCovering { get; set; }

        public abstract bool LivesOnLand { get; set; }

        public abstract bool HangsWithPosse { get; set; }

        public abstract void Eat(IAmDinner critter);
        public abstract void GiveBirth(int babies);

    }
}
