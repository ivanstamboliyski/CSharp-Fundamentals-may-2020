using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();
            Dictionary<string, int> junkItems = new Dictionary<string, int>();

            legendaryItems["shards"] = 0;
            legendaryItems["fragments"] = 0;
            legendaryItems["motes"] = 0;

            int quantity = 0;
            string material = string.Empty;
            string obtainedItem = string.Empty;
            bool end = false;

            while (true)
            {
                string[] line = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < line.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(line[i]);
                        continue;
                    }
                    else
                    {
                        material = line[i];
                    }

                    if (material == "shards")
                    {
                        legendaryItems["shards"] += quantity;

                        if (legendaryItems["shards"] >= 250)
                        {
                            legendaryItems["shards"] -= 250;
                            obtainedItem = "Shadowmourne";
                            end = true;
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        legendaryItems["fragments"] += quantity;

                        if (legendaryItems["fragments"] >= 250)
                        {
                            legendaryItems["fragments"] -= 250;
                            obtainedItem = "Valanyr";
                            end = true;
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        legendaryItems["motes"] += quantity;

                        if (legendaryItems["motes"] >= 250)
                        {
                            legendaryItems["motes"] -= 250;
                            obtainedItem = "Dragonwrath";
                            end = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(material))
                        {
                            junkItems[material] = quantity;
                        }
                        else
                        {
                            junkItems[material] += quantity;
                        }
                    }
                }
                if (end)
                {
                    break;
                }
            }

            Console.WriteLine($"{obtainedItem} obtained!");

            foreach (var item in legendaryItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
