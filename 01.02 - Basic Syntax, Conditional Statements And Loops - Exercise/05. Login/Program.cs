using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string password = "";

            for (int digit = 0; digit < userName.Length; digit++)
            {
                char currDigit = userName[digit];
                password = currDigit + password;
            }

            string currPassword = Console.ReadLine();
            int wrongPass = 0;

            while (currPassword != password)
            {
                wrongPass++;

                if (wrongPass == 4)
                {
                    Console.WriteLine($"User {userName} blocked! ");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");

                currPassword = Console.ReadLine();
            }

            Console.WriteLine($"User {userName} logged in.");
        }
    }
}
