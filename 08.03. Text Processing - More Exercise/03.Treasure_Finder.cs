using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keyInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string stringInput = Console.ReadLine();
            List<string> listOutput = new List<string>();
            string word = "";
            string wordOutput = "";
            int counter = 0;
            while (stringInput != "find")
            {
                for (int i = 0; i < stringInput.Length; i++)
                {
                    char b = stringInput[i];
                    int n = b;
                    for (int k = counter; k < keyInput.Length; k++)
                    {
                        n -= keyInput[k];
                        if(k == keyInput.Length - 1)
                        {
                            counter = 0;
                            break;
                        }
                        counter++;
                        break;
                    }
                    char c = (char)n;
                    word += c;
                }
                listOutput = word.Split('&', '<', '>').ToList();
                Console.WriteLine($"Found {listOutput[1]} at {listOutput[listOutput.Count - 2]}");
                stringInput = Console.ReadLine();
                word = "";
                counter = 0;
            }
        }
    }
}
