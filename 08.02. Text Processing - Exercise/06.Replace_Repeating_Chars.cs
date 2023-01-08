using System;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 1; i < input.Length; i++)
            {
                string output = "";
                char c = input[i];
                char previous = input[i - 1];
                if (input.IndexOf(c) == input.IndexOf(previous))
                {
                    output = input.Remove(i, 1);
                    input = output;
                    i--;

                }
            }
            Console.WriteLine(input);
        }       
    }
}
