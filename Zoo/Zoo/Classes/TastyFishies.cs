using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class TastyFishies : Animal, IAmDinner
    {
        public override string BodyCovering { get; set; }
        public override bool LivesOnLand { get; set; }
        public override bool HangsWithPosse { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I eat kelp, amoeba, and poop.");
        }

        public void GetEaten()
        {
            Console.WriteLine("Mmmmmm....fish tacos.");
        }

        public override void GiveBirth()
        {
            Console.WriteLine("My babies are caviar.");
        }
    }
}
