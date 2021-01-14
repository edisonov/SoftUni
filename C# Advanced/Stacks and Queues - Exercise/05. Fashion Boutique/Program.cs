using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(clothesArr);

            int rackCapacity = int.Parse(Console.ReadLine());
            int rackCount = 1;
            int currentRackCapacity = rackCapacity;

            while (clothes.Count > 0)
            {
                int currentClothes = clothes.Peek();

                if (currentRackCapacity >= currentClothes)
                {
                    currentRackCapacity -= currentClothes;
                    clothes.Pop();
                }
                else
                {
                    rackCount++;
                    currentRackCapacity = rackCapacity;
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}
