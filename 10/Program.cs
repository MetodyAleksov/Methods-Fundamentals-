using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FindTopNum(n);
        }
        static void FindTopNum(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string currentNum = i.ToString();
                bool hasOddNum = false;
                int result = 0;
                foreach (var current in currentNum)
                {
                    int parseNum = (int)current;
                    if (parseNum % 2 == 1)
                    {
                        hasOddNum = true;
                    }
                    result += parseNum;
                }
                if (result % 8 == 0 && hasOddNum == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
