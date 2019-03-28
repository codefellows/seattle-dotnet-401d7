using System;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List:");
            LinkedList();
        }

        static void LinkedList()
        {
            LList<int> list = new LList<int>();

            list.Insert(8);
            list.Insert(4);
            list.Insert(15);

            Console.WriteLine("==============");
            Console.WriteLine(string.Join(',', list.Print()));


            LList<string> stringList = new LList<string>();

            stringList.Insert("cat");
            stringList.Insert("dog");
            stringList.Insert("bird");

            Console.WriteLine("STRINGS!");
            Console.WriteLine(string.Join(',', stringList.Print()));

            LList<Node<int>> nodeList = new LList<Node<int>>();




            //list.Print();
            //Console.WriteLine(list.Includes(55));

            //list.Append(16);

            //list.Print();

            //list.InsertBefore(16, 15);

            //list.Print();

            //list.InsertAfter(16, 23);
            //list.InsertAfter(4, 5);

            //list.Print();

        }
    }
}
