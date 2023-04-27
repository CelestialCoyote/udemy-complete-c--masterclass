using System;
using System.IO;
using System.Text.RegularExpressions;


namespace RegexExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string pattern = @"\d";
            //Regex regex = new Regex(pattern);
            //string text = "Hi there, my number is 12314";

            //MatchCollection matchCollection = regex.Matches(text);

            //Console.WriteLine($"{matchCollection.Count} hits found: {text}");

            //foreach (Match hit in matchCollection)
            //{
            //    GroupCollection group = hit.Groups;
            //    Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            //}


            string pattern = @"\d{2,3}";
            Regex regex = new Regex(pattern);
            string text = File.ReadAllText(@"/Users/Coyote/Documents/_CoyoteFiles/Programming/C#/udemy_CompleteC#Materclass/Section11/input2.txt");

            MatchCollection matchCollection = regex.Matches(text);

            foreach (Match match in matchCollection)
            {
                GroupCollection group = match.Groups;
                int number = Int32.Parse(group[0].Value);
                Console.Write((char)number);
            }

            Console.ReadKey();
        }
    }
}
