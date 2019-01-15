using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Orca : Cetacean
    {
        private bool _garbageBool = true;

        public override bool HangsWithPosse
        {
            get { return true; }
            set { _garbageBool = value; }
        }

        public override void Eat(IAmDinner critter)
        {
            Console.WriteLine("I am orca, and I play with my food. Today's toy is a {critter}. Weeeeee! Yummmmm.");
        }
    }


}
