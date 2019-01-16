using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    public interface IAmDinner
    {
        string Species { get; set; }

        bool goodWithKetchup { get; set; }

        /// <summary>
        /// Requires implementing class to describe how it gets eaten
        /// </summary>
        void GetEaten();
    }
}
