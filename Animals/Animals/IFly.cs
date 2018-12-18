using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface IFly
    {
        void Fly();
        int MaxSpeed { get; set; }

    }
}
