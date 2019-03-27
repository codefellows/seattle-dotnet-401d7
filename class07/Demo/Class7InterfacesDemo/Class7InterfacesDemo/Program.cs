using Class7InterfacesDemo.Classes;
using System;
using System.Collections.Generic;

namespace Class7InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InterfaceExample();

            List<string> list = new List<string>();
        }

        static void InterfaceExample()
        {
            Clown clown = new Clown();
            Scary scary = new Scary();
            IDrive driver = scary;
            DriveExample(scary);
        }

        static void DriveExample(IDrive drive)
        {
            drive.SingAlongVoice();
        }

        static void DrivableExample(IDrivable drivable, IDrive driver)
        {
            drivable.Start(driver);
        }
    }
}
