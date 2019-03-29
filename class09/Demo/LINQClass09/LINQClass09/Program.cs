using LINQClass09.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQClass09
{
    delegate void MyDelegate();
    delegate bool NumbersDelegate(int n);

    /*
     class MyDelegate{}
         */
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");

            //MyDelegate del = new MyDelegate(MyMethod);
            //del();
            //del.Invoke();
            // PassingADelegate(del);

            #region DelegateCode

            //int[] myNumbers = { 2, 3, 5, 10, 6, 7, 9, 16, 22 };

            //IEnumerable<int> evens = GetNumbers(myNumbers, n => n % 2 == 0);
            //IEnumerable<int> odds = GetNumbers(myNumbers, n => n % 2 != 0);
            //IEnumerable<int> fives = GetNumbers(myNumbers, n => n % 5 == 0);

            //Console.WriteLine("EVENS!!!!");
            //foreach (var item in evens)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("ODDS!!!!");
            //foreach (var item in odds)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("fives!!!!");
            //foreach (var item in fives)
            //{
            //    Console.WriteLine(item);
            //}

            ////Func<> // different return types

            ////Action<
            //Func<int, int, bool> myFunc = ThisTakesInTwoIntsAndReturnsABool;

            #endregion

            // BasicLINQ();
            // MethodCallsWithLINQ();
            // GroupBy();
            SetOperands();
        }

        static bool ThisTakesInTwoIntsAndReturnsABool(int a, int b)
        {
            return true;
        }

        static void MyMethod()
        {
            Console.WriteLine("This is my Method");
        }

        static IEnumerable<int> GetNumbers(IEnumerable<int> numbers, NumbersDelegate delly)
        {
            foreach (int number in numbers)
            {
                if (delly(number))
                {
                    yield return number;
                }
            }
        }

        static void PassingADelegate(MyDelegate delly)
        {
            delly();
        }

        static bool GetAllEvenNumbers(int n)
        {
            return n % 2 == 0;
        }

        static bool GetAllOddNumbers(int n)
        {
            return n % 2 != 0;
        }

        static bool GetAllFives(int n)
        {
            return n % 5 == 0;
        }

        static void BasicLINQ()
        {
            Person[] persons =
            {
                new Person("Kate", "Austin", 33),
                new Person("Jack", "Shepard", 39),
                new Person("James", "Ford", 30),
                new Person("Ben", "Linus", 23),
                new Person("Hugo", "Reyes", 20),

            };

            var query = from person in persons
                        select person;

            var query2 = from p in persons
                         where p.Age > 21
                         orderby p.Age descending
                         select new { p.FirstName, p.Age };

            foreach (var item in query2)
            {
                Console.WriteLine($"{item.FirstName} is {item.Age} years old");
            }



        }

        static void MethodCallsWithLINQ()
        {
            Person[] persons =  {
                new Person("Kate", "Austin", 33),
                new Person("Jack", "Shepard", 39),
                new Person("James", "Ford", 30),
                new Person("Ben", "Linus", 23),
                new Person("Hugo", "Reyes", 20),
            };

            var query = persons.Select(p => new { p.FirstName, p.LastName });

            var lequi = from p in persons
                        select new { p.FirstName, p.LastName };

            var chain = persons
                        .Where(p => p.Age > 21)
                        .OrderByDescending(person => person.Age)
                        .Select(p => new { p.FirstName, p.LastName });

            // no select is needed

            var noSelect = persons.Where(p => p.Age > 21);

            // Take and a Skip

            var takeAndSkip = persons
                             .Where(person => person.Age > 21)
                             .OrderByDescending(person => person.Age)
                             .Skip(2)
                             .Take(2)
                             .Select(p => new { p.FirstName, p.Age });

            foreach (var person in takeAndSkip)
            {
                Console.WriteLine($"{person.FirstName} is {person.Age} years old");
            }


            var list = new[] { 1, 2, 3, 4, 5 };

            int sum = list.Sum(); // Eager loading "Immediate exection"


        }

        static void GroupBy()
        {
            var words = new[] { "cat", "dog", "bird", "lion", "parrot", "wildabeast" };

            var query = words.GroupBy(word => word.Length);

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var word in item)
                {
                    Console.WriteLine($"* {word}");
                }

            }
        }

        static void SetOperands()
        {
            var list1 = new[] { 1, 2, 3 };
            var list2 = new[] { 3, 4, 5 };

            // union means to return items in all lists minus the dupes
            var union = list1.Union(list2); // 1,2,3,4,5
            foreach (var item in union)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine("INTERSECTION!");
            // All the items that appear in both collections
            var inter = list1.Intersect(list2);
            foreach (var item in inter)
            {
                Console.Write($"{item} ");
            }


            Console.WriteLine();
            // return values that are in list 1
            var except = list1.Except(list2);
            Console.WriteLine("EXCEPT EXAMPLE");

            foreach (var item in except)
            {
                Console.Write($"{item} ");
            }

            // distinct
            var list = new[] { 4, 8, 15, 16, 23, 42, 42, 42, 77, 67, 1, 2, 1, 2, 8, 5, 6, 4 };

            Console.WriteLine("DISTINCT!");
            // All unique numbers
            var distinct = list.Distinct();

            foreach (var item in distinct)
            {
                Console.Write($"{item} ");
            }


        }

    }
}
