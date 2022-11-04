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
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split("/").ToArray();
                if (input[0] == "Car")
                {
                    Car car = new Car();
                    {
                        car.Brand = input[1];
                        car.Model = input[2];
                        car.HorsePower = int.Parse(input[3]);
                    }
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    {
                        truck.Brand = input[1];
                        truck.Model = input[2];
                        truck.Weight = int.Parse(input[3]);
                    }
                    trucks.Add(truck);
                }
                command = Console.ReadLine();

            }
            List<Car> sortedCars = cars.OrderBy(sort => sort.Brand).ToList();
            List<Truck> sortedTrucks = trucks.OrderBy(sort => sort.Brand).ToList();
            if(cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

                }

            }
            if(trucks.Count > 0)
            {
            Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }   

            }
        }

    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
}
