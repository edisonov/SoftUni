using System;
using System.Linq;
using System.Collections.Generic;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialNumberOfPlants = int.Parse(Console.ReadLine());
            var dictPlantRarity = new Dictionary<string, int>();
            var dictPlantRating = new Dictionary<string, List<double>>();

            for (int i = 0; i < initialNumberOfPlants; i++)
            {
                string[] input = Console.ReadLine().Split("<->").ToArray();
                string plant = input[0];
                int rarity = int.Parse(input[1]);
                if (dictPlantRarity.ContainsKey(plant) == false)
                {
                    dictPlantRarity[plant] = rarity;
                    dictPlantRating[plant] = new List<double>();
                }

                else if (dictPlantRarity.ContainsKey(plant))
                {
                    dictPlantRarity[plant] = rarity;
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] commandArray = command.Split(": ");
                string leftPartOfCommand = commandArray[0];
                string[] rightPartOfCommand = commandArray[1].Split(" - ");
                string plant = rightPartOfCommand[0];

                if (dictPlantRarity.ContainsKey(plant) == false)
                {
                    Console.WriteLine("error");
                }

                else if (dictPlantRarity.ContainsKey(plant))
                {
                    if (leftPartOfCommand == "Rate")
                    {
                        double rating = double.Parse(rightPartOfCommand[1]);

                        dictPlantRating[plant].Add(rating);
                    }

                    else if (leftPartOfCommand == "Update")
                    {
                        int newRarity = int.Parse(rightPartOfCommand[1]);
                        dictPlantRarity[plant] = newRarity;
                    }

                    else if (leftPartOfCommand == "Reset")
                    {
                        dictPlantRating[plant] = new List<double>();
                    }

                    else
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                }
            }

            PrintAndSortMetod(dictPlantRarity, dictPlantRating);
        }


        private static void PrintAndSortMetod(Dictionary<string, int> dictPlantRarity, Dictionary<string, List<double>> dictPlantRating)
        {
            Console.WriteLine("Plants for the exhibition: ");

            var newsortedDict = new Dictionary<string, List<double>>();
            foreach (var kvp in dictPlantRating.OrderByDescending(x => x.Value.Count > 0 ? x.Value.Average() : 0)) // NB! if(x.Value.Count > 0) x.Value.Average() else 0;
            {
                string plant = kvp.Key;
                double averageRating = kvp.Value.Count > 0 ? kvp.Value.Average() : 0;
                int rarity = dictPlantRarity[plant];
                double rarityDouble = (double)rarity;

                newsortedDict[plant] = new List<double>();
                newsortedDict[plant].Add(rarityDouble);
                newsortedDict[plant].Add(averageRating);
            }

            foreach (var kvp in newsortedDict.OrderByDescending(x => x.Value[0]))
            {
                string plant = kvp.Key;
                double rarity = kvp.Value[0];
                double averageRating = kvp.Value[1];
                Console.WriteLine($"- {plant}; Rarity: {rarity}; Rating: {averageRating:F2}");
            }
        }
    }
}
