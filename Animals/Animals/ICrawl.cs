using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface ICrawl
    {
        void Crawl();
        int MaxSpeed { get; set; }
    }
}
