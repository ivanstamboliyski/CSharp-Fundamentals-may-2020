using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main()
        {
            string[] personInfo = Console.ReadLine().Split();
            List<Person> persons = new List<Person>();

            while (personInfo[0] != "End")
            {
                Person person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]));

                persons.Add(person);

                personInfo = Console.ReadLine().Split();
            }

            foreach (var person in persons.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
        class Person 
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }

            public Person(string name, string id, int age)
            {
                Name = name;
                ID = id;
                Age = age;
            }
        }
    }
}
