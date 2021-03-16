using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StoreBoxes
{
    class Program
    {
        static void Main()
        {  
            List<Box> boxes = new List<Box>();
            //List<Item> items = new List<Item>();
            string[] inputData = Console.ReadLine().Split();

            while (inputData[0] != "end")
            {
                string itemName = inputData[1];
                decimal itemPrice = decimal.Parse(inputData[3]);
                string serialNumber = inputData[0];
                int itemQuantity = int.Parse(inputData[2]);

                Box box = new Box();

                box.Item.Name = itemName;
                box.Item.Price = itemPrice;

                box.SerialNumber = serialNumber;
                box.ItemQuantity = itemQuantity;
                box.PriceForBox = itemPrice * itemQuantity;

                boxes.Add(box);

                inputData = Console.ReadLine().Split();
            }

            List<Box> orderedBoxes = boxes.OrderByDescending(o => o.PriceForBox).ToList();

            foreach (Box box in orderedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }
        }
    }
    class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForBox { get; set; }

    }
}
