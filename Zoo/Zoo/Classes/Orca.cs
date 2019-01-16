using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Orca : Cetacean
    {
        // redirect targets for unwanted property 'set' inputs
        private bool _garbageBool = true;
        private string _garbageString = "";

        public override string Species
        {
            get { return "orca"; }
            set { _garbageString = value; }
        }

        public override bool HangsWithPosse
        {
            get { return true; }
            set { _garbageBool = value; }
        }

        /// <summary>
        /// Reports a successful meal
        /// </summary>
        /// <param name="critter"> the critter that will be eaten </param>
        /// <returns> confirmation of meal </returns>
        public override bool Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am orca, and I play with my food. Today's toy is a {critter.Species}. Weeeeee! Yummmmm.");
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
                new Orca();
            }
            Console.WriteLine($"BREAKING NEWS: Orca pod K welcomes {babies} new member(s)!");
            return babies;
        }
    }


}
