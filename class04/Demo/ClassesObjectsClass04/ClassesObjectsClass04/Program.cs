using ClassesObjectsClass04.Classes;
using System;

namespace ClassesObjectsClass04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PersonExample();
        }

        static void PersonExample()
        {
            Person pers = new Person("Amanda");

            Person cat = pers;

            // pers.Name = "Amanda";

            Console.WriteLine(pers.Name);

            cat.Name = "Josie";

            Console.WriteLine($"cat's name {cat.Name}, pers name {pers.Name}");


            Person dog = new Person { Name = "Fido" };

            Console.WriteLine(dog.Name);

            Person person = new Person();
            person.Name = "My Name";

            person.Age = 20;
            Console.WriteLine(person.Age);
           
        }
    }
}
