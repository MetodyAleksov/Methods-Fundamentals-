using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();

            GetMax(type, n1, n2);
        }
        static void GetMax(string type, string n1, string n2)
        {
            if (type == "int")
            {
                if (int.Parse(n1) >= int.Parse(n2))
                {
                    Console.WriteLine(n1);
                }
                else
                {
                    Console.WriteLine(n2);
                }
            }
            else if (type == "char")
            {
                if (char.Parse(n1) > char.Parse(n2))
                {
                    Console.WriteLine(n1);
                }
                else
                {
                    Console.WriteLine(n2);
                }
            }
            else if (type == "string")
            {
                char[] arr = n1.ToArray();
                char[] arr2 = n2.ToArray();
                if (arr.Length == arr2.Length)
                {
                    int sum1 = 0;
                    int sum2 = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        sum1 += arr[i];
                    }
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        sum2 += arr2[i];
                    }
                    if (sum1 > sum2)
                    {
                        Console.WriteLine(n1);
                    }
                    else
                    {
                        Console.WriteLine(n2);
                    }
                }
                else if (arr.Length > arr2.Length)
                {
                    Console.WriteLine(n1);
                }
                else
                {
                    Console.WriteLine(n2);
                }
            }
        }
    }
}
