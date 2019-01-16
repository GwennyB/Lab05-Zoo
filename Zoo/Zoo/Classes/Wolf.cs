using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Wolf : Carnivore
    {
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

        public override bool Eat(IAmDinner critter)
        {
            Console.WriteLine($"This wolf ate a yummy {critter.Species}.");
            return true;
        }

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
