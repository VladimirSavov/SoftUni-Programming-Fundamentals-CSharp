using System;
using System.Collections;
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
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> rarity = new Dictionary<string, int>();
            Dictionary<string, List<int>> rating = new Dictionary<string, List<int>>();
            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine().Split("<->").ToArray();
                string plant = plantInfo[0];
                int rarityOnPlant = int.Parse(plantInfo[1]);
                if (rating.ContainsKey(plant))
                {
                    rarity[plant] = rarityOnPlant;
                }
                else
                {
                    rarity.Add(plant, rarityOnPlant);
                }
            }
            string[] input = Console.ReadLine().Split(" ").ToArray();
            while (input[0] != "Exhibition")
            {
                if(input[0] == "Rate:")
                {
                    string currPlant = input[1];
                    int currRating = int.Parse(input[3]);
                    if (rating.ContainsKey(currPlant))
                    {
                        rating[currPlant].Add(currRating);
                    }
                    else
                    {
                        rating.Add(currPlant, new List<int> { currRating });
                    }
                }
                else if(input[0] == "Update:")
                {
                    if (!rarity.ContainsKey(input[1]))
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    string currPlant = input[1];
                    int newRarity = int.Parse(input[3]);
                    rarity[currPlant] = newRarity;
                }
                else if (input[0] == "Reset:")
                {
                    if (!rating.ContainsKey(input[1]))
                    {
                        Console.WriteLine("error");
                        break;
                    }
                    string currPlant = input[1];
                    for (int i = 0; i < rating[currPlant].Count; i++)
                    {
                        rating[currPlant].RemoveAt(i);
                    }
                    rating[currPlant].Add(0);
                }
                else
                {
                    Console.WriteLine("error");
                }
                input = Console.ReadLine().Split(" ").ToArray();
            }
            double averageRating = 0;
            double sum = 0;
            int counter = 0;
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in rarity)
            {
                foreach (var items in rating)
                {
                    if(items.Key == item.Key)
                    {
                        averageRating = 0;
                        sum = 0;
                        counter = 0;
                        for (int i = 0; i < items.Value.Count; i++)
                        {
                            sum += items.Value[i];
                            counter++;
                        }
                        averageRating = sum / counter;
                        Console.WriteLine($"- {item.Key}; Rarity: {item.Value}; Rating: {averageRating:F2}");
                    }
                }
            }
        }
    }
}
