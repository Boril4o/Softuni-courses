using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            // TO DO
            // when swap two lessons if one of them has exercise need to swap with execise

            List<string> lessons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string cmd = "";
            while (cmd != "course start")
            {
                cmd = Console.ReadLine();
                string[] command = cmd
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string lessonTitle = "";
                bool isContains = lessons.Contains(lessonTitle);
                if (command[0] == "Add")
                {
                    lessonTitle = command[1];
                    if (isContains) continue;

                    lessons.Add(lessonTitle);
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[2]); 
                    lessonTitle = command[1];
                    if (isContains) continue;

                    lessons.Insert(index, lessonTitle);
                }
                else if (command[0] == "Remove")
                {
                    lessonTitle = command[1];
                    if (isContains) continue;

                    lessons.Remove(lessonTitle);
                }
                else if (command[0] == "Swap")
                {
                    string secondLessonTitle = command[2];
                    lessonTitle = command[1];
                    if (!isContains && !lessons.Contains(secondLessonTitle)) continue;

                    if (lessonTitle == $"{lessonTitle}-Exercise" ||
                        secondLessonTitle == $"{secondLessonTitle}-Exercise")
                    {

                    }

                    swap(lessonTitle, secondLessonTitle, lessons);
                }
                else if (command[0] == "Exercise")
                {
                    lessonTitle = command[1];
                    if (isContains)
                    {
                        int index = lessons.IndexOf(lessonTitle) + 1;
                        lessons.Insert(index, $"{lessonTitle}-Exercise");
                    }
                    else
                    {
                        lessons.Add(lessonTitle);
                        lessons.Add($"{lessonTitle}-Exercise");
                    }
                }

            }
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
        static void swap(string firstTitle, string secondTitle, List<string> lessons)
        {
            int firstTitleIndex = lessons.IndexOf(firstTitle);
            int secondTitleIndex = lessons.IndexOf(secondTitle);
            lessons.Insert(firstTitleIndex, firstTitle);
            lessons.RemoveAt(firstTitleIndex + 1);
            lessons.Insert(secondTitleIndex, secondTitle);
            lessons.RemoveAt(secondTitleIndex + 1);
        }
    }
}
