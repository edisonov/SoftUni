using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> continets =
                new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!continets.ContainsKey(continent))
                {
                    continets.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continets[continent].ContainsKey(country))
                {
                    continets[continent].Add(country, new List<string>());
                }

                continets[continent][country].Add(city);
            }

            foreach (var continent in continets)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.Write($" {country.Key} -> ");
                    for (int i = 0; i < country.Value.Count; i++)
                    {
                        if (i != 0)
                        {
                            Console.Write(", ");
                        }

                        Console.Write($"{country.Value[i]}");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
