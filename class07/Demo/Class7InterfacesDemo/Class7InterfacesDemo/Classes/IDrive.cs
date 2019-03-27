namespace Class7InterfacesDemo.Classes
{
    interface IDrive
    {
        // property
        int Age { get; set; }

        //method
        string SingAlongVoice();

        void GetIn(IDrivable drivable);
    }
}
