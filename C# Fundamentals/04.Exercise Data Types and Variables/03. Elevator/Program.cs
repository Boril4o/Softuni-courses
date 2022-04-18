using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPersons = int.Parse(Console.ReadLine());

            double courses = (int)Math.Ceiling((double)numberOfPeople / capacityOfPersons);

            Console.WriteLine(courses);
        }
    }
}
