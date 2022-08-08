using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double startBalance = currentBalance;
            string game = Console.ReadLine();   
            while(game != "Game Time")
            {

                if(game == "OutFall 4")
                {
                    if(currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }
                    currentBalance -= 39.99;
                    Console.WriteLine($"Bought OutFall 4");
                }
                else if(game == "CS: OG")
                {
                    if (currentBalance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }
                    currentBalance -= 15.99;
                    Console.WriteLine($"Bought CS: OG");
                }
                else if (game == "Zplinter Zell")
                {
                    if (currentBalance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }
                    currentBalance -= 19.99;
                    Console.WriteLine($"Bought Zplinter Zell");
                }
                else if (game == "Honored 2")
                {
                    if (currentBalance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }
                    currentBalance -= 59.99;
                    Console.WriteLine($"Bought Honored 2");
                }
                else if (game == "RoverWatch")
                {
                    if (currentBalance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }
                    currentBalance -= 29.99;
                    Console.WriteLine($"Bought RoverWatch");
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (currentBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                        game = Console.ReadLine();
                        continue;
                    }
                    currentBalance -= 39.99;
                    Console.WriteLine($"Bought RoverWatch Origins Edition");
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                game = Console.ReadLine();
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            double totalSpentOnGames = startBalance - currentBalance;

            Console.Write($"Total spent: ${totalSpentOnGames:F2}. ");
            Console.Write($"Remaining: ${currentBalance:F2}");
        }
    }
}
