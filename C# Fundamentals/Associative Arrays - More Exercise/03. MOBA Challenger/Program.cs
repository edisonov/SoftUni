using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "Season end")
            {
                if (command.Contains("vs"))
                {
                    string[] duel = command.Split(" vs ");
                    string userName1 = duel[0];
                    string userName2 = duel[1];

                    if (players.ContainsKey(userName1) && players.ContainsKey(userName2))
                    {
                        int points1 = 0;
                        int points2 = 0;
                        foreach (var item in players[userName1])
                        {
                            if (players[userName2].ContainsKey(item.Key))
                            {
                                points1 = item.Value;
                            }
                        }

                        foreach (var items in players[userName2])
                        {
                            if (players[userName1].ContainsKey(items.Key))
                            {
                                points2 = items.Value;
                            }
                        }

                        if (points1 > points2)
                        {
                            players.Remove(userName2);
                        }
                        else if (points2 > points1)
                        {
                            players.Remove(userName1);

                        }
                    }
                }
                else
                {
                    string[] cmdArgs = command.Split(" -> ");
                    string player = cmdArgs[0];
                    string position = cmdArgs[1];
                    int skill = int.Parse(cmdArgs[2]);

                    if (!players.ContainsKey(player))
                    {
                        players[player] = new Dictionary<string, int>();
                        players[player][position] = skill;

                    }
                    else
                    {
                        if (!players[player].ContainsKey(position))
                        {
                            players[player].Add(position, skill);
                        }
                        else
                        {
                            if (players[player][position] < skill)
                            {
                                players[player][position] = skill;
                            }
                        }
                    }


                }

                command = Console.ReadLine();
            }

            Dictionary<string, int> usernameTotalPoints = new Dictionary<string, int>();
            foreach (var kvp in players)
            {
                usernameTotalPoints[kvp.Key] = kvp.Value.Values.Sum();
            }

            int bestPoints = usernameTotalPoints
                .Values
                .Max();

            foreach (var kvp in usernameTotalPoints.OrderByDescending(x=>x.Value))
            {
                
                Console.WriteLine($"{kvp.Key}: {kvp.Value} skill");
                foreach (var item in players[kvp.Key].OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }

            }
            
        }
    }
}
