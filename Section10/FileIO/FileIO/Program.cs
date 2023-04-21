using System;
using System.IO;


namespace FileIO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Read from a file.
            string text = File.ReadAllText(@"/Users/Coyote/Documents/_CoyoteFiles/Programming/C#/udemy_CompleteC#Materclass/Section10/fileIO.txt");

            Console.WriteLine($"Text file contains: \n{text}");


            string[] lines = File.ReadAllLines(@"/Users/Coyote/Documents/_CoyoteFiles/Programming/C#/udemy_CompleteC#Materclass/Section10/fileIO.txt");

            Console.WriteLine("-------------");

            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.WriteLine("-------------");
            Console.WriteLine("-------------");

            // Write to file.
            string[] lines2 = { "first line", "second line", "third line" };

            File.WriteAllLines(@"/Users/Coyote/Documents/_CoyoteFiles/Programming/C#/udemy_CompleteC#Materclass/Section10/fileIO2.txt", lines2);


            //Console.WriteLine("Ener text to be written to file.");
            //string input = Console.ReadLine();

            //File.WriteAllText(@"/Users/Coyote/Documents/_CoyoteFiles/Programming/C#/udemy_CompleteC#Materclass/Section10/input.txt", input);


            using(StreamWriter file = new StreamWriter(@"/Users/Coyote/Documents/_CoyoteFiles/Programming/C#/udemy_CompleteC#Materclass/Section10/streamwriter_input.txt"))
            {
                foreach (string line in lines2)
                {
                    if (line.Contains("third"))
                        file.WriteLine(line);
                }
            }

            using (StreamWriter file = new StreamWriter(@"/Users/Coyote/Documents/_CoyoteFiles/Programming/C#/udemy_CompleteC#Materclass/Section10/streamwriter_input.txt", true))
            {
                file.WriteLine("Additional line");
            }


            Console.ReadKey();
        }
    }
}
