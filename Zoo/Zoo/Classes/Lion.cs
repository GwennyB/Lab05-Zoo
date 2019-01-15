using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Lion : Carnivore
    {
        private bool _garbageBool = true;

        public override bool HangsWithPosse {
            get { return true; }
            set { _garbageBool = value; }
        }

        public override void GiveBirth(int babies)
        {
            Console.WriteLine($"I am a lioness, and I had {babies} cubs. D'awwwwwww(rawr)!!!");
        }

        public override void Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am a lion, and  I eat all the things. Today I ate a {critter}.");
        }
    }
}
