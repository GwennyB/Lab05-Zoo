using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    class Narwhal : Cetacean, IAmDinner
    {
        public override bool HangsWithPosse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetEaten()
        {
            throw new NotImplementedException();
        }
    }
}
