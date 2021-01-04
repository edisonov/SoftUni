using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> softUni = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] cmdArgs = input.Split(":");
                string contest = cmdArgs[0];
                string password = cmdArgs[1];

                contests.Add(contest, password);

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "end of submissions")
            {
                var cmdArgs = command.Split("=>");
                var contest = cmdArgs[0];
                var password = cmdArgs[1];
                var username = cmdArgs[2];
                int points = int.Parse(cmdArgs[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests.ContainsValue(password))
                    {
                        if (!softUni.ContainsKey(username))
                        {
                            softUni.Add(username, new Dictionary<string, int>());
                            softUni[username].Add(contest, points);
                        }
                        else
                        {
                            if (softUni[username].ContainsKey(contest))
                            {
                                if (points > softUni[username][contest])
                                {
                                    softUni[username][contest] = points;
                                }
                            }
                            else
                            {
                                softUni[username].Add(contest, points);

                            }

                        }

                    }
                }

                command = Console.ReadLine();
            }
            Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();
            foreach (var kvp in softUni)
            {
                usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }
            string bestName = usernameTotalPoints
                .Keys
                .Max();
            int bestPoints = usernameTotalPoints
                .Values
                .Max();

            foreach (var kvp in usernameTotalPoints)
            {
                if (kvp.Value == bestPoints)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }
            Console.WriteLine("Ranking:");
            foreach (var name in softUni.OrderBy(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine("{0}", name.Key);
                foreach (var kvp in name.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", kvp.Key, kvp.Value);
                }

            }
        }
    }
}
