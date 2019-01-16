using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class OtherEdibleCritters : IAmDinner
    {
        // backing stores
        // redirect targets for unwanted property 'set' inputs
        private bool _goodWithKetchup = true;
        private string _species = "tasty critter";

        // This critter is just here for food. For simplicity, he doesn't inherit from Animal. 
        // But he still needs a Species so that others know what they're eating.
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        // interface implementation
        public bool goodWithKetchup
        {
            get { return _goodWithKetchup; }
            set { _goodWithKetchup = value; }
        }

        /// <summary>
        /// Reports instance's untimely demise to the console
        /// </summary>
        void IAmDinner.GetEaten()
        {
            Console.WriteLine($"I am the animal kingdom's equivalent of Soylent Green. The rumors that I am tasty with ketchup are {goodWithKetchup};");
        }
    }
}
