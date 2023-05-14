using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectsAndQueryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();

            um.MaleStudents();
            um.FemaleStudents();

            um.SortStudentsByAge();
            um.AllStudentsFromBeijingTech();

            um.StudentAndUniversityNameCollections();

            //int[] someInts = { 30, 12, 4, 3, 12 };
            //IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            //IEnumerable<int> reversedInts = sortedInts.Reverse();

            //foreach (int i in reversedInts)
            //{
            //    Console.WriteLine(i);
            //}

            //IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;

            //foreach (int i in reversedInts)
            //{
            //    Console.WriteLine(i);
            //}

            //string input = Console.ReadLine();

            //try
            //{
            //    int inputAsInt = Convert.ToInt32(input);

            //    um.AllStudentsFromThatUniversity(inputAsInt);
            //}
            //catch
            //{
            //    Console.WriteLine("Wrong value");
            //}


            Console.ReadKey();
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University() { Id = 1, Name = "Yale"});
            universities.Add(new University() { Id = 2, Name = "Beijing Tech" });

            students.Add(new Student() { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student() { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student() { Id = 3, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student() { Id = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student() { Id = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
            students.Add(new Student() { Id = 6, Name = "Frank", Gender = "male", Age = 23, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("MaleStudents - Students");

            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("FemaleStudents - Students");

            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Students sorted by Age:");

            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBeijingTech()
        {
            IEnumerable<Student> bjtStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Name == "Beijing Tech"
                                               select student;

            Console.WriteLine("Students from Beijing Tech");

            foreach (Student student in bjtStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUniversity(int Id)
        {
            IEnumerable<Student> myStudents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Id == Id
                                               select student;

            Console.WriteLine("Students from that University");

            foreach (Student student in myStudents)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityNameCollections()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("New Collections: ");

            foreach (var col in newCollection)
            {
                Console.WriteLine($"Student {col.StudentName} from University {col.UniversityName}");
            }
        }
    }

    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine($"University {Name} with id {Id}.");
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine($"Student {Name} with Id {Id}, Gender {Gender} and age {Age} from Uiversity with th Id {UniversityId}.");
        }
    }
}
