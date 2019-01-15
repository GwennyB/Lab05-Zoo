using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class OtherEdibleCritters : IAmDinner
    {
        private bool _goodWithKetchup = true;
        public bool goodWithKetchup
        {
            get { return _goodWithKetchup; }
            set { _goodWithKetchup = value; }
        }

        public void GetEaten()
        {
            Console.WriteLine($"I am the animal kingdom's equivalent of Soylent Green. The rumors that I am tasty with ketchup are {goodWithKetchup};");
        }
    }
}
