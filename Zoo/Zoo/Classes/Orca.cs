using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Orca : Cetacean
    {
        private bool _garbageBool = true;
        private string _garbageString = "";

        public override string Species
        {
            get { return "orca"; }
            set { _garbageString = value; }
        }

        public override bool HangsWithPosse
        {
            get { return true; }
            set { _garbageBool = value; }
        }

        public override bool Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am orca, and I play with my food. Today's toy is a {critter.Species}. Weeeeee! Yummmmm.");
            return true;
        }

        public override int GiveBirth(int babies)
        {
            for (int i = 0; i < babies; i++)
            {
                new Orca();
            }
            Console.WriteLine($"BREAKING NEWS: Orca pod K welcomes {babies} new member(s)!");
            return babies;
        }
    }


}
