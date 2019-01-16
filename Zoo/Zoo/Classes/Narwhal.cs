using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Narwhal : Cetacean, IAmDinner
    {
        private bool _garbageBool = true;
        private string _garbageString = "";

        public override string Species
        {
            get { return "narwhal"; }
            set { _garbageString = value; }
        }

        public override bool HangsWithPosse
        {
            get { return true; }
            set { _garbageBool = value; }
        }

        public bool goodWithKetchup
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
            Console.WriteLine($"I narwhal. I eats the {critter.Species} after I skewers it with my horn.");
            return true;
        }

        /// <summary>
        /// Reports instance's untimely demise to the console
        /// </summary>
        void IAmDinner.GetEaten()
        {
            Console.WriteLine("I hope you choke on my horn.");
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
                new Narwhal();
            }
            Console.WriteLine($"Looky! {babies} pointy little narwhal calf(ves)!");
            return babies;
        }

    }
}
