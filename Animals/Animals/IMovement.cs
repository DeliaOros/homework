using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface IMovement//not used
    {
        int Walk { get; set; }
        int Fly { get; set; }
        int Crawl { get; set; }
        int Swim { get; set; }
        int GetMaxSpeed();
    }
}
