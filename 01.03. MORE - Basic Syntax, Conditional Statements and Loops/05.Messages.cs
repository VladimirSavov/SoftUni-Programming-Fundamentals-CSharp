using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int messageLenght = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < messageLenght; i++)
            {
                string digits = Console.ReadLine(); 
                int digitLength = digits.Length; 
                int digit = int.Parse(digits[0].ToString());

                int offset = (digit - 2) * 3; 

                if (digit == 0) 
                {
                    message += (char)(digit + 32);
                    continue;
                }

                if (digit == 8 || digit == 9) 
                {
                    offset++;
                }
                int letterIndex = offset + digitLength - 1; 
                message += (char)(letterIndex + 97); 
            }

            Console.WriteLine(message);
        }
    }
}
