﻿using System;
using System.Collections;


namespace HashTables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 76);
            Student stud3 = new Student(3, "Clara", 43);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentsTable[1];

            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;

                Console.WriteLine($"Student ID: {temp.Id}, Name: {temp.Name}, GPA: {temp.GPA}");
            }

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine($"Student ID: {value.Id}, Name: {value.Name}, GPA: {value.GPA}");
            }

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");

            Console.WriteLine($"Student ID: {storedStudent1.Id}, Name: {storedStudent1.Name}, GPA: {storedStudent1.GPA}");

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");

            // Challenge.

            Student[] students = new Student[5];
            students[0] = new Student(1, "Denis", 88);
            students[1] = new Student(2, "Olaf", 97);
            students[2] = new Student(6, "Ragner", 65);
            students[3] = new Student(1, "Luise", 73);
            students[4] = new Student(4, "Levi", 58);

            Hashtable studentsTable2 = new Hashtable();

            foreach (Student student in students)
            {
                if (!studentsTable2.ContainsKey(student.Id))
                {
                    studentsTable2.Add(student.Id, student);
                    Console.WriteLine($"Student with ID: {student.Id} added.");
                }
                else
                    Console.WriteLine($"Student with ID: {student.Id} already exists.");
            }


            Console.ReadKey();
        }
    }


    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}
