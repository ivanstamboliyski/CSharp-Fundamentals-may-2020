using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();

            decimal sum = 0;

            while (coin != "Start")
            {
                if (coin == "0.1" || coin == "0.2" || coin == "0.5" || coin == "1" || coin == "2")
                {
                    sum += decimal.Parse(coin);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                coin = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product == "Nuts" || product == "Water" || product == "Crisps" || product == "Soda" || product == "Coke")
                {
                    if (product == "Nuts" && sum >= 2)
                    {
                        sum -= 2;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else if (product == "Water" && sum >= 0.70m)
                    {
                        sum -= 0.70m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else if (product == "Crisps" && sum >= 1.50m)
                    {
                        sum -= 1.50m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else if (product == "Soda" && sum >= 0.80m)
                    {
                        sum -= 0.80m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else if (product == "Coke" && sum >= 1.00m)
                    {
                        sum -= 1.00m;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
