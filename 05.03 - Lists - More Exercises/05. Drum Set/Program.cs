using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> initialQuality = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> usedDrums = new List<int>();

            for (int i = 0; i < initialQuality.Count; i++)
            {
                usedDrums.Add(initialQuality[i]);
            }

            string input = string.Empty;

            //while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            //{
            //    int hitPower = int.Parse(input);

            //    for (int i = 0; i < usedDrums.Count; i++)
            //    {
            //        if (usedDrums[i] > 0)
            //        {
            //            usedDrums[i] -= hitPower;
            //        }

            //        if (usedDrums[i] < 1)
            //        {
            //            int drumPrice = initialQuality[i] * 3;

            //            if (drumPrice <= savings)
            //            {
            //                savings -= drumPrice;
            //                usedDrums[i] = initialQuality[i];
            //            }
            //            else
            //            {
            //                usedDrums[i] = 0;
            //            }
            //        }
            //    }
            //}

            //usedDrums.RemoveAll(n => n == 0);

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < usedDrums.Count; i++)
                {
                    usedDrums[i] -= hitPower;

                    if (usedDrums[i] < 1)
                    {
                        int drumPrice = initialQuality[i] * 3;

                        if (drumPrice <= savings)
                        {
                            savings -= drumPrice;
                            usedDrums[i] = initialQuality[i];
                        }
                        else
                        {
                            usedDrums.RemoveAt(i);
                            initialQuality.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", usedDrums));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
