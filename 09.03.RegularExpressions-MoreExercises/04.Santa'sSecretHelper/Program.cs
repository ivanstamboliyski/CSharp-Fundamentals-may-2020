using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace MoreExercise._04.Santa_sSecretHelper
{
    class Program
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());

            string message;
            string pattern = @"@(?<name>[A-Za-z]+)[^@!:>-]+!(?<behavior>[G])!";

            while ((message = Console.ReadLine()) != "end")
            {
                char[] decryptedChars = message.ToCharArray().Select(x => x = (char)(x - key)).ToArray();
                string decryptedMessage = new string(decryptedChars);

                Match match = Regex.Match(decryptedMessage, pattern);

                if (match.Success)
                {
                    Console.WriteLine(match.Groups["name"].Value);
                }
            }
        }
    }
}
