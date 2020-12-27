using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int twoPlayer = int.Parse(Console.ReadLine());
            string numbar = Console.ReadLine();


            while (numbar != "End of battle")
            {
                if (numbar == "one")
                {
                    twoPlayer--;
                }
                else if (numbar == "two")
                {
                    firstPlayer--;
                }
                if (firstPlayer == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {twoPlayer}eggs left.");
                }
                else if (twoPlayer == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayer} eggs left.");
                    break;
                }
                numbar = Console.ReadLine();
            }
            if (numbar == "End of battle")
            {
                Console.WriteLine($"Player one has {firstPlayer} eggs left.");
                Console.WriteLine($"Player two has {twoPlayer} eggs left.");
            }
        }
    }
}
