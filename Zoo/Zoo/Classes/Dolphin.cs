using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Dolphin : Cetacean, IAmDinner
    {
        private bool _garbageBool = true;

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

        public override void Eat(IAmDinner critter)
        {
            Console.WriteLine("Squeak squeak... SQUEAK! Mmmmm.... {critter}.");
        }

        public void GetEaten()
        {
            Console.WriteLine("SQUEEEEEEEEAK!");
        }

        public override void GiveBirth(int babies)
        {
            Console.WriteLine("Squeeeee..... {babies} new dolphin pup(s)!");
        }
    }
}
