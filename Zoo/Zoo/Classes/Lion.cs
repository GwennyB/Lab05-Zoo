using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Lion : Carnivore
    {
        private bool _garbageBool = true;
        private string _garbageString = "";

        public override string Species
        {
            get { return "lion"; }
            set { _garbageString = value; }
        }

        public override bool HangsWithPosse {
            get { return true; }
            set { _garbageBool = value; }
        }

        /// <summary>
        /// Instantiates new class instance for each baby;
        /// Reports births to console;
        /// Returns number of babies
        /// </summary>
        /// <param name="babies"> number of babies </param>
        /// <returns> number of babies </returns>
        public override int GiveBirth(int babies)
        {
            for (int i = 0; i < babies; i++)
            {
                new Lion();
            }
            Console.WriteLine($"I am a lioness, and I had {babies} cubs. D'awwwwwww(rawr)!!!");
            return babies;
        }

        /// <summary>
        /// Reports a successful meal
        /// </summary>
        /// <param name="critter"> the critter that will be eaten </param>
        /// <returns> confirmation of meal </returns>
        public override bool Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am a lion, and  I eat all the things. Today I ate a {critter.Species}.");
            return true;
        }
    }
}
