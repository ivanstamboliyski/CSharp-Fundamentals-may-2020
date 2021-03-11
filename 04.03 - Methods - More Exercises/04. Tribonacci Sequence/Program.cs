using System;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            FindTribonacciNumsInRange(num);
        }
        static void FindTribonacciNumsInRange(int num) 
        {
            int firstNum = 1;
            int secondNum = 1;
            int thirdNum = 2;

            if (num == 1)
            {
                Console.Write(firstNum + " ");
            }
            else if (num == 2)
            {
                Console.Write(firstNum + " ");
                Console.Write(secondNum + " ");
            }
            else if (num == 3)
            {
                Console.Write(firstNum + " ");
                Console.Write(secondNum + " ");
                Console.Write(thirdNum + " ");
            }
            else
            {
                Console.Write(firstNum + " ");
                Console.Write(secondNum + " ");
                Console.Write(thirdNum + " ");

                for (int i = 4; i <= num; i++)
                {
                    int nextNum = thirdNum + secondNum + firstNum;
                    Console.Write(nextNum + " ");
                    firstNum = secondNum;
                    secondNum = thirdNum;
                    thirdNum = nextNum;
                }
            }
        }
    }
}
