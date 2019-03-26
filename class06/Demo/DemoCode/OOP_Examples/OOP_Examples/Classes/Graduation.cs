using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples.Classes
{
   abstract class Graduation : Party
    {
        public string NameOnDiploma { get; set; }
        public override decimal Budget { get; set; } = 500;
        public override string Venue { get; set; } = "Backyard";

        public virtual string GiveSpeech()
        {
            return "Thank you everyone for this!";

        }
    }
}
