using System;
namespace Members
{
    public class Member
    {
        private string memberName;
        private string jobTitle;
        private int salary;


        public int age;

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}, my job title is {jobTitle}, and I am {age} years old.");
        }


        public Member()
        {
            age = 30;
            memberName = "Tikaa";
            salary = 60000;
            jobTitle = "Woofer";

            Console.WriteLine("Object created");
        }

        ~Member()
        {
            Console.WriteLine("Deconstructor called");
        }
    }
}
