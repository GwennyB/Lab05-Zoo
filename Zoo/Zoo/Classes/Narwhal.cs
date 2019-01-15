using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Narwhal : Cetacean, IAmDinner
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
            Console.WriteLine($"I narwhal. I eats the {critter} after I skewers it with my horn.");
        }

        public void GetEaten()
        {
            Console.WriteLine("I hope you choke on my horn.");
        }

        public override void GiveBirth(int babies)
        {
            Console.WriteLine($"Looky! {babies} pointy little narwhal calf(ves)!");
        }
    }
}
