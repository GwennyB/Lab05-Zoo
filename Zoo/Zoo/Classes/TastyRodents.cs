using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class TastyRodents : Mammal, IAmDinner
    {
        public override string BodyCovering { get; set; }
        public override bool LivesOnLand { get; set; }
        public override bool HangsWithPosse { get; set; }

        public override void Eat()
        {
            Console.WriteLine("I eat grass and bugs.");
        }

        public void GetEaten()
        {
            Console.WriteLine("I taste like sadness.");
        }

        public override void GiveBirth()
        {
            Console.WriteLine("I make about 40 rat babies at a time.");
        }

        public override void Travel()
        {
            Console.WriteLine("I can get through miniscule holes in your crawlspace.");
        }
    }
}
