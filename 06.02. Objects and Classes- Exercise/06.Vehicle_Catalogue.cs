using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;


namespace SoftUni
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double averageOfCars = 0;
            double countOfCars = 0;
            double averageOfTrucks = 0;
            double countOfTrucks = 0;
            List<Vehicle> vehicles = new List<Vehicle>();
            while (input != "End")
            {
                string[] inputArray = input.Split().ToArray(); 
                Vehicle vehicle = new Vehicle();
                {
                    vehicle.Type = inputArray[0];
                    vehicle.Model = inputArray[1];
                    vehicle.Color = inputArray[2];
                    vehicle.HorsePower = int.Parse(inputArray[3]);
                    vehicles.Add(vehicle);
                    if(vehicle.Type == "car")
                    {
                        averageOfCars += vehicle.HorsePower;
                        countOfCars++;
                    }
                    else
                    {
                        averageOfTrucks += vehicle.HorsePower;
                        countOfTrucks++;
                    }
                }
                input = Console.ReadLine();
            }
            string typeVehicle = Console.ReadLine();
            while (typeVehicle != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if(vehicle.Model == typeVehicle)
                    {
                        if(vehicle.Type == "car")
                        {
                            Console.WriteLine($"Type: Car");
                        }
                        else
                        {
                            Console.WriteLine($"Type: Truck");
                        }
                        Console.WriteLine($"Model: {vehicle.Model}");
                        Console.WriteLine($"Color: {vehicle.Color}");
                        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                    }
                }
                typeVehicle = Console.ReadLine();
            }
            Console.WriteLine($"Cars have average horsepower of: {averageOfCars/countOfCars:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageOfTrucks/countOfTrucks:F2}.");
        }
    }
}
