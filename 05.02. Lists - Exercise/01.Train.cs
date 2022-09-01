using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int max = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                int maxCapacity = max;
                List<string> input = command.Split().ToList();
                if(input.Count == 2)
                {
                    wagons.Add(int.Parse(input[1]));                    
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(input[0]) <= maxCapacity)
                        {
                            wagons[i] += int.Parse(input[0]);
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
