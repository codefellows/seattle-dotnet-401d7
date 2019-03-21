using System;
using System.IO;

namespace FileManipClass03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CreateFile();
            // ReadFile();
            // UpdateFile();
            // DeleteFile();
            Delimeters();
        }

        /// <summary>
        /// Creates a file in the designated location
        /// </summary>
        static void CreateFile()
        {
            string path = "../../../myText.txt";

            string[] names = { "Ariel", "Elsa", "Merida", "Snow White" };

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string line in names)
                {
                    sw.WriteLine(line);
                }

            }
        }

        static void ReadFile()
        {
            string path = "../../../myText.txt";

            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

            }

            Console.WriteLine("------------");
            Console.WriteLine("THE EASIER WAY!!");

            string[] words = File.ReadAllLines(path);

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }


        static void UpdateFile()
        {
            string path = "../../../myText.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Cinderella");
                int x = 0;
                while (x < 5)
                {
                    sw.WriteLine(x++);
                }
            }
        }

        static void DeleteFile()
        {
            string path = "../../../myText.txt";

            File.Delete(path);
        }

        static void Delimeters()
        {
            char[] characters = { ' ', ',', '.', ':', '\t' };
            string text = "one\ttwo three:four,five six.seven";
            string[] words = text.Split(characters);
            string newWord = "amanda  really likes cats";

            string[] catts = newWord.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(catts[i]);
            }

        }
    }
}
