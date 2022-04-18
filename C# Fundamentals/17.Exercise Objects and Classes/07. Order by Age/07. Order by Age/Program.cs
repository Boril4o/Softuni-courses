using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        private string Name_;
        private string ID_;
        private int Age_;

        public Person(string name, string ID, int age)
        {
            this.Name_ = name;
            this.ID_ = ID;
            this.Age_ = age;
        }

        public string Name { get => Name_; set => Name_ = value; }

        public string ID { get => ID_; set => ID_ = value; }

        public int Age { get => Age_; set => Age_ = value; }

        public override string ToString() => $"{Name} with ID: {ID} is {Age} years old.";
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] personInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                string ID = personInfo[1];
                int age = int.Parse(personInfo[2]);

                if (people.Any(person => person.ID == ID))
                {
                    EditPerson(people, ID, name, age);
                    input = Console.ReadLine();
                    continue;
                }

                Person person = new Person(name, ID, age);
                people.Add(person);
                input = Console.ReadLine();
            }

            people.OrderBy(person => person.Age).ToList().ForEach(Console.WriteLine);
        }
        static void EditPerson(List<Person> people, string ID, string name, int age)
        {
            foreach (Person person in people)
            {
                if (person.ID == ID)
                {
                    int index = people.IndexOf(person);
                    Person newPerson = new Person(name, ID, age);
                    people[index] = newPerson;
                    return;
                }
            }
        }
    }
}
