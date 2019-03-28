using GenericsClass08.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using static GenericsClass08.Classes.Cat;

namespace GenericsClass08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CollectionExample();
            // ArrayAddExample();
            // CollectionInitExample();
            EnumExample();
        }


        static void CollectionExample()
        {
            ArrayList list = new ArrayList();
            list.Add("Cat");
            list.Add(1);
            list.Add(1.8);
            list.Add(true);

            List<string> stringList = new List<string>();
            stringList.Add("cat");

            List<int> myints = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            myints.Add(6);
            myints.Add(7);
            myints.Add(8);
            myints.Add(6);


            foreach (int item in myints)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("REMOVE Number 6");

            myints.Remove(6);


            foreach (int item in myints)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=========");

            Console.WriteLine(myints[0]);

            List<Cat> cats = new List<Cat>
            {
                new Cat{Name= "Josie", Age = 8, NumberOfLives = 9 },
                new Cat{Name= "Belle", Age = 8, NumberOfLives = 9 },
                new Cat{Name= "Frodo", Age = 11, NumberOfLives = 0 }
            };

            //LinkedList<string> LList = new LinkedList<string>();
            //LinkedListNode<string> nodde = new LinkedListNode<string>();
            //nodde.

        }

        static void ArrayAddExample()
        {
            NumberList<int> number = new NumberList<int>();

            number.Add(4);
            number.Add(8);
            number.Add(15);
            number.Add(16);
            number.Add(23);
            number.Add(42);


            Console.WriteLine(number.Count());

            Console.WriteLine("==========");
            foreach (int item in number)
            {
                Console.WriteLine(item);
            }
        }

        static void CollectionInitExample()
        {
            NumberList<string> list = new NumberList<string>
            {
                "cat",
                "dog",
                "bird",
                "rabbit"
            };

        }

        static void EnumExample()
        {
            Days day = Days.Wednesday;
            // output 13
            Console.WriteLine((int)day);
            int newDay = (int)day;

            Console.WriteLine("============");
            // output Wednesday
            Console.WriteLine((Days)13);

        }
    }
}
