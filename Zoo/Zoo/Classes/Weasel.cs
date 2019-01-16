using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Weasel : Carnivore, IAmDinner
    {
        private bool _garbageBool = true;
        private string _garbageString = "";

        public override string Species
        {
            get { return "weasel"; }
            set { _garbageString = value; }
        }

        public override bool HangsWithPosse
        {
            get { return false; }
            set { _garbageBool = value; }
        }

        public bool goodWithKetchup
        {
            get { return true; }
            set { _garbageBool = value; }
        }

        public override void Eat(IAmDinner critter)
        {
            Console.WriteLine($"Weasel find yummy {critter.Species} and eat it.");
        }

        public void GetEaten()
        {
            Console.WriteLine("Ruh-roh.... weasel get eated!");
        }

        public override void GiveBirth(int babies)
        {
            for (int i = 0; i < babies; i++)
            {
                new Weasel();
            }
            Console.WriteLine($"Weasel made {babies} little weasel kittens!");
        }
    }
}
