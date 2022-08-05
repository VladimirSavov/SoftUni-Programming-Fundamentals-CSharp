using System;

namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();
            double coin = 0.0;
            double totalCoins = 0.0;
            while (coins != "Start")
            {
                coin = double.Parse(coins);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    totalCoins += double.Parse(coins);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }

                coins = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                if(product == "Nuts")
                {
                    if (totalCoins < 2)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break; ;
                    }
                    totalCoins -= 2;
                    Console.WriteLine($"Purchased nuts");
                }
                else if(product == "Water")
                {
                    if (totalCoins < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break; ;
                    }
                    totalCoins -= 0.7;
                    Console.WriteLine($"Purchased water");
                }
                else if(product == "Crisps")
                {
                    if (totalCoins < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");;
                        break; ;
                    }
                    totalCoins -= 1.5;
                    Console.WriteLine($"Purchased crisps");
                }
                else if(product == "Soda")
                {
                    if (totalCoins < 0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }
                    totalCoins -= 0.8;
                    Console.WriteLine($"Purchased soda");
                }
                else if(product == "Coke")
                {
                    if (totalCoins < 1)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }
                    totalCoins -= 1;
                    Console.WriteLine($"Purchased coke");                 
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {Math.Abs(totalCoins):F2}");
        }
    }
}
