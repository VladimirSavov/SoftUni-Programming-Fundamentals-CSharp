using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ").ToArray();
            string input = Console.ReadLine();
            Dictionary<string, int> output = new Dictionary<string, int>();
            string nameIsTrue = "";
            while (input != "end of race")
            {
                int currKm = 0;
                nameIsTrue = "";
                for (int i = 0; i < names.Length; i++)
                {
                    string currName = names[i];
                    nameIsTrue = "";
                    currKm = 0;
                    for (int j = 0; j < currName.Length; j++)
                    {
                        for (int k = j; k < input.Length; k++)
                        {
                            if (currName[j] == input[k])
                            {
                                nameIsTrue += input[k];
                                break;
                            }
                        }
                        if(j == 0)
                        {
                            for (int h = 0; h  < input.Length; h ++)
                            {
                                if (input[h] >= 48 && input[h] <= 57)
                                {
                                    currKm += int.Parse(input[h].ToString());
                                }
                            }
                        }
                    }
                    foreach (var item in names)
                    {
                        if(item == nameIsTrue)
                        {
                            if (!output.ContainsKey(item))
                            {
                                output.Add(item, currKm);
                                nameIsTrue = "";
                                currKm = 0;
                            }
                            else
                            {
                                output[item] += currKm;
                                nameIsTrue = "";
                                currKm = 0;
                            }
                        }
                    }
                }
                input = Console.ReadLine(); 
            }
            var outputFinal = output.OrderByDescending(x => x.Value);
            int c = 0;
            foreach (var item in outputFinal)
            {
                if(c == 0)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                    c = 1;
                }
                else if(c == 1)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                    c = 2;
                }
                else if (c == 2)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                    c = 3;
                }

            }    
        }
    }
}
