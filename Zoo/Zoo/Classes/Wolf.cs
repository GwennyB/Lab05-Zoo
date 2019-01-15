using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Wolf : Carnivore
    {
        private bool _garbageBool = true;

        public override bool HangsWithPosse
        {
            get { return true; }
            set { _garbageBool = value; }
        }

        public override void Eat(IAmDinner critter)
        {
            Console.WriteLine($"This wolf ate a yummy {critter}.");
        }

        public override void GiveBirth(int babies)
        {
            Console.WriteLine($"Look at my new little {babies} wolf pups!");
        }
    }
}
