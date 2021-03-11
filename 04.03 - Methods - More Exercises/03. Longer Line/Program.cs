using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            
            if (FindLineOneLenght(x1, y1, x2, y2) >= FindLineTwoLenght(x3, y3, x4, y4))
            {
                if (FindClosestPointInFirstLine(x1, y1, x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (FindClosestPointInSecondLine(x3, y3, x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
        static bool FindClosestPointInFirstLine(double x1, double y1, double x2, double y2)
        {
            double firstPoint = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPoint = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            bool isFirst = false;

            if (firstPoint <= secondPoint)
            {
                isFirst = true; ;
            }

            return isFirst;
        }
        static bool FindClosestPointInSecondLine(double x3, double y3, double x4, double y4)
        {
            double firstPoint = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
            double secondPoint = Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));

            bool isFirst = false;

            if (firstPoint <= secondPoint)
            {
                isFirst = true; ;
            }

            return isFirst;
        }
        static double FindLineOneLenght(double x1, double y1, double x2, double y2)
        {
            double lineOneLenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return lineOneLenght;
        }
        static double FindLineTwoLenght(double x3, double y3, double x4, double y4)
        {
            double lineTwoLenght = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            return lineTwoLenght;
        }
    }
}
