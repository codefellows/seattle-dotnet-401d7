using System;

namespace UnitTestingFizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyTestMethod(2, "Josie");
            string cat = MyTestMethod(2, "Josie");

        }

        public static string FizzBuzz(int n)
        {
            if (n % 15 == 0) return "FizzBuzz";
            if (n % 3 == 0) return "Fizz";
            if (n % 5 == 0) return "Buzz";


            return n.ToString();
        }

        /// <summary>
        /// Instantiates an array and outputs to the console
        /// </summary>
        /// <param name="a">number of cats i own</param>
        /// <param name="b">name of the queen</param>
        /// <returns>the other cat Belle</returns>
        static string MyTestMethod(int a, string b)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            return "Belle";
        }
    }
}
