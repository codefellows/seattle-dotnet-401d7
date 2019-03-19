using System;

namespace Class01Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //string answer = MyMethod();
            //Console.WriteLine(answer);

            // ExceptionExample();
            try
            {
                int number = DivideByZero(10);
                Console.WriteLine(number);
            }
            catch (Exception)
            {

                Console.WriteLine("We are in Main");
            }
            finally
            {
                Console.WriteLine("BACK IN MAIN");
            }

            //try
            //{
            //    MethodA();
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine("I am main!!");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("FINALLY I AM DONE!");
            //}

        }

        static string MyMethod()
        {
            return "candy";
        }

        static void ExceptionExample()
        {
            try
            {
                Console.WriteLine("Enter the miles driven");
                string answer = Console.ReadLine();
                int miles = Convert.ToInt32(answer);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("You did some formatting incorrectly");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static int DivideByZero(int number)
        {
            try
            {
                Console.WriteLine($"Enter a number to divide {number} by");

                string answer = Console.ReadLine();
                int value = Convert.ToInt32(answer);

                int divide = number / value;
                return divide;
            }
            catch (FormatException e)
            {
                // return number;
                throw;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("YOU CANNOT divide BY zero!!");
               
            }
            finally
            {
                Console.WriteLine("FINALLY in our D.B.Z Method");
            }

            return number;
        }

        static void MethodA()
        {
            try
            {
                Console.WriteLine("I am in A");
                MethodB();
            }
            catch (Exception)
            {
                Console.WriteLine("Caught in Method A");
                throw;
            }
        }

        static void MethodB()
        {
            try
            {
                Console.WriteLine("I am in B");
                MethodC();
            }
            catch (Exception)
            {
                Console.WriteLine("Caught in B");
                throw;
            }
        }

        static void MethodC()
        {
            Console.WriteLine("I am in C");
            throw (new Exception("I am a Exception thrown in C"));

            
        }
    }
}
