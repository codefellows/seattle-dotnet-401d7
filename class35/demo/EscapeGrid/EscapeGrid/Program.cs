using System;
using System.Collections.Generic;

namespace EscapeGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] room = new char[,]
            {
                { 'E', 'E', 'W', 'S' },
                { 'W', 'W', 'S', 'S' },
                { 'S', 'N', 'W', 'W' }
            };
            List<string> path = EscapeGrid(room, 1, 2);

            foreach (var item in path)
            {
                Console.Write($"{item} => ");
            }

            Console.WriteLine();
           List<string> infinate = EscapeGrid(room, 0, 0);

            foreach (var item in infinate)
            {
                Console.Write($"{item} => ");

            }
        }

        static List<string> EscapeGrid(char[,] room, int i, int j)
        {
            int rows = room.GetLength(0);
            int columns = room.GetLength(1);
            int counter = 0;
            List<string> path = new List<string>();
            while (counter < (rows * columns) + 1)
            {
                if ((i >= 0 && i < rows && j >= 0 && j < columns))
                {
                    char direction = room[i, j];
                    switch (direction)
                    {
                        case 'N':
                            i--;
                            path.Add("N");
                            break;
                        case 'E':
                            j++;
                            path.Add("E");

                            break;
                        case 'S':
                            i++;
                            path.Add("S");

                            break;
                        case 'W':
                            j--;
                            path.Add("W");

                            break;
                    }
                }
                else
                {
                    path.Add("YOU HAVE ESCAPED!");
                    return path;
                }
                counter++;
            }

            path.Add("You have reached a loop!");
            return path;
        }
    }
}
