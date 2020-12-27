using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> composer = new Dictionary<string, Dictionary<string, string>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var command = input.Split("|");
                var piece = command[0];
                var composerName = command[1];
                var keyName = command[2];

                composer.Add(piece, new Dictionary<string, string>()
                {
                    { "composer", composerName },
                    { "key", keyName }

                });

            }

            string commandString = Console.ReadLine();

            while (commandString != "Stop")
            {
                var cmdArgs = commandString.Split("|");
                var name = cmdArgs[0];
                var pieceName = cmdArgs[1];

                if (name == "Add")
                {
                    var composerName = cmdArgs[2];
                    var keyName = cmdArgs[3];

                    if (composer.ContainsKey(pieceName))
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                    else
                    {
                        composer.Add(pieceName, new Dictionary<string, string>()
                        {
                            { "composer", composerName },
                            { "key", keyName }
                        });

                        Console.WriteLine($"{pieceName} by {composerName} in {keyName} added to the collection!");
                    }
                }
                else if (name == "Remove")
                {
                    if (composer.ContainsKey(pieceName))
                    {
                        composer.Remove(pieceName);
                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (name == "ChangeKey")
                {
                    var newKey = cmdArgs[2];

                    if (composer.ContainsKey(pieceName))
                    {
                        composer[pieceName]["key"] = newKey;
                        Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }

                commandString = Console.ReadLine();
            }

            foreach (var item in composer.OrderBy(x=>x.Key).ThenBy(x=>x.Value["composer"]))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value["composer"]}, Key: {item.Value["key"]}");
            }
        }
    }
}
