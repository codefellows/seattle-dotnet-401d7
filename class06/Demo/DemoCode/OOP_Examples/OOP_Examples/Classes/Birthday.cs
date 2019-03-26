using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Examples.Classes
{
    //Since we have other classes being derived from Birthday, we can safely make Birthday abstract
    abstract class Birthday : Party // Show Inheritance through the colon (:) symbol
    {
        public override int MaxNumberOfGuest { get; set; } = 100;
        public override decimal Budget { get; set; } = 1000.00m; //Polymorphism allows us to overrride

        public virtual bool WatchClowns(int numOfClowns)
        {
            if (numOfClowns > 0)
            {
                return true;
            }

            return false;
        }

        public int OpenPresents()
        {
            return 10;
        }

        public virtual string PlayGames()
        {
            return "We are gonna play musical Chairs";
        }
    }
}
