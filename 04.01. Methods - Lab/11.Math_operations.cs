using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string operatior = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double result = Calculate(a, operatior, b);
            Console.WriteLine(result);

        }
        static double Calculate(int a, string operatior, int b)
        {
            double result = 0;
            switch (operatior)
            {
                case ("/"):
                    result = a / b;
                    break;
                    case ("-"):
                    result = a - b;
                    break;
                case ("+"):
                    result = a + b;
                    break;
                    case("*"):
                    result = a * b;
                    break;
            }
            return result;
        }
    }
}
