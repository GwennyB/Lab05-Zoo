using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Wolf : Carnivore
    {
        // redirect targets for unwanted property 'set' inputs
        private bool _garbageBool = true; 
        private string _garbageString = "";


        public override string Species
        {
            get { return "wolf"; }
            set { _garbageString = value; }
        }

        public override bool HangsWithPosse
        {
            get { return true; }
            set { _garbageBool = value; }
        }

        /// <summary>
        /// Reports instance's untimely demise to the console
        /// </summary>
        public override bool Eat(IAmDinner critter)
        {
            Console.WriteLine($"This wolf ate a yummy {critter.Species}.");
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
                new Wolf();
            }
            Console.WriteLine($"Look at my new little {babies} wolf pups!");
            return babies;
        }
    }
}
