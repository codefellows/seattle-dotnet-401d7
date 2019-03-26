using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples.Classes
{
    class HighSchool : Graduation
    {
        public string NameOfSchool { get; set; }
        public int Year { get; set; }
        public override int MaxNumberOfGuest { get; set; } = 20;

        public override void Setup()
        {
            //Setup tables
            //get food
            //etc....
        }

        public override void TearDown()
        {
            // Take down decorations
            //take out garbage
            // clean up the glitter
        }
    }
}
