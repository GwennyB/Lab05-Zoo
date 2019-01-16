using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Cetacean : Mammal
    {

        private bool _garbageBool = false;

        public override bool LivesOnLand
        {
            get { return false; }
            set { _garbageBool = value; }
        }

        /// <summary>
        /// Inherited from Animal.
        /// Describes instance's travel to the console.
        /// </summary>
        public override void Travel()
        {
            Console.WriteLine("Just keep swimming, just keep swimming, just keep swimming...swimmming...swimming...");
        }
    }
}
