using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentData = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentData.ContainsKey(name))
                {
                    studentData.Add(name, new List<double>() { grade});
                }
                else
                {
                    studentData[name].Add(grade);
                }
            }
            foreach (var item in studentData)
            {
                double average = 0;
                int count = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    average += item.Value[i];
                    count++;
                }
                if (average / count >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {average / count:F2}");
                }
            }
        }
    }
}
