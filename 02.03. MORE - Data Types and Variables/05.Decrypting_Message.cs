using System;
namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string message = string.Empty;
            for (int i = 1; i <= lines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                message += (char)(symbol + key);
            }
            Console.WriteLine(message);
        }
    }
}
