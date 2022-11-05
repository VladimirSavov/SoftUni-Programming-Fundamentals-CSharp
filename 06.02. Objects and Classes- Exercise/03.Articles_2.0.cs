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
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            string[] input = command.Split(", ").ToArray();
            List<Article> list = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                input = command.Split(", ").ToArray();
                if(input.Length < 2)
                {
                    break;
                }
                Article article = new Article();
                {
                    article.Title = input[0];
                    article.Content = input[1];
                    article.Author = input[2];
                }
                list.Add(article);
                command = Console.ReadLine();
            }
            foreach (Article article in list)
            {
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");

            }
            
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
