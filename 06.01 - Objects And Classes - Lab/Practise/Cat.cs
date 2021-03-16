using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    class Cat
    {
        public Cat(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public string SayHello() 
        {
            return "Hello from " + Name;
        }
    }
}
