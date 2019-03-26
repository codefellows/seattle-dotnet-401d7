using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples.Classes
{
    class OlderTwentyOne : Birthday
    {
        public override string Venue { get; set; } = "Bar";

        public override void Setup()
        {
            // Reserve Tables
        }

        public override void TearDown()
        {
            // tip the Bartender
        }

        public override string PlayGames()
        {
            return "Playing Darts!!";
        }

        public int NumberOfRounds()
        {
            return 6;
        }
    }
}
