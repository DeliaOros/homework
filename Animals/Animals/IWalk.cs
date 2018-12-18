using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface IWalk
    {
        void Walk();
        int MaxSpeed { get; set; }
    }
}
