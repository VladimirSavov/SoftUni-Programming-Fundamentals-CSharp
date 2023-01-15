using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<h1>");
            string title = Console.ReadLine();
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            string someContent = Console.ReadLine();
            Console.WriteLine($"    {someContent}");
            Console.WriteLine("</article>");
            string comments = Console.ReadLine();
            while (comments != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comments}");
                Console.WriteLine("</div>");
                comments = Console.ReadLine();
            }
        }
    }
}
