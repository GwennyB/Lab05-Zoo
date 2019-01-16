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
            IAmDinner guppy = new OtherEdibleCritters();
            IAmDinner salmon = new OtherEdibleCritters();
            IAmDinner tuna = new OtherEdibleCritters();
            IAmDinner sturgeon = new OtherEdibleCritters();
            IAmDinner bass = new OtherEdibleCritters();

            // setting the stage
            Console.WriteLine("Chaos at the zoo!  All of the enclosures have been torn down by angry environmentalists, and the animals are out of control!");

            // skunk eats mole and births 3 babies
            Console.WriteLine("");
            skunk.Eat(mole);
            skunk.GiveBirth(3);

            // weasel eats rat and births 6 babies
            Console.WriteLine("");
            weasel.Eat(rat);
            weasel.GiveBirth(6);

            // lion and wolf each feast at the newly stocked weasel buffet
            Console.WriteLine("");
            lion.Eat(weasel);
            wolf.Eat(weasel);

            // wolf is expecting, so she also eats a bass
            Console.WriteLine("");
            wolf.Eat(bass);
            wolf.GiveBirth(3);

            // lion also had some buns in the oven
            Console.WriteLine("");
            lion.GiveBirth(4);

            // bear went out for dinner, and then went home to have babies and a nap
            Console.WriteLine("");
            bear.Travel();
            bear.Eat(salmon);
            bear.Travel();
            bear.GiveBirth(1);

            // meanwhile, in the water, everyone had babies!
            Console.WriteLine("");
            narwhal.GiveBirth(1);
            orca.GiveBirth(1);
            dolphin.GiveBirth(1);

            // ...and got hungry
            Console.WriteLine("");
            narwhal.Eat(guppy);
            dolphin.Eat(sturgeon);
            orca.Eat(narwhal);
            orca.Eat(dolphin);

            Console.ReadLine();

        }
    }
}
