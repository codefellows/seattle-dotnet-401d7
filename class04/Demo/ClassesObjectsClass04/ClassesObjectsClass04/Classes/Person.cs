namespace ClassesObjectsClass04.Classes
{
    class Person
    {
        // Propery
        public string Name { get; private set; }

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value >= 21)
                {
                    age = value;
                }
                
            }
        }


        // this is BAD!
        //private int _number;
        //public int Number
        //{
        //    get
        //    {
        //        return _number++;
        //    }
        //}


        public int Number { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public Person()
        {

        }

        public void Walk()
        {
            System.Console.WriteLine("I am walking....");


        }

        public void Increment()
        {
            Number++;
        }
    }
}
