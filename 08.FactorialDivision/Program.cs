using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
        }
        static long GetFact(int n)
        {
            long fact = n;
            for (int i = n-1; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }
        static void Result(int n1, int n2)
        {
            double result1 = GetFact(n1);
            double result2 = GetFact(n1);
            double totalResult = result1 / result2;
            Console.WriteLine(totalResult);
        }
    }
}
