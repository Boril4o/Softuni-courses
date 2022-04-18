using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] courseInfo = input
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = courseInfo[0];
                string student = courseInfo[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }

                courses[courseName].Add(student);
                input = Console.ReadLine();
            }

            courses = courses
                .OrderByDescending(course => course.Value.Count)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var member in course.Value.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }
    }
}
