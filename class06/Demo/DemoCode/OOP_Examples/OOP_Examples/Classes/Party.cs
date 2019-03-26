using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples
{
   abstract class Party
    {
        public abstract int MaxNumberOfGuest { get; set; }
        public abstract decimal Budget { get; set; }
        public abstract string Venue { get; set; }
        public string Theme { get; set; }

        public abstract void Setup();
        public abstract void TearDown();

    }
}
