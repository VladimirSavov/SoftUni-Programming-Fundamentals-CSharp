using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" : ").ToArray();
            Dictionary<string, List<string>> courseData = new Dictionary<string, List<string>>();
            while (input[0] != "end")
            {
                if (!courseData.ContainsKey(input[0]))
                {
                    courseData.Add(input[0], new List<string>() { input[1] });

                }
                else
                {
                    courseData[input[0]].Add(input[1]);
                }
                input = Console.ReadLine().Split(" : ").ToArray();
            }
            foreach (var item in courseData)
            {
                int count = item.Value.Count;
                Console.WriteLine($"{item.Key}: {count}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine($"-- {item.Value[i]}");
                }
            }
        }
    }
}
