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
            List<string> list = new List<string>();
            while (command != "end")
            {
                list = command.Split().ToList();
                if (list[0] == "swap")
                {
                    int temp = input[int.Parse(list[1])];
                    input[int.Parse(list[1])] = input[int.Parse(list[2])];
                    input[int.Parse(list[2])] = temp;


                }
                if (list[0] == "multiply")
                {
                    int multiply = input[int.Parse(list[1])] * input[int.Parse(list[2])];
                    input[int.Parse(list[1])] = multiply;
                }
                if (list[0] == "decrease")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        input[i]--;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", input));
        }
    }
}
