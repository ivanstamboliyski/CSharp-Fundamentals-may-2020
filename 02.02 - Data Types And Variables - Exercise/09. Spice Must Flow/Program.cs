using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());

            int daysCounter = 0;
            int totalAmountSpice = 0;

            while (startingYield >= 100)
            {
                daysCounter++;

                totalAmountSpice += startingYield;
                startingYield -= 10;

                if (totalAmountSpice > 26)
                {
                    totalAmountSpice -= 26;
                }
                else
                {
                    totalAmountSpice -= totalAmountSpice;
                }
            }

            if (totalAmountSpice > 26)
            {
                totalAmountSpice -= 26;
            }
            else
            {
                totalAmountSpice -= totalAmountSpice;
            }

            Console.WriteLine(daysCounter);
            Console.WriteLine(totalAmountSpice);
        }
    }
}
