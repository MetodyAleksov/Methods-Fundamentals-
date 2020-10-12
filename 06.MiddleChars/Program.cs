using System;

namespace _06.MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            GetMiddleChar(word);
        }

        private static void GetMiddleChar(string word)
        {
            char[] arr = word.ToCharArray();
            if (arr.Length % 2 == 0)
            {
                Console.WriteLine($"{arr[arr.Length / 2 - 1]}{arr[arr.Length / 2]}");
            }
            else
            {
                Console.WriteLine(arr[(arr.Length / 2)]);
            }
        }
    }
}
