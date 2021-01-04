
using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dwarf = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {

                var command = input.Split(" <:> ");
                var dwarfName = command[0];
                var dwarfHatColor = command[1];
                var dwarfPhysics = int.Parse(command[2]);

                if (dwarf.ContainsKey(dwarfHatColor) && dwarf[dwarfHatColor].ContainsKey(dwarfName))
                {
                    if (dwarf[dwarfHatColor][dwarfName] < dwarfPhysics)
                    {
                        dwarf[dwarfHatColor][dwarfName] = dwarfPhysics;
                    }
                }
                else
                {
                    if (!dwarf.ContainsKey(dwarfHatColor))
                    {
                        dwarf.Add(dwarfHatColor, new Dictionary<string, int>());
                        dwarf[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                    }
                    else
                    {
                        dwarf[dwarfHatColor].Add(dwarfName, dwarfPhysics);
                    }
                }

                input = Console.ReadLine();
            }

           // var total = dwarf.OrderByDescending(x => x.Key);

            foreach (var item in dwarf.OrderByDescending(x=>x.Value.Values).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"({item.Key}) {item.Value.Keys} <-> {item.Value.Values}");
            }
        }
    }
}
