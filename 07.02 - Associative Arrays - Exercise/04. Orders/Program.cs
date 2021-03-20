using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main()
        {
            //string input;

            //Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            //while ((input = Console.ReadLine()) != "buy")
            //{
            //    var productInfo = input.Split();

            //    string productName = productInfo[0];
            //    double productPrice = double.Parse(productInfo[1]);
            //    int productQuantity = int.Parse(productInfo[2]);

            //    if (!products.ContainsKey(productName))
            //    {
            //        products[productName] = new List<double>();
            //        products[productName].Add(productPrice);
            //        products[productName].Add(productQuantity);
            //    }
            //    else
            //    {
            //        if (productPrice != products[productName][0])
            //        {
            //            products[productName][0] = productPrice;
            //        }

            //        products[productName][1] += productQuantity;
            //    }
            //}

            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            //}



            string input;

            Dictionary<string, Product> productsInfo = new Dictionary<string, Product>();

            while ((input = Console.ReadLine()) != "buy")
            {
                var currProductInfo = input.Split();

                string productName = currProductInfo[0];
                double productPrice = double.Parse(currProductInfo[1]);
                int productQuantity = int.Parse(currProductInfo[2]);

                if (productsInfo.ContainsKey(productName))
                {
                    productsInfo[productName].Quantity += productQuantity;

                    if (productPrice != productsInfo[productName].Price)
                    {
                        productsInfo[productName].Price = productPrice;
                    }
                }
                else
                {
                    productsInfo.Add(productName, new Product(productName, productPrice, productQuantity)); 
                }
            }

            foreach (var item in productsInfo)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Price * item.Value.Quantity:f2}");
            }
        }

        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public Product(string productName, double productPrice, int productQuantity)
            {
                Name = productName;
                this.Price = productPrice;
                this.Quantity = productQuantity;
            }
        }
    }
}
