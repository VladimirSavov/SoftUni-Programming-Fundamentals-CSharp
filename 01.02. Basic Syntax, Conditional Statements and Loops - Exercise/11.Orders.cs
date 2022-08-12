using System;
namespace Softuni
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int countOFOrders = int.Parse(Console.ReadLine());
            float totalPrice = 0;
            float priceForCoffee = 0;
            for (int i = 0; i < countOFOrders; i++)
            {
                    int pricePerCapsule = int.Parse(Console.ReadLine());
                    int days = int.Parse(Console.ReadLine());
                    float capsulesCount = float.Parse(Console.ReadLine());
                    priceForCoffee = ((days * capsulesCount) * pricePerCapsule);
                totalPrice += priceForCoffee;
                Console.WriteLine($"The price for the coffee is: ${priceForCoffee:F2}");
           
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
