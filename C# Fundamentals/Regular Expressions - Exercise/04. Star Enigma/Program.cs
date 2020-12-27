using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int messages = int.Parse(Console.ReadLine());
            string fullPattern = @"@(?<name>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<type>A|D)![^@\-!:>]*->(?<soldierCount>\d+)";
            string starPattern = @"[starSTAR]";

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < messages; i++)
            {
                string message = Console.ReadLine();
                MatchCollection starMatches = Regex.Matches(message, starPattern);
                int countLetters = starMatches.Count;

                string decryptedMessage = string.Empty;

                foreach (var letter in message)
                {
                    decryptedMessage += (char)(letter - countLetters);
                }

                Match planetValid = Regex.Match(decryptedMessage, fullPattern);
                if (planetValid.Success)
                {
                    string planetName = planetValid.Groups["name"].Value;
                    string typeAttack = planetValid.Groups["type"].Value;

                    if (typeAttack == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else if (typeAttack == "D")
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            if (attackedPlanets.Any())
            {
                attackedPlanets.Sort();
                foreach (var planet in attackedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Any())
            {
                destroyedPlanets.Sort();
                foreach (var planet in destroyedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
