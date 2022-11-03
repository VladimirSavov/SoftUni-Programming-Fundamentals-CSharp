using System;
using System.Collections.Generic;
using System.Linq;


namespace SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> output = new List<Box>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] input = command.Split().ToArray();
                string SerialNumber = input[0];
                string ItemName = input[1];
                string ItemQuantity = input[2];
                double ItemPrice = double.Parse(input[3]);
                double PriceforaBox = double.Parse(input[2]) * double.Parse(input[3]);
                Box box = new Box();
                {
                    box.SerialNumber = SerialNumber;
                    box.ItemQuantity = ItemQuantity;
                    box.PriceforaBox = PriceforaBox;
                    box.Name = ItemName;
                    box.Price = ItemPrice;
                }
                output.Add(box);

                command = Console.ReadLine();
            }
            List<Box> sortedBox = output.OrderBy(sort => sort.PriceforaBox).ToList();
            sortedBox.Reverse();
            foreach (Box box in sortedBox)
            {
                Console.WriteLine($@"{box.SerialNumber}
-- {box.Name} - ${box.Price:F2}: {box.ItemQuantity}
-- ${box.PriceforaBox:F2}");
            }
        }

    }
    class Box
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }

        public string ItemQuantity { get; set; }

        public double PriceforaBox { get; set; }
    }
}

