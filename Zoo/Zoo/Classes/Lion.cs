using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Lion : Carnivore
    {
        private bool _garbageBool = true;
        private string _garbageString = "";

        public override string Species
        {
            get { return "lion"; }
            set { _garbageString = value; }
        }

        public override bool HangsWithPosse {
            get { return true; }
            set { _garbageBool = value; }
        }

        public override int GiveBirth(int babies)
        {
            for (int i = 0; i < babies; i++)
            {
                new Lion();
            }
            Console.WriteLine($"I am a lioness, and I had {babies} cubs. D'awwwwwww(rawr)!!!");
            return babies;
        }

        public override bool Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am a lion, and  I eat all the things. Today I ate a {critter.Species}.");
            return true;
        }
    }
}
