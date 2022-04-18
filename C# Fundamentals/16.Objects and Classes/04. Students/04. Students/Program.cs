using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int age { get; set; }

        public string homeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] studentInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string town = studentInfo[3];

                student student = new student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.age = age;
                student.homeTown = town;

                students.Add(student);

                input = Console.ReadLine();
            }

            string city = Console.ReadLine();
            foreach (student student in students)
            {
                if (student.homeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.age} years old.");
                }
            }
        }
    }
}
