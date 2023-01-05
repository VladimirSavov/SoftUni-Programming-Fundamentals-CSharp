using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();
            string replacedText = text;
            for (int i = 0; i < banWords.Length; i++)
            {
                int lenght = 0;
                string newX = "";
                if (replacedText.Contains(banWords[i]))
                {
                    lenght = banWords[i].Length;
                    for (int h = 0; h < lenght; h++)
                    {
                        newX += "*";
                    }
                    text = replacedText;
                }
                replacedText = text.Replace(banWords[i], newX);
                
            }
            Console.WriteLine(replacedText);
        }
    }
}
