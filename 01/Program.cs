using System;
using System.Buffers;
using System.ComponentModel;
using System.Linq;
namespace Methods
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            PasswordValidator(password);
        }
        static void PasswordValidator(string password)
        {
            bool isBetween6and10 = false;
            bool consistsOfDigitsAndletters = true;
            bool hasAtLeastTwoDigits = false;
            if (password.Length >= 6 && password.Length <= 10)
            {
                isBetween6and10 = true;
            }
            int digitCounter = 0;
            char[] arr = password.ToLower().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 48 && arr[i] <= 57)
                {
                    digitCounter++;
                }
                else if (arr[i] >= 97 && arr[i] <= 122)
                {
                    if (digitCounter >= 1)
                    {
                        consistsOfDigitsAndletters = true;
                    }
                }
                else
                {
                    consistsOfDigitsAndletters = false;
                    break;
                }
            }
            if (digitCounter >= 2)
            {
                hasAtLeastTwoDigits = true;
            }
            if (isBetween6and10 == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (consistsOfDigitsAndletters == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (hasAtLeastTwoDigits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isBetween6and10 == true && hasAtLeastTwoDigits == true && consistsOfDigitsAndletters == true)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
