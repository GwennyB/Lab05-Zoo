using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Carnivore : Mammal
    {
        public bool HasThumbs
        {
            get
            {
                // set true;
            }
            set
            {
                // can lose thumbs
            }
        }


        public override bool LivesOnLand {
            get
            {
                // set true;
            }
            set
            {
                // do not allow set;
            }
        }

        public override void Travel()
        {
            Console.WriteLine("I walk. Sometimes I run. I only swim for entertainment... not for transit. And I can't fly at all.");
        }
    }
}
