using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            string Operator = Console.ReadLine();
            double n2 = double.Parse(Console.ReadLine());
            double result = Calculate(n1, Operator, n2);
            Console.WriteLine(result);
        }
        static double Calculate(double n1, string Operator, double n2)
        {
            double total = 0;
            if (Operator == "/")
            {
                total = n1 / n2;
            }
            else if (Operator == "*")
            {
                total = n1 * n2;
            }
            else if (Operator == "+")
            {
                total = n1 + n2;
            }
            else if (Operator == "-")
            {
                total = n1 - n2;
            }
            return total;
        }
    }
}
