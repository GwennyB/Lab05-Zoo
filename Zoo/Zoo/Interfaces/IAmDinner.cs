using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface IAmDinner
    {
        bool goodWithKetchup { get; set; }

        void GetEaten();
    }
}
