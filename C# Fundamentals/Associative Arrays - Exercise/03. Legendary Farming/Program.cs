using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            keyMaterials["motes"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["shards"] = 0;

            bool haseToBreak = false;

            while (true)
            {
                string[] innput = Console.ReadLine().Split();

                for (int i = 0; i < innput.Length; i += 2)
                {
                    int quantity = int.Parse(innput[i]);
                    string materials = innput[i + 1].ToLower();

                    if (materials == "shards" || materials == "motes" || materials == "fragments")
                    {
                        keyMaterials[materials] += quantity;

                        if (keyMaterials[materials] >= 250)
                        {
                            keyMaterials[materials] -= 250;

                            if (materials == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (materials == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if (materials == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }

                            haseToBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(materials))
                        {
                            junkMaterials.Add(materials, 0);
                        }
                        junkMaterials[materials] += quantity;
                    }
                }

                if (haseToBreak)
                {
                    break;
                }
            }
            /*
            Dictionary<string, int> filterKeyMaterial = keyMaterials
                .OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key)
                .ToDictionary(a=>a.Key, a=>a.Value);
            */
            foreach (var item in keyMaterials.OrderByDescending(v=>v.Value).ThenBy(k=>k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMaterials.OrderBy(k=>k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
