using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Tour = Console.ReadLine();
            string UpdatedTour = "";
            string[] input = Console.ReadLine().Split(":").ToArray();
            while (input[0] != "Travel")
            {
                if (input[0] == "Add Stop")
                {
                    if (int.Parse(input[1]) + input[2].Length <= Tour.Length)
                    {
                        UpdatedTour = Tour.Insert(int.Parse(input[1]), input[2]);
                        Tour = UpdatedTour;
                    } 
                }
                else if(input[0] == "Remove Stop")
                {
                    if(int.Parse(input[2]) <= Tour.Length)
                    {
                        UpdatedTour = Tour.Remove(int.Parse(input[1]), int.Parse(input[2]) - int.Parse(input[1]) + 1);
                        Tour = UpdatedTour;
                    }
                }
                else if (input[0] == "Switch")
                {
                    if (Tour.Contains(input[1]))
                    {
                        char c = input[1][0]; 
                        int startIndex = Tour.IndexOf(c);
                        UpdatedTour = Tour.Remove(startIndex, input[1].Length);
                        Tour = UpdatedTour;
                        UpdatedTour = Tour.Insert(startIndex, input[2]);
                        Tour = UpdatedTour;
                    }
                }
                Console.WriteLine(UpdatedTour);
                input = Console.ReadLine().Split(":").ToArray();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {UpdatedTour}");
        }
    }
}
