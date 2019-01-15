using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Skunk : Carnivore
    {
        private bool _garbageBool = true;

        public override bool HangsWithPosse
        {
            get { return false; }
            set { _garbageBool = value; }
        }

        public override void Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am a skunk, and I ate a {critter}. It was tasty.");
        }

        public override void GiveBirth(int babies)
        {
            Console.WriteLine($"Skunk babies are kinda adorable.... just look at these {babies}!");
        }
    }
}
