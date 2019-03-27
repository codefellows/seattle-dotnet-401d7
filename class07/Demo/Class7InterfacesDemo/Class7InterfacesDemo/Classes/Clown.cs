namespace Class7InterfacesDemo.Classes
{
    class Clown : Person, IDrive
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public sealed override string PlayGame()
        {
            return "Just kidding, I'm a clown";
        }

        public string SingAlongVoice()
        {
            return "Fa-la-la";
        }
    }
}
