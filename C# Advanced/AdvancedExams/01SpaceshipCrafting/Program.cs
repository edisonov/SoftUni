using System;
using System.Collections.Generic;
using System.Linq;

namespace _01SpaceshipCrafting
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GlassValue = 25;
            const int AluminiumValue = 50;
            const int LithiumValue = 75;
            const int CarbonValue = 100;

            Stack<int> items = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            Dictionary<string, int> crafting = new Dictionary<string, int>
            {
                {"Aluminium",0 },
                {"Carbon fiber",0 },
                {"Glass",0 },
                {"Lithium",0 }
            };

            while (liquids.Count > 0 && items.Count > 0)
            {
                int currentLiquid = liquids.Dequeue();
                int currentItems = items.Pop();

                int sum = currentLiquid + currentItems;

                switch (sum)
                {
                    case GlassValue:
                        crafting["Glass"] += 1;
                        break;
                    case AluminiumValue:
                        crafting["Aluminium"] += 1;
                        break;
                    case CarbonValue:
                        crafting["Carbon fiber"] += 1;
                        break;
                    case LithiumValue:
                        crafting["Lithium"] += 1;
                        break;
                    default:
                        items.Push(currentItems + 3);
                        break;

                }
            }


        }
    }
}
