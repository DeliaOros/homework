using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface ISwim
    {
        void Swim();
        int MaxSpeed { get; set; }
    }
}
