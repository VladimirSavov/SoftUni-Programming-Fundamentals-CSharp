using System;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        //add", "multiply", "subtract", "divide"
        static void addCommand(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        static void multiplyCommand(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }
        static void subtractCommand(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        static void divideCommand(int a, int b)
        {
            int result = a / b;
            Console.WriteLine(result);
        }
       
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if(command == "add")
            {
                addCommand(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            else if(command == "multiply")
            {
                multiplyCommand(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            else if (command == "subtract")
            {
                subtractCommand(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
            else
            {
                divideCommand(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }

        }
        
    }
}
