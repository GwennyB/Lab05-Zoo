using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Carnivore : Mammal
    {
        // backing stores
        private bool _thumbs = true;
        // redirect targets for unwanted property 'set' inputs
        private bool _garbageBool = true;

        // inherited property overrides
        public override bool LivesOnLand {
            get { return true; }
            set { _garbageBool = value; }
        }

        // concrete properties to be inherited by deriving classes
        public bool HasThumbs
        {
            get { return _thumbs;  }
            set { _thumbs = value; }
        }

        /// <summary>
        /// Inherited from Animal.
        /// Describes instance's travel to the console.
        /// </summary>
        public override void Travel()
        {
            Console.WriteLine($"I am a {Species}. I walk. Sometimes I run. I only swim for entertainment... not for transit. And I can't fly at all.");
        }
    }
}
