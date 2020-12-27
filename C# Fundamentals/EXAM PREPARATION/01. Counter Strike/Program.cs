using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            int battles = 0;
            int wins = 0;
            bool isWiner = true;

            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                battles++;
                int distance = int.Parse(input);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    isWiner = false;
                    break;
                }

                wins++;
                energy -= distance;

                if (battles % 3 == 0)
                {
                    energy += wins;
                }


                input = Console.ReadLine();
            }

            if (isWiner)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
