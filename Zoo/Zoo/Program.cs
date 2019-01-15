using System;
using Zoo.Classes;
using Zoo.Interfaces;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // make animals
            Skunk skunk = new Skunk();
            Weasel weasel = new Weasel();
            Bear bear = new Bear();
            Lion lion = new Lion();
            Wolf wolf = new Wolf();
            Narwhal narwhal = new Narwhal();
            Dolphin dolphin = new Dolphin();
            Orca orca = new Orca();

            // make dinner
            IAmDinner rat = new OtherEdibleCritters();
            IAmDinner mole = new OtherEdibleCritters();


        }
    }
}
