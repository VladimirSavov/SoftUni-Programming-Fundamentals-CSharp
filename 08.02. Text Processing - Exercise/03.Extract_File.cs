using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] file = Console.ReadLine().Split(@"\").ToArray();
            string fileName = file[file.Length - 1];
            string[] fileParts = fileName.Split(".").ToArray();
            Console.WriteLine($"File name: {fileParts[0]}");
            Console.WriteLine($"File extension: {fileParts[1]}");
        }
    }
}
