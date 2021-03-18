using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamil_Member
{
    class Program
    {
        static void Main()
        {
            int peopleCount = int.Parse(Console.ReadLine());

            Family member = new Family();

            for (int currPerson = 0; currPerson < peopleCount; currPerson++)
            {
                string personInfo = Console.ReadLine();
                string personName = personInfo.Split()[0];
                int personAge = int.Parse(personInfo.Split()[1]);

                Person person = new Person(personName, personAge);

                member.AddMember(person);

            }

            var oldestPersonName = member.GetOldestMember().Name;
            var oldestPersonAge = member.GetOldestMember().Age;

            Console.WriteLine(oldestPersonName + " " + oldestPersonAge);
        }
    }

    class Family
    {
        public List<Person> People  { get; set; }

        public Family()
        {
            People = new List<Person>();
        }
        public void AddMember(Person member)
        {

            People.Add(member);
        }
        public Person GetOldestMember()
        {
            return People.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
