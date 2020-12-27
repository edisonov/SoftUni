using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> town =
                new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "Sail")
            {
                string[] tokens = command.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string towns = tokens[0];
                int population = int.Parse(tokens[1]);
                int gold = int.Parse(tokens[2]);

                if (town.ContainsKey(towns))
                {
                    town[towns]["population"] += population;
                    town[towns]["gold"] += gold;

                }
                else
                {
                    town.Add(towns, new Dictionary<string, int>()
                    {
                        { "population", population },
                        { "gold", gold }
                    });
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string towns = tokens[1];
                int people;
                int gold;
                switch (tokens[0])
                {
                    case "Plunder":
                        people = int.Parse(tokens[2]);
                        gold = int.Parse(tokens[3]);

                        Console.WriteLine($"{towns} plundered! {gold} gold stolen, {people} citizens killed.");
                        town[towns]["population"] -= people;
                        town[towns]["gold"] -= gold;

                        if (town[towns]["population"] <= 0 || town[towns]["gold"] <= 0)
                        {
                            Console.WriteLine($"{towns} has been wiped off the map!");
                            town.Remove(towns);
                        }

                        break;
                    case "Prosper":
                        gold = int.Parse(tokens[2]);

                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        else
                        {
                            town[towns]["gold"] += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {towns} now has {town[towns]["gold"]} gold.");
                        }
                        break;

                }

                command = Console.ReadLine();
            }

            if (town.Count > 0)
            {
                town = town
                    .OrderByDescending(x => x.Value["gold"])
                    .ThenBy(t => t.Key)
                    .ToDictionary(k => k.Key, v => v.Value);

                Console.WriteLine($"Ahoy, Captain! There are {town.Count} wealthy settlements to go to:");

                foreach (var item in town)
                {
                    int population = item.Value["population"];
                    int gold = item.Value["gold"];
                    Console.WriteLine($"{item.Key} -> Population: {population} citizens, Gold: {gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
