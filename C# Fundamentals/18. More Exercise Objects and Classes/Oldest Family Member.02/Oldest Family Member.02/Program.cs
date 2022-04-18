using System;
using System.Collections.Generic;
using System.Linq;

namespace Oldest_Family_Member._02
{
    class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name { get => _name; set => _name = value; }

        public int Age { get => _age; set => _age = value; }

        public override string ToString() => $"{Name} {Age}";
    }

    class Family
    {
        private List<Person> FamilyMembers = new List<Person>();

        public void AddMember(Person person) =>  FamilyMembers.Add(person); 

        public Person GetOldestMember(Family family)
        {
            return FamilyMembers.Find(person => person.Age == family.FamilyMembers.Max(person1 => person1.Age));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            Console.WriteLine(family.GetOldestMember(family));
        }
    }
}