using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Weasel : Carnivore, IAmDinner
    {
        // backing stores
        // redirect targets for unwanted property 'set' inputs
        private bool _garbageBool = true;
        private string _garbageString = "";

        // inherited properties overrides and interface implementations
        public override string Species
        {
            get { return "weasel"; }
            set { _garbageString = value; }
        }

        public override bool HangsWithPosse
        {
            get { return false; }
            set { _garbageBool = value; }
        }

        public bool goodWithKetchup
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
            Console.WriteLine($"Weasel find yummy {critter.Species} and eat it.");
            return true;
        }

        /// <summary>
        /// Reports instance's untimely demise to the console
        /// </summary>
        void IAmDinner.GetEaten()
        {
            Console.WriteLine("Ruh-roh.... weasel get eated!");
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
                new Weasel();
            }
            Console.WriteLine($"Weasel made {babies} little weasel kittens!");
            return babies;
        }
    }
}
