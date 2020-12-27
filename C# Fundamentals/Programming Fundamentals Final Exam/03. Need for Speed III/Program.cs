using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> cars = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var carInfo = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
                var name = carInfo[0];
                var mileage = int.Parse(carInfo[1]);
                var fuel = int.Parse(carInfo[2]);
                cars.Add(name,
                    new Dictionary<string, int>()
                    {
                        {"mileage", mileage },
                        {"fuel", fuel} 
                    });

            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                var tokens = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                var action = tokens[0];
                var carName = tokens[1];

                switch (action)
                {
                    case "Drive":

                        var distance = int.Parse(tokens[2]);
                        var fuel = int.Parse(tokens[3]);
                        var carFuel = cars[carName]["fuel"];

                        if (fuel > carFuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[carName]["mileage"] += distance;
                            cars[carName]["fuel"] -= fuel;

                            Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }

                        if (cars[carName]["mileage"] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {carName}!");
                            cars.Remove(carName);
                        }
                        break;
                    case "Refuel":
                        var fuelToAdd = int.Parse(tokens[2]);
                        var currentFuel = cars[carName]["fuel"];

                        if (fuelToAdd + currentFuel > 75)
                        {
                            fuelToAdd = 75 - currentFuel;
                        }

                        cars[carName]["fuel"] += fuelToAdd;

                        Console.WriteLine($"{carName} refueled with {fuelToAdd} liters");

                        break;
                    case "Revert":
                        var kilometers = int.Parse(tokens[2]);
                        cars[carName]["mileage"] -= kilometers;

                        if (cars[carName]["mileage"] < 10000)
                        {
                            cars[carName]["mileage"] = 10000;
                        }
                        else
                        {
                            Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");      
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            var ordered = cars.OrderByDescending(x => x.Value["mileage"]).ThenBy(x => x.Key);

            foreach (var car in ordered)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value["mileage"]} kms, Fuel in the tank: {car.Value["fuel"]} lt.");
            }
        }
    }
}
