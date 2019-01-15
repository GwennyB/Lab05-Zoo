using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Cetacean : Mammal
    {
        public override bool LivesOnLand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void GiveBirth()
        {
            throw new NotImplementedException();
        }

        public override void Travel()
        {
            throw new NotImplementedException();
        }
    }
}
