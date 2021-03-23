using System;
using System.Linq;
using System.Text;


namespace _02._01.ValidUsernames_Exercise
{
    class Program
    {
        static void Main()
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var username in usernames)
            {
                bool isValid = true;

                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }

                for (int i = 0; i < username.Length; i++)
                {
                    if (!char.IsLetterOrDigit(username[i]) &&
                        username[i] != '-' &&
                        username[i] != '_')
                    {
                        isValid = false;
                        break;
                    }
                }
                
                if (isValid)
                {
                    Console.WriteLine(username.ToString());
                }
            }
        }
    }
}
