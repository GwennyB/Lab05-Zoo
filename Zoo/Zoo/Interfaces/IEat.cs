using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    public interface IEat
    {
        bool Eat(IAmDinner critter);
    }
}
