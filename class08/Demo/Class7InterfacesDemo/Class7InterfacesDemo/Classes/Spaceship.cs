using System;
using System.Collections.Generic;
using System.Text;

namespace Class7InterfacesDemo.Classes
{
    class Spaceship : IDrivable
    {
        public void Brake()
        {
            Console.WriteLine("Spaceship is going to Brake!!");
        }

        public void Start(IDrive driver)
        {
            driver.SingAlongVoice();
            Console.WriteLine("Spaceship is going to start!");
        }

        public bool Stop()
        {
            Console.WriteLine("Plummeting with grace!");
            return true;
        }
    }
}
