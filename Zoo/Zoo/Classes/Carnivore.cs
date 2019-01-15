using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Carnivore : Mammal
    {

        private bool _thumbs = true;
        private bool _garbageBool = true;

        public bool HasThumbs
        {
            get { return _thumbs;  }
            set { _thumbs = value; }
        }


        public override bool LivesOnLand {
            get { return true; }
            set { _garbageBool = value; }
        }

        public override void Travel()
        {
            Console.WriteLine("I walk. Sometimes I run. I only swim for entertainment... not for transit. And I can't fly at all.");
        }
    }
}
