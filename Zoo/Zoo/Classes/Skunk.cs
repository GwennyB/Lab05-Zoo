using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Skunk : Carnivore
    {
        private bool _garbageBool = true;
        private string _garbageString = "";

        public override string Species
        {
            get { return "skunk"; }
            set { _garbageString = value; }
        }

        public override bool HangsWithPosse
        {
            get { return false; }
            set { _garbageBool = value; }
        }

        public override bool Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am a skunk, and I ate a {critter.Species}. It was tasty.");
            return true;
        }

        public override int GiveBirth(int babies)
        {
            for (int i = 0; i < babies; i++)
            {
                new Skunk();
            }
            Console.WriteLine($"Skunk babies are kinda adorable.... just look at these {babies}!");
            return babies;
        }
    }
}
