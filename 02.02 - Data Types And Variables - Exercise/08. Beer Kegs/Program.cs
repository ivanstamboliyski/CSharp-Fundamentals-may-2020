using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLinesNumber = int.Parse(Console.ReadLine());

            double biggestVolume = double.MinValue;
            string biggestKeg = string.Empty;

            for (int keg = 1; keg <= inputLinesNumber; keg++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (kegVolume > biggestVolume)
                {
                    biggestVolume = kegVolume;
                    biggestKeg = kegModel;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
