using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                List<string> commands = command.Split().ToList();
                if (commands[0] == "Delete")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (int.Parse(commands[1]) == input[i])
                        {
                            input.RemoveAt(i);
                            i--;
                        }
                    }
                }
                else if (commands[0] == "Insert")
                {
                    input.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
