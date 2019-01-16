using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    public interface IEat
    {
        /// <summary>
        /// Requires implementing class to describe its eating habits
        /// </summary>
        /// <param name="critter"> critter to be eaten </param>
        bool Eat(IAmDinner critter);
    }
}
