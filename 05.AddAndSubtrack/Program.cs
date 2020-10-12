using System;

namespace _05.AddAndSubtrack
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            AddAndSubtrack(n1, n2, n3);
        }

        static int Add(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }
        static void AddAndSubtrack(int n1, int n2, int n3)
        {
            int result = Add(n1, n2);
            result -= n3;
            Console.WriteLine(result);
        }
    }
}
