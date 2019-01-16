using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Bear : Carnivore
    {
        // redirect targets for unwanted property 'set' inputs
        private bool _garbageBool = true;
        private string _garbageString = "";

        // inherited property overrides
        public override string Species
        {
            get { return "bear"; }
            set { _garbageString = value;  }
        }

        public override bool HangsWithPosse
        {
            get { return false; }
            set { _garbageBool = value; }
        }

        /// <summary>
        /// Reports a successful meal
        /// </summary>
        /// <param name="critter"> the critter that will be eaten </param>
        /// <returns> confirmation of meal </returns>
        public override bool Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am a bear, and I ate a {critter.Species}. It was tasty.");
            return true;
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
                new Bear();
            }
            Console.WriteLine($"I had {babies} little bear cub(s), and now I will sleep for a few months.");
            return babies;
        }
    }
}
