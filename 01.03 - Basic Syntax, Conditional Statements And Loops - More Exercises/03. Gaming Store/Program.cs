using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string gameName = Console.ReadLine();

            double totalSpent = 0;

            while (gameName != "Game Time")
            {
                if (gameName == "OutFall 4")
                {
                    if (budget < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "CS: OG")
                {
                    if (budget < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 15.99;
                        totalSpent += 15.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    if (budget < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 19.99;
                        totalSpent += 19.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "Honored 2")
                {
                    if (budget < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 59.99;
                        totalSpent += 59.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "RoverWatch")
                {
                    if (budget < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 29.99;
                        totalSpent += 29.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    if (budget < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        budget -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                gameName = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${budget:F2}");
        }
    }
}
