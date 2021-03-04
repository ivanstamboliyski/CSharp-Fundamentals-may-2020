using System;

namespace _03.Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (day == "Friday")
            {
                if (groupType == "Students")
                {
                    price = 8.45;
                }
                else if (groupType == "Business")
                {
                    price = 10.90;
                }
                else if (groupType == "Regular")
                {
                    price = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (groupType == "Students")
                {
                    price = 9.80;
                }
                else if (groupType == "Business")
                {
                    price = 15.60;
                }
                else if (groupType == "Regular")
                {
                    price = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (groupType == "Students")
                {
                    price = 10.46;
                }
                else if (groupType == "Business")
                {
                    price = 16;
                }
                else if (groupType == "Regular")
                {
                    price = 22.50;
                }
            }

            double totalPrice = price * groupCount;

            if (groupType == "Students" && groupCount >= 30)
            {
                totalPrice *= 0.85;
            }
            else if (groupType == "Business" && groupCount >= 100)
            {
                totalPrice = totalPrice - 10 * price;
            }
            else if (groupType == "Regular" && groupCount >= 10 && groupCount <= 20)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
         }
    }
}
