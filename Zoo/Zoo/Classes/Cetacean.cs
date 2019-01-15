using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Cetacean : Mammal
    {

        private bool _garbageBool = false;

        public override bool LivesOnLand
        {
            get { return false; }
            set { _garbageBool = value; }
        }

        public override void GiveBirth()
        {
            Console.WriteLine("Just one calf at a time, and at long intervals. Mama needs a break between kids.");
        }

        public override void Travel()
        {
            Console.WriteLine("Just keep swimming, just keep swimming, just keep swimming...swimmming...swimming...");
        }
    }
}
