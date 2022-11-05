using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startFormat = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            string[] input = startFormat.Split(", ").ToArray();
            int counter = 0;
            Article article = new Article();
            {
                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];
            }
            while (counter < n)
            {
                string[] commands = command.Split(": ").ToArray();
                for (int i = 1; i < commands.Length; i++)
                {
                    string word = commands[i];
                }
                if (commands[0] == "Edit")
                {
                    article.Content = commands[1];
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.Author = commands[1];
                }
                else if (commands[0] == "Rename")
                {
                    article.Title = commands[1];
                }
                counter++;
                command = Console.ReadLine();
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
