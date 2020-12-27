using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> town = new List<string>();
            string pattern = @"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1";
            int count = 0;
            string input = Console.ReadLine();

            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match item in match)
            {
                var word = item.Groups["location"].Value;
                count += item.Groups["location"].Length;

                town.Add($"{word}");
            }

            if (town.Count > 0)
            {
                Console.WriteLine($"Destinations: {string.Join(", ",town)}");
                Console.WriteLine($"Travel Points: {count}");
            }
            else
            {
                Console.WriteLine($"Destinations:");
                Console.WriteLine($"Travel Points: {count}");
            }

            

            

           


        }
    }
}
