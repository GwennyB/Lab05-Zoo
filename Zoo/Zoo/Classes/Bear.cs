using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Bear : Carnivore
    {
        private bool _garbageBool = true;
        private string _garbageString = "";

        public override string Species
        {
            get { return "bear"; }
            set { _garbageString = value;  }
        }

        public override bool HangsWithPosse
        {
            get { return false; }
            set { _garbageBool = value; }
        }


        public override void Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am a bear, and I ate a {critter.Species}. It was tasty.");
        }

        public override void GiveBirth(int babies)
        {
            for (int i = 0; i < babies; i++)
            {
                new Bear();
            }
            Console.WriteLine($"I had {babies} little bear cub(s), and now I will sleep for a few months.");
        }
    }
}
