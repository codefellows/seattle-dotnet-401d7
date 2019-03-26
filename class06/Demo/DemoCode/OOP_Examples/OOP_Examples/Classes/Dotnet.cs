using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples.Classes
{
    class Dotnet : CodeFellows
    {
        public override int MaxNumberOfGuest { get; set; } = 50;
        public override decimal Budget
        {
            get => base.Budget + 50; set => base.Budget = value;
        }
        public override string GiveSpeech()
        {
            return base.GiveSpeech();
        }
    }
}
