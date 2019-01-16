using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    public interface IAmDinner
    {
        // property specific to interfacing behavior
        bool goodWithKetchup { get; set; }
        string Species { get; set; }

        /// <summary>
        /// Requires implementing class to describe how it gets eaten
        /// </summary>
        void GetEaten();
    }
}
