using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> person = new Dictionary<string, Dictionary<string, int>>();

            //int count = 0;

            string input = Console.ReadLine();

            while (input != "Results")
            {
                var cmdArgs = input.Split(":");
                var command = cmdArgs[0];

                switch (command)
                {
                    case "Add":
                        var personeName = cmdArgs[1];
                        var health = int.Parse(cmdArgs[2]);
                        var energy = int.Parse(cmdArgs[3]);

                        if (!person.ContainsKey(personeName))
                        {
                           // count++;
                            person.Add(personeName, new Dictionary<string, int>()
                            {
                                { "health" , health },
                                { "energy" , energy}
                            });
                        }
                        else
                        {
                            person[personeName]["health"] += health;
                        }
                        break;
                    case "Attack":
                        var attackerName = cmdArgs[1];
                        var defenderName = cmdArgs[2];
                        var damage = int.Parse(cmdArgs[3]);

                        if (person.ContainsKey(attackerName) && person.ContainsKey(defenderName))
                        {
                            person[defenderName]["health"] -= damage;
                            person[attackerName]["energy"] -= 1;

                            if (person[defenderName]["health"] <= 0)
                            {
                                //count--;
                                person.Remove(defenderName);
                                Console.WriteLine($"{defenderName} was disqualified!");
                            }

                            if (person[attackerName]["energy"] <= 0)
                            {
                               // count--;
                                person.Remove(attackerName);
                                Console.WriteLine($"{attackerName} was disqualified!");
                            }
                        }
                        break;
                    case "Delete":
                        var username = cmdArgs[1];

                        if (username == "All")
                        {
                            person = new Dictionary<string, Dictionary<string, int>>();
                            //count = 0;
                        }

                        if (person.ContainsKey(username))
                        {
                           // count--;
                            person.Remove(username);
                        }
                        break;
                    
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"People count: {person.Count}");

            foreach (var item in person.OrderByDescending(x => x.Value["health"]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value["health"]} - {item.Value["energy"]}");
            }
           
        }
    }
}
