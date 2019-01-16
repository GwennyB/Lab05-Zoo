using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Narwhal : Cetacean, IAmDinner
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
        public override void Eat(IAmDinner critter)
        {
            Console.WriteLine($"I narwhal. I eats the {critter.Species} after I skewers it with my horn.");
        }

        public void GetEaten()
        {
            Console.WriteLine("I hope you choke on my horn.");
        }

        public override void GiveBirth(int babies)
        {
            for (int i = 0; i < babies; i++)
            {
                new Narwhal();
            }
            Console.WriteLine($"Looky! {babies} pointy little narwhal calf(ves)!");
        }

    }
}
