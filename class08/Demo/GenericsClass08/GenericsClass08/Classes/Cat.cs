namespace GenericsClass08.Classes
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLives { get; set; }

        public Days FavoriteDayOfWeek { get; set; }

        //public Cat(string name, int age, int numberOfLives)
        //{
        //    Name = name;
        //    Age = age;
        //    NumberOfLives = numberOfLives;
        //}
        public enum Days
        {
            Sunday = 10,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }

    enum Months
    {
        January,
        February,
        March,
        April
    }
}
