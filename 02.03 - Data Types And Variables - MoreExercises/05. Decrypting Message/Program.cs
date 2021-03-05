using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int inputLines = int.Parse(Console.ReadLine());

            string decryptedMessage = "";

            for (int symbol = 1; symbol <= inputLines; symbol++)
            {
                char currCharacter = char.Parse(Console.ReadLine());

                currCharacter += (char)key;

                decryptedMessage += currCharacter;
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
