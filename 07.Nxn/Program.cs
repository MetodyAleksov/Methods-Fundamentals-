using System;

namespace _07.Nxn
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NumberOfRows(n);
        }
        static void Rows(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
        }
        static void NumberOfRows(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Rows(n);
            }
        }
    }
}
