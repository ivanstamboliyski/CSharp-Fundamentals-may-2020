using System;
using System.Collections.Generic;

namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            string[] persons = Console.ReadLine().Split(";");
            string[] products = Console.ReadLine().Split(";");

            Dictionary<string, Person> personsPurchases = new Dictionary<string, Person>();
            Dictionary<string, Product> allProducts = new Dictionary<string, Product>();

            for (int i = 0; i < persons.Length; i++)
            {
                personsPurchases.Add(persons[i].Split("=")[0], new Person(persons[i].Split("=")[0], double.Parse(persons[i].Split("=")[1])));
            }

            for (int i = 0; i < products.Length; i++)
            {
                allProducts.Add(products[i].Split("=")[0], new Product(products[i].Split("=")[0], double.Parse(products[i].Split("=")[1])));
            }

            string commands;

            while ((commands = Console.ReadLine()) != "END")
            {
                string[] currCommand = commands.Split();

                personsPurchases[currCommand[0]].ByingProducts(allProducts[currCommand[1]]);
            }

            foreach (var person in personsPurchases)
            {
                Console.Write($"{person.Value.Name} - ");
                if (person.Value.Products.Count == 0)
                {
                    Console.WriteLine("Nothing bought");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", person.Value.Products));
                }
            }
        }
    }
    class Person 
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> Products { get; set; }

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            Products = new List<string>();
        }
        public void ByingProducts(Product product) 
        {
            if (this.Money < product.Cost)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                this.Money -= product.Cost;
                Products.Add(product.Name);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
        }
    }
    class Product 
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
