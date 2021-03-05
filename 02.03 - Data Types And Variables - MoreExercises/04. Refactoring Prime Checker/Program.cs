using System;

namespace _04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber = int.Parse(Console.ReadLine());

            for (int currNum = 2; currNum <= givenNumber; currNum++)
            {
                bool isPrime = true;

                for (int num = 2; num < currNum; num++)
                {
                    if (currNum % num == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("{0} -> true", currNum);
                }
                else
                {
                    Console.WriteLine("{0} -> false", currNum);
                }
                 
            }
        }
    }
}
