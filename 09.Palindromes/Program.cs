using System;
using System.Linq;

namespace _09.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input == "END")
                {
                    break;
                }
                char[] arr = input.ToCharArray();
                char[] arr2 = input.Reverse().ToArray();
                bool isEqual = true;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != arr2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
                if (isEqual)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }
    }
}
