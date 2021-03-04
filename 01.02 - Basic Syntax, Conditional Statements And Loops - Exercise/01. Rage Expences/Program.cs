using System;

namespace _1.RageExpences
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenses = 0;
            int counter = 0;

            for (int game = 1; game <= lostGamesCount; game++)
            {
                if (game % 2 == 0)
                {
                    expenses += headsetPrice;
                }
                if (game % 3 == 0)
                {
                    expenses += mousePrice;
                }
                if (game % 2 == 0 && game % 3 == 0)
                {
                    expenses += keyboardPrice;
                    counter++;

                    if (counter % 2 == 0)
                    {
                        expenses += displayPrice;
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
