using System;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int health = 100;
            int bitcoint = 0;

            var cmdArgs = command.Split("|");

            for (int i = 0; i < cmdArgs.Length; i++)
            {
                var arr = cmdArgs[i].Split();

                if (arr[0] == "potion")
                {
                    if (health < 100)
                    {
                        int count = 100 - health;
                        if (count < int.Parse(cmdArgs[1]))
                        {
                            //cat 10 | potion 30 | orc 10 | chest 10 | snake 25 | chest 110
                            //rat 10 | bat 20 | potion 10 | rat 10 | chest 100 | boss 70 | chest 1000

                        }
                        health += int.Parse(arr[1]);
                        count = 100 - count;

                        if (health >= 100)
                        {
                            health = 100;
                        }
                        Console.WriteLine($"You healed for {count} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (arr[0] == "chest")
                {
                    bitcoint += int.Parse(arr[1]);
                    Console.WriteLine($"You found {arr[1]} bitcoins.");
                }
                else
                {
                    health -= int.Parse(arr[1]);

                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {arr[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {arr[0]}.");
                    }
                }



            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoint}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
