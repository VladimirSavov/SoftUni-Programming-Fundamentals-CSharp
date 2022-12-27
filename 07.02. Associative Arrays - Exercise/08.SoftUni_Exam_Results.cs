using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();  
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split("-").ToArray();
            while (!(input[0] == "exam finished"))
            {
                if (input[1] == "banned")
                {
                    results.Remove(input[0]);
                    input = Console.ReadLine().Split("-").ToArray();
                    continue;
                }
                string username = input[0];
                string language = input[1];
                int points = int.Parse(input[2]);
                if (!results.ContainsKey(username))
                {
                    results.Add(username, points);
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                }
                else
                {
                    if (results[username] < points)
                    {
                        results[username] = points;
                    }
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                }
                input = Console.ReadLine().Split("-").ToArray();
            }
            Console.WriteLine("Result:");
            foreach (var item in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
