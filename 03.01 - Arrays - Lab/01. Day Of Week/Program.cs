using System;

namespace _03._1.Arrays_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = 
            {
             "Monday",
             "Tuesday",
             "Wednesday",
             "Thursday",
             "Friday",
             "Saturday",
             "Sunday"
            };

            int day = int.Parse(Console.ReadLine());

            if (day > 0 && day < 8)
            {
                Console.WriteLine(days[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
