using System;
using System.Linq;

namespace _03.Substring
{
    class Program
    {
        static void Main()
        {
            string removeWord = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            int index = text.IndexOf(removeWord);

            while (index != -1)
            {
                text = text.Remove(index, removeWord.Length);
                index = text.IndexOf(removeWord);
            }

            Console.WriteLine(text);
        }
    }
}
