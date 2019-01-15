using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Bear : Carnivore, IEat
    {
        public override bool HangsWithPosse { get; set; }

        public void Eat(IAmDinner critter)
        {
            Console.WriteLine($"I am a bear, and I ate a {critter}. It was tasty.");
        }

        public override void GiveBirth()
        {
            Console.WriteLine("I had a bear cub, and now I will sleep for a few months.");
        }
    }
}
