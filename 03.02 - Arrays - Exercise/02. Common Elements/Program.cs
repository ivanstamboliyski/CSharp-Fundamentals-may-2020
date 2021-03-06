using System;
using System.Linq;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split().ToArray();
            string[] arrTwo = Console.ReadLine().Split().ToArray();

            string result = string.Empty;

            //for (int i = 0; i < arrTwo.Length; i++)
            //{
            //    for (int j = 0; j < arrOne.Length; j++)
            //    {
            //        if (arrTwo[i] == arrOne[j])
            //        {
            //            result += arrTwo[i] + " ";
            //        }
            //    }
            //}

            //Console.WriteLine(result);

            foreach (string item in arrTwo)
            {
                foreach (string item1 in arrOne)
                {
                    if (item == item1)
                    {
                        result += item + " ";
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
