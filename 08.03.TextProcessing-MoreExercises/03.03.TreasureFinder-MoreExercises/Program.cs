using System;
using System.Linq;
using System.Text;

namespace _03._03.TreasureFinder_MoreExercise
{
    class Program
    {
        static void Main()
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string message;
            StringBuilder decrypted = new StringBuilder();
            string type;
            string coordinates;

            while ((message = Console.ReadLine()) != "find")
            {
                int counter = 0;

                for (int i = 0; i < message.Length; i++)
                {
                    int symbol = message[i] - key[counter];
                    decrypted.Append((char)symbol);
                    counter++;

                    if (counter == key.Length)
                    {
                        counter = 0;
                    }
                }

                type = decrypted.ToString().Substring(decrypted.ToString().IndexOf('&') + 1, decrypted.ToString().LastIndexOf('&') - decrypted.ToString().IndexOf('&') - 1);

                coordinates = decrypted.ToString().Substring(decrypted.ToString().IndexOf('<') + 1, decrypted.ToString().LastIndexOf('>') - decrypted.ToString().IndexOf('<') - 1);

                Console.WriteLine($"Found {type} at {coordinates}");

                decrypted.Clear();
            }
        }
    }
}
