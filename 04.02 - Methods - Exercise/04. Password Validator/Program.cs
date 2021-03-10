using System;
using System.Linq;

namespace _04.PasswordValidator
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    string password = Console.ReadLine();

        //    bool isProperLenght = false;
        //    bool doesContainOnlyDigitsAndLetters = false;
        //    bool doesContainTwoDigits = false;

        //    if (CheckPasswordLenght(password, isProperLenght) && CheckDoesItContainOnlyDigitsAndLetters(password, doesContainOnlyDigitsAndLetters) && CheckDoesItContainAtLeastTwoDigits(password, doesContainTwoDigits))
        //    {
        //        Console.WriteLine("Password is valid");
        //    }
        //    else
        //    {
        //        if (!CheckPasswordLenght(password, isProperLenght))
        //        {
        //            Console.WriteLine("Password must be between 6 and 10 characters");
        //        }
        //        if (!CheckDoesItContainOnlyDigitsAndLetters(password, doesContainOnlyDigitsAndLetters))
        //        {
        //            Console.WriteLine("Password must consist only of letters and digits");
        //        }
        //        if (!CheckDoesItContainAtLeastTwoDigits(password, doesContainTwoDigits))
        //        {
        //            Console.WriteLine("Password must have at least 2 digits");
        //        }
        //    }
        //}
        //static bool CheckPasswordLenght(string password, bool isProperLenght) 
        //{
        //    if (password.Length >= 6 && password.Length <= 10)
        //    {
        //        isProperLenght = true;
        //    }

        //    return isProperLenght;
        //}
        //static bool CheckDoesItContainOnlyDigitsAndLetters(string password, bool doesContainOnlyDigitsAndLetters) 
        //{
        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        if ((password[i] >= '0' && password[i] <= '9') || (password[i] >= 'A' && password[i] <= 'Z') || (password[i] >= 'a' && password[i] <= 'z'))
        //        {
        //            doesContainOnlyDigitsAndLetters = true;
        //        }
        //        else
        //        {
        //            doesContainOnlyDigitsAndLetters = false;
        //            break;
        //        }
        //    }

        //    return doesContainOnlyDigitsAndLetters;
        //}
        //static bool CheckDoesItContainAtLeastTwoDigits(string password, bool doesContainTwoDigits) 
        //{
        //    int counter = 0;

        //    for (int i = 0; i < password.Length; i++)
        //    {
        //        if (password[i] >= '0' && password[i] <= '9')
        //        {
        //            counter++;
        //        }
        //    }

        //    if (counter >= 2)
        //    {
        //        doesContainTwoDigits = true;
        //    }

        //    return doesContainTwoDigits;
        //}


        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isProperLenght = false;
            bool doesContainOnlyDigitsAndLetters = false;
            bool doesContainTwoDigits = false;

            if (CheckPasswordLenght(password, isProperLenght) && CheckDoesItContainOnlyDigitsAndLetters(password, doesContainOnlyDigitsAndLetters) && CheckDoesItContainAtLeastTwoDigits(password, doesContainTwoDigits))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!CheckPasswordLenght(password, isProperLenght))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!CheckDoesItContainOnlyDigitsAndLetters(password, doesContainOnlyDigitsAndLetters))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (!CheckDoesItContainAtLeastTwoDigits(password, doesContainTwoDigits))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        static bool CheckPasswordLenght(string password, bool isProperLenght)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                isProperLenght = true;
            }

            return isProperLenght;
        }
        static bool CheckDoesItContainOnlyDigitsAndLetters(string password, bool doesContainOnlyDigitsAndLetters)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password.All(Char.IsLetterOrDigit))
                {
                    doesContainOnlyDigitsAndLetters = true;
                }
                else
                {
                    doesContainOnlyDigitsAndLetters = false;
                    break;
                }
            }

            return doesContainOnlyDigitsAndLetters;
        }
        static bool CheckDoesItContainAtLeastTwoDigits(string password, bool doesContainTwoDigits)
        {
            if (password.Count(Char.IsDigit) >= 2)
            {
                doesContainTwoDigits = true;
            }

            return doesContainTwoDigits;
        }

    }
}
